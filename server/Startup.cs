// Copyright © 2014-present Kriasoft, LLC. All rights reserved.
// This source code is licensed under the MIT license found in the
// LICENSE.txt file in the root directory of this source tree.

using System.IO;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Facebook;

namespace Server
{
    public class Startup
    {
        // Load application settings from JSON file(s)
        // https://docs.asp.net/en/latest/fundamentals/configuration.html
        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile($"appsettings.json", optional: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .Build();
        }

        public IConfiguration Configuration { get; set; }

        // Configure IoC container
        // https://docs.asp.net/en/latest/fundamentals/dependency-injection.html
        public void ConfigureServices(IServiceCollection services)
        {
            // https://docs.asp.net/en/latest/security/anti-request-forgery.html
            services.AddAntiforgery(options => options.Cookie.Name =  options.HeaderName = "X-XSRF-TOKEN");

            // Register Entity Framework database context
            // https://docs.efproject.net/en/latest/platforms/aspnetcore/new-db.html
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<DatabaseContext>()
                .AddDefaultTokenProviders();

            services.AddMvcCore()
                .AddAuthorization()
                .AddViews()
                .AddRazorViewEngine()
                .AddJsonFormatters();


            // Enable external authentication provider(s)
            // https://docs.asp.net/en/latest/security/authentication/sociallogins.html
            if (!string.IsNullOrEmpty(Configuration["Authentication:Facebook:AppId"]))
            {
                services.AddAuthentication()
                            .AddFacebook(o =>
                            {
                                o.AppId = Configuration["Authentication:Facebook:AppId"];
                                o.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
                                o.Scope.Add("email");
                                o.Fields.Add("name");
                                o.Fields.Add("email");
                                o.SaveTokens = true;
                            });
            }
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory factory)
        {
            // Configure logging
            // https://docs.asp.net/en/latest/fundamentals/logging.html
            factory.AddConsole(Configuration.GetSection("Logging"));
            factory.AddDebug();

            // Serve static files
            // https://docs.asp.net/en/latest/fundamentals/static-files.html
            app.UseStaticFiles();

            app.UseAuthentication();

            // Configure ASP.NET MVC
            // https://docs.asp.net/en/latest/mvc/index.html
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{*url}", new { controller = "Home", action = "Index" });
            });
        }

        public static void Main()
        {
            var cwd = Directory.GetCurrentDirectory();
            var web = Path.GetFileName(cwd) == "server" ? "../public" : "public";

            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseWebRoot(web)
                .UseKestrel()
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
