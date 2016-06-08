# ASP.NET Core Starter Kit &nbsp; ![Status](https://img.shields.io/badge/status-early%20preview-orange.svg?style=flat-square) [![Online Chat](http://img.shields.io/badge/chat-%23aspnet--starter--kit-blue.svg?style=flat-square)](https://gitter.im/kriasoft/aspnet-starter-kit) [![Tips](https://img.shields.io/badge/donate-PayPal-blue.svg?style=flat-square)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=DSV6K6LZU2VGW)

> [ASP.NET Core Starter Kit](https://github.com/kriasoft/aspnet-starter-kit) is an opinionated
> boilerplate for web development based on [.NET Core](http://dotnet.github.io/),
> [Kestrel](https://github.com/aspnet/KestrelHttpServer), [GraphQL](http://graphql.org/) on the
> backend and [Babel](http://babeljs.io/), [Webpack](https://webpack.github.io/),
> [React](https://facebook.github.io/react) on the frontend. This boilerplate comes in both
> [C#](https://github.com/kriasoft/aspnet-starter-kit) and
> [F#](https://github.com/kriasoft/fsharp-starter-kit) flavors.


### Features

&nbsp; &nbsp; ✓ Component-based front-end development with [Webpack](https://webpack.github.io/), [CSS Modules](https://github.com/css-modules/css-modules) and [React](https://facebook.github.io/react) (see [`tools/webpack.config.js`](./tools/webpack.config.js))<br>
&nbsp; &nbsp; ✓ Modern JavaScript syntax ([ES2015](http://babeljs.io/docs/learn-es2015/)+) via [Babel](http://babeljs.io/); modern CSS syntax (CSS3+) via [PostCSS](https://github.com/postcss/postcss)<br>
&nbsp; &nbsp; ✓ Application state management via [Redux](http://redux.js.org/) (coming soon)<br>
&nbsp; &nbsp; ✓ Routing and navigation via [React App](https://github.com/kriasoft/react-app), [Universal Router](https://github.com/kriasoft/universal-router) and [History](https://github.com/mjackson/history) `npm` modules<br>
&nbsp; &nbsp; ✓ [Code-splitting](https://github.com/webpack/docs/wiki/code-splitting) and async chunk loading with [Webpack](https://webpack.github.io/) and [ES6 System.import()](http://www.2ality.com/2014/09/es6-modules-final.html)<br>
&nbsp; &nbsp; ✓ Hot Module Replacement ([HMR](https://webpack.github.io/docs/hot-module-replacement.html)) /w [React Hot Loader](http://gaearon.github.io/react-hot-loader/) (coming soon)<br>
&nbsp; &nbsp; ✓ Cross-device testing with [Browsersync](https://browsersync.io/) (coming soon)<br>
&nbsp; &nbsp; ✓ Git-based deployment to [Azure App Service](https://azure.microsoft.com/services/app-service/) (see [`tools/deploy.js`](./tools/deploy.js))<br>
&nbsp; &nbsp; ✓ 24/7 community support on [Gitter](https://gitter.im/kriasoft/aspnet-starter-kit) or [StackOverflow](http://stackoverflow.com/questions/tagged/aspnet-starter-kit); customization requests on [Codementor](https://www.codementor.io/koistya)<br>


### Directory Layout

```shell
.
├── /.vscode/                   # Visual Studio Code settings
├── /build/                     # The folder for compiled output
├── /client/                    # Client-side app (frontend)
├── /client.test/               # Unit and integration tests for the frontend app
├── /public/                    # Static files such as favicon.ico etc.
├── /server/                    # Web server and data API (backend)
├── /server.test/               # Unit and integration tests for the backend app
├── /tools/                     # Build automation scripts and utilities
│── jsconfig.json               # Visual Studio Code settings for JavaScript
│── LICENSE.txt                 # Licensing information
│── package.json                # The list of project dependencies and NPM scripts
└── README.md                   # Project overview / getting started guide
```


### Prerequisites

* OS X, Windows or Linux
* [Node.js](https://nodejs.org) v6 or newer
* [.NET Core v1.0 RC2](https://blogs.msdn.microsoft.com/dotnet/2016/05/16/announcing-net-core-rc2/)
* [Visual Studio Code](https://code.visualstudio.com/) with [C# extension](https://github.com/OmniSharp/omnisharp-vscode)


### Getting Started

`1`. Clone the latest version of **ASP.NET Core Starter Kit** on your local machine by running:

```shell
$ git clone -o aspnet-starter-kit -b master --single-branch \
      https://github.com/kriasoft/aspnet-starter-kit.git MyApp
$ cd MyApp
```

`2`. Install project dependencies listed in [`project.json`](./server/project.json) and
[`package.json`](./package.json) files by running: 

```shell
$ dotnet restore                # Installs .NET dependencies listed in project.json
$ npm install                   # Installs Node.js dependencies listed in package.json
```

`3`. Finally, launch the web app by running:

```shell
$ npm start                     # Compiles and lanches the app
```

The app should become available at [http://localhost:5000/](http://localhost:5000/)


### How to Deploy

Before you can deploy your app to [Azure App Service](https://azure.microsoft.com/services/app-service/),
you need to open Web App settings in [Azure Portal](https://portal.azure.com/), go to "Deployment
Source", select "Local Git Repository" and hit [OK]. Then copy and paste "Git clone URL" of your
Web App into [`tools/deploy.js`](./tools/deploy.js) file. Then, whenever you need to compile your
app into a distributable format and upload that to Windows Azure App Service, simply run:

```shell
$ npm run deploy                # Same as running: node tools/deploy --production
```


### References

<table width="100%">
  <tr>
    <td width="185">
      <a href="http://amzn.to/25J77RT">
        <img src="http://ecx.images-amazon.com/images/I/51PoyFDMopL._SX150.jpg" width="150" height="185" alt="C# 6 and .NET Core 1.0: Modern Cross-Platform Development" />
      </a>
    </td>
    <td>
      <p>
        <strong><a href="http://amzn.to/25J77RT">C# 6 and .NET Core 1.0: Modern Cross-Platform Development</a></strong><br />
        <sup>by Mark J. Price (Mar 2016)</sup>
      </p>
      <p>In this book you will learn:</p>
      <ul>
        <li>Build cross-platform applications using C# 6 and .NET Core 1.0</li>
        <li>Explore ASP.NET Core 1.0 and learn how to create professional web applications</li>
        <li>Improve your application's performance using multitasking</li>
        <li>Use Entity Framework Core 1.0 and learn how to build Code-First databases</li>
        <li>Master object-oriented programming with C# to increase code reuse and efficiency</li>
        <li>Familiarize yourself with cross-device app development using the Universal Windows Platform and XAML</li>
        <li>Query and manipulate data using LINQ</li>
        <li>Protect your data by using encryption and hashing</li>
      </p>
    </td>
  </tr>
</table>


### Related Projects

* [React Starter Kit](https://github.com/kriasoft/react-starter-kit) — Isomorphic web app boilerplate (Node.js, Express, GraphQL, React)
* [Babel Starter Kit](https://github.com/kriasoft/babel-starter-kit) — JavaScript library boilerplate (ES2015+, Babel, Rollup)
* [ASP.NET Core Starter Kit `|>` F#](https://github.com/kriasoft/fsharp-starter-kit) — Web app boilerplate (F#, .NET Core, Kestrel, GraphQL, React)
* [Universal Router](https://github.com/kriasoft/universal-router) — Isomorphic router for web and single-page applications (SPA)
* [Membership Database](https://github.com/membership/membership.db) — SQL database boilerplate for web app users, roles and auth tokens


### Get in Touch

* [#aspnet-starter-kit](https://gitter.im/kriasoft/aspnet-starter-kit) on Gitter
* [@koistya](https://twitter.com/koistya) on [Codementor](https://www.codementor.io/koistya)


### License

Copyright © 2014-2016 [Kriasoft](https://kriasoft.com). This source code is licensed under the MIT
license found in the [LICENSE.txt](https://github.com/kriasoft/react-starter-kit/blob/master/LICENSE.txt)
file. The documentation to the project is licensed under the [CC BY-SA 4.0](http://creativecommons.org/licenses/by-sa/4.0/)
license.


---
Made with ♥ by Konstantin Tarkus ([@koistya](https://twitter.com/koistya)) and [contributors](https://github.com/kriasoft/aspnet-starter-kit/graphs/contributors)
