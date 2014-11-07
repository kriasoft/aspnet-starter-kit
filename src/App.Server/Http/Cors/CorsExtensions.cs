// Copyright (c) KriaSoft, LLC.  All rights reserved.
// Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Cors;
using System.Web.Http;
using System.Web.Http.Cors;

using Microsoft.Owin.Cors;

namespace Owin
{
    public static class CorsExtensions
    {
        private static readonly EnableCorsAttribute Cors;

        static CorsExtensions()
        {
            Cors = string.IsNullOrWhiteSpace(WebConfigurationManager.AppSettings["cors:Origin"]) ?
                null :
                new EnableCorsAttribute(
                    WebConfigurationManager.AppSettings["cors:Origins"],
                    WebConfigurationManager.AppSettings["cors:Headers"],
                    WebConfigurationManager.AppSettings["cors:Methods"]);
        }

        public static IAppBuilder UseCorsFromAppSettings(this IAppBuilder app, string path)
        {
            if (Cors != null)
            {
                app.UseCors(new CorsOptions
                {
                    PolicyProvider = new CorsPolicyProvider
                    {
                        PolicyResolver = request =>
                            request.Path.Value == path ?
                            Cors.GetCorsPolicyAsync(null, CancellationToken.None) :
                            Task.FromResult<CorsPolicy>(null)
                    }
                });
            }

            return app;
        }

        public static void UseCorsFromAppSettings(this HttpConfiguration httpConfiguration)
        {
            if (Cors != null)
            {
                httpConfiguration.EnableCors(Cors);
            }
        }
    }
}