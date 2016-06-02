// Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
// This source code is licensed under the MIT license found in the
// LICENSE.txt file in the root directory of this source tree.

using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace server
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory factory)
        {
            factory.AddConsole(LogLevel.Trace);

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "public"))
            });

            app.UseWelcomePage();
        }

        public static void Main()
        {
            var appRoot = Directory.GetCurrentDirectory();

            if (Path.GetFileName(appRoot) == "server") {
                appRoot = Path.GetDirectoryName(appRoot);
            }

            var host = new WebHostBuilder()
                .UseContentRoot(appRoot)
                .UseKestrel()
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
