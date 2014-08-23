// Copyright (c) KriaSoft, LLC.  All rights reserved.
// Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Web.Http;

using App.Server.Data;
using App.Server.Services;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(App.Server.Startup))]

namespace App.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //// For more information on how to configure your application, visit
            //// http://go.microsoft.com/fwlink/?LinkID=316888

            // Configure Dependency Injection (DI)
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

            // Map SignalR hubs to the app builder pipeline at "/signalr”.
            app.MapSignalR();

            // Configure Web API
            var config = new HttpConfiguration();

            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
            
            app.UseWebApi(config);
            
        }
    }
}
