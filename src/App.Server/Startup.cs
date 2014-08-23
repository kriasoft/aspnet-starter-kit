// Copyright (c) KriaSoft, LLC.  All rights reserved.
// Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Runtime.Remoting.Contexts;

using App.Server.Data;
using App.Server.Services;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
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

            // Configure dependency injection (DI)
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
        }
    }
}
