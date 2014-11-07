// Copyright (c) KriaSoft, LLC.  All rights reserved.
// Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.Validation;

using App.Server.Data;
using App.Server.Http.Validation;
using App.Server.Security;
using App.Server.Services;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Owin;

[assembly: OwinStartup(typeof(App.Server.Startup))]

namespace App.Server
{
    public class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit
            // http://go.microsoft.com/fwlink/?LinkID=316888

            // Dependency Injection (DI)
            // ---------------------------------------------------------------------------------------------------------
            app.CreatePerOwinContext(() => new ApplicationDbContext());
            app.CreatePerOwinContext<ApplicationUserManager>((options, context) =>
            {
                var manager = new ApplicationUserManager(new UserStore(context.Get<ApplicationDbContext>()));

                // Configure validation logic for usernames
                manager.UserValidator = new UserValidator<User, int>(manager)
                {
                    AllowOnlyAlphanumericUserNames = false,
                    RequireUniqueEmail = true
                };

                // Configure validation logic for passwords
                manager.PasswordValidator = new PasswordValidator
                {
                    RequiredLength = 6,
                    RequireNonLetterOrDigit = true,
                    RequireDigit = true,
                    RequireLowercase = true,
                    RequireUppercase = true,
                };

                manager.EmailService = new EmailService();

                return manager;
            });

            // ASP.NET Web API & SignalR
            // ---------------------------------------------------------------------------------------------------------
            var config = new HttpConfiguration();
            var formatters = config.Formatters;
            var services = config.Services;

            // Enable CORS for Web API
            config.UseCorsFromAppSettings();

            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Remove unused formatters
            formatters.Remove(formatters.XmlFormatter);
            formatters.Remove(formatters.FormUrlEncodedFormatter);
            formatters.Remove(formatters.First(f => f.GetType() == typeof(JQueryMvcFormUrlEncodedFormatter)));

            // Customize JSON serialization and validation error responses
            formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            services.Replace(typeof(IBodyModelValidator), new CustomBodyModelValidator(services.GetBodyModelValidator()));

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
            
            app.UseWebApi(config);

            // Map SignalR hubs to the app builder pipeline at "/signalr”.
            app.MapSignalR();

            // Authentication & Authorization
            // ---------------------------------------------------------------------------------------------------------

            // Enable CORS for ASP.NET Identity
            app.UseCorsFromAppSettings("/token");

            // Enable the application to use a cookie to store information for the signed in user and to use a cookie
            // to temporarily store information about a user logging in with a third party login provider
            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Configure the application for OAuth based flow
            PublicClientId = "self";
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/token"),
                Provider = new ApplicationOAuthProvider(PublicClientId),
                AuthorizeEndpointPath = new PathString("/api/account/authorize"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                AllowInsecureHttp = true
            };

            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthOptions);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //    consumerKey: "",
            //    consumerSecret: "");

            //app.UseFacebookAuthentication(
            //    appId: "",
            //    appSecret: "");

            //app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            //{
            //    ClientId = "",
            //    ClientSecret = ""
            //});
        }
    }
}
