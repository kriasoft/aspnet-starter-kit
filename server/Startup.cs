// Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
// This source code is licensed under the MIT license found in the
// LICENSE.txt file in the root directory of this source tree.

using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

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

            app.UseStaticFiles();

            dynamic assets;

            using (var stream = File.OpenRead(Path.Combine(env.WebRootPath, "./assets/assets.json")))
            using (var reader = new StreamReader(stream))
            {
                assets = JsonConvert.DeserializeObject(reader.ReadToEnd());
            }

            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html";
                await context.Response.WriteAsync($@"<!doctype html>
<html lang="""">
  <head>
    <meta charset=""utf-8"">
    <meta http-equiv=""x-ua-compatible"" content=""ie=edge"">
    <title>F# Starter Kit</title>
    <meta name=""description"" content="""">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
    <link rel=""stylesheet"" href=""https://cdn.rawgit.com/tleunen/react-mdl/master/extra/material.min.css"">
    <link rel=""stylesheet"" href=""https://cdn.rawgit.com/isagalaev/highlight.js/master/src/styles/default.css"">
    <link rel=""apple-touch-icon"" href=""apple-touch-icon.png"">
  </head>
  <body>
    <div id=""container""></div>
    <script src=""https://cdn.rawgit.com/tleunen/react-mdl/master/extra/material.min.js""></script>
    <script src=""{assets.main.js}""></script>
    <script>
      window.ga=function(){{ga.q.push(arguments)}};ga.q=[];ga.l=+new Date;
      ga('create','UA-XXXXX-Y','auto');ga('send','pageview')
    </script>
    <script src=""https://www.google-analytics.com/analytics.js"" async defer></script>
  </body>
</html>");
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
