# ASP.NET Core Starter Kit &nbsp; <a href="https://github.com/kriasoft/aspnet-starter-kit/stargazers"><img src="https://img.shields.io/github/stars/kriasoft/aspnet-starter-kit.svg?style=social&label=Star&maxAge=3600" alt="" height="20"></a> <a href="https://twitter.com/dotnetreact"><img src="https://img.shields.io/twitter/follow/dotnetreact.svg?style=social&label=Follow&maxAge=3600" alt="" height="20"></a> <a href="https://gitter.im/kriasoft/aspnet-starter-kit"><img src="https://img.shields.io/badge/chat-online-green.svg?style=social&logo=data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAAA4AAAAOCAQAAAC1QeVaAAAABGdBTUEAALGPC%2FxhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAAmJLR0QA%2F4ePzL8AAAAJcEhZcwAADE4AAAxOAX93jCMAAAAHdElNRQfgCQEGNCoLIPKlAAAA00lEQVQY023QsSuEcRjA8c%2BPy%2BJwkzt1R%2FEPqNuUkpDB33DFbjNYFFYzZSV%2FgfWKySiLxUBew7HoOpLjrZ%2Fh7erwfp%2FxMzw9T5A1ZkbZt8Sjrr6Grbvw4l3HgzPzBnpUcqgr9s2zhpDhrq9fFEVP6hkm%2FyiK9qFgQl5VC9oFLbUcTKyYzd%2BZWHalS8nRH25p2JbqwLgbUerDm3snVm1pi04LgjlTXh1rKkqVbVoy5NxOULUh1XQtWtRQN6ri05pLQu8bCIoqpu25c2Ak5F45aFLN7Q%2BBul12FZqKDAAAACV0RVh0ZGF0ZTpjcmVhdGUAMjAxNi0wOS0wMVQwNjo1Mjo0Mi0wNDowMOcKwTgAAAAldEVYdGRhdGU6bW9kaWZ5ADIwMTYtMDktMDFUMDY6NTI6NDItMDQ6MDCWV3mEAAAAGXRFWHRTb2Z0d2FyZQB3d3cuaW5rc2NhcGUub3Jnm%2B48GgAAAABJRU5ErkJggg%3D%3D&maxAge=86400" alt="" height="20"></a>

> [ASP.NET Core Starter Kit](https://github.com/kriasoft/aspnet-starter-kit) is a real-world
> boilerplate and tooling for creating [single-page web applications](https://en.wikipedia.org/wiki/Single-page_application)
> (SPA) oriented towards [progressive enhancement](https://en.wikipedia.org/wiki/Progressive_enhancement)
> design, cross-platform compatability and component-based UI architecture. It is built upon best of
> breed technologies including [.NET Core](https://dot.net/core), [Kestrel](https://github.com/aspnet/KestrelHttpServer),
> [EF Core](https://ef.readthedocs.io/en/latest/), [Babel](http://babeljs.io/), [Webpack](https://webpack.github.io/),
> [React](https://facebook.github.io/react), [Redux](http://redux.js.org/), [CSS Modules](https://github.com/css-modules/css-modules),
> [React Hot Loader](http://gaearon.github.io/react-hot-loader/) and more. This boilerplate comes in
> both [C#](https://github.com/kriasoft/aspnet-starter-kit) and [F#](https://github.com/kriasoft/fsharp-starter-kit) flavors.

**See** [demo](https://aspnet-core.azurewebsites.net), [docs](docs) &nbsp;|&nbsp; **Follow us** on
[Gitter](https://gitter.im/kriasoft/aspnet-starter-kit) or [Twitter](https://twitter.com/dotnetreact)
&nbsp;|&nbsp; **Learn** [React.js, ES6 and ASP.NET Core](#learn-reactjs-es6-and-aspnet-core)
&nbsp;|&nbsp; **Visit our sponsors**:

<p align="center" align="top">
  <a href="https://rollbar.com/?utm_source=reactstartkit(github)&amp;utm_medium=link&amp;utm_campaign=reactstartkit(github)"><img src="https://koistya.github.io/files/rollbar-362x72.png" height="36" align="top" /></a>
  <a href="https://x-team.com/hire-react-developers/?utm_source=reactstarterkit&utm_medium=github-link&utm_campaign=reactstarterkit-june"><img src="https://koistya.github.io/files/xteam-255x72.png" height="36" align="top" /></a>
  <sup><a href="https://x-team.com/join/?utm_source=reactstarterkit&utm_medium=github-link&utm_campaign=reactstarterkit-june">Hiring</a></sup>
</p>


### Features

&nbsp; &nbsp; ✓ Component-based front-end development via [Webpack](https://webpack.github.io/), [CSS Modules](https://github.com/css-modules/css-modules) and [React](https://facebook.github.io/react) (see [`webpack.config.js`](webpack.config.js))<br>
&nbsp; &nbsp; ✓ Modern JavaScript syntax ([ES2015](http://babeljs.io/docs/learn-es2015/)+) via [Babel](http://babeljs.io/); modern CSS syntax (CSS3+) via [PostCSS](https://github.com/postcss/postcss)<br>
&nbsp; &nbsp; ✓ Application state management via [Redux](http://redux.js.org/) (see [`client/store.js`](client/store.js))<br>
&nbsp; &nbsp; ✓ Universal cross-stack routing and navigation via [`path-to-regexp`](https://github.com/pillarjs/path-to-regexp) and [`history`](https://github.com/ReactJSTraining/history) (see [`client/routes.json`](client/routes.json))<br>
&nbsp; &nbsp; ✓ [Code-splitting](https://github.com/webpack/docs/wiki/code-splitting) and async chunk loading with [Webpack](https://webpack.github.io/) and [ES6 System.import()](http://www.2ality.com/2014/09/es6-modules-final.html)<br>
&nbsp; &nbsp; ✓ Hot Module Replacement ([HMR](https://webpack.github.io/docs/hot-module-replacement.html)) /w [React Hot Loader](http://gaearon.github.io/react-hot-loader/)<br>
&nbsp; &nbsp; ✓ Lightweight build automation with plain JavaScript (see [`run.js`](run.js))<br>
&nbsp; &nbsp; ✓ Cross-device testing with [Browsersync](https://browsersync.io/)<br>
&nbsp; &nbsp; ✓ Git-based deployment to [Azure App Service](https://azure.microsoft.com/services/app-service/) (see [`run.js/publish`](run.js))<br>
&nbsp; &nbsp; ✓ **24/7** community support on [Gitter](https://gitter.im/kriasoft/aspnet-starter-kit) or [StackOverflow](http://stackoverflow.com/questions/tagged/aspnet-starter-kit); consulting and customization requests on [Codementor](https://www.codementor.io/koistya)<br>


### Directory Layout

```shell
.
├── /.vscode/                   # Visual Studio Code settings
├── /build/                     # The folder for compiled output
├── /client/                    # Client-side app (frontend)
│   ├── /components/            # Common or shared UI components
│   ├── /utils/                 # Helper functions and utility classes
│   ├── /views/                 # UI components for web pages (screens)
│   ├── history.js              # HTML5 History API wrapper used for navigation
│   ├── main.js                 # Entry point that bootstraps the app
│   ├── router.js               # Lightweight application router
│   ├── routes.json             # The list of application routes
│   └── store.js                # Application state manager (Redux)
├── /client.test/               # Unit and integration tests for the frontend app
├── /docs/                      # Documentation to the project
├── /public/                    # Static files such as favicon.ico etc.
│   ├── robots.txt              # Instructions for search engine crawlers
│   └── ...                     # etc.
├── /server/                    # Web server and data API (backend)
│   ├── /Controllers/           # ASP.NET Web API and MVC controllers
│   ├── /Models/                # Entity Framework models (entities)
│   ├── /Views/                 # Server-side rendered views
│   ├── appsettings.json        # Server-side application settings
│   ├── Startup.cs              # Server-side application entry point
│   └── web.config              # Web server settings for IIS
├── /server.test/               # Unit and integration tests for the backend app
│── jsconfig.json               # Visual Studio Code settings for JavaScript
│── package.json                # The list of project dependencies and NPM scripts
│── run.js                      # Build automation script (similar to gulpfile.js)
└── webpack.config.js           # Bundling and optimization settings for Webpack
```


### Prerequisites

* OS X, Windows or Linux
* [Node.js](https://nodejs.org) v6 or newer
* [.NET Core](https://www.microsoft.com/net/core) and [.NET Core SDK](https://www.microsoft.com/net/core)
* [Visual Studio Code](https://code.visualstudio.com/) with [C# extension](https://github.com/OmniSharp/omnisharp-vscode) (or Visual Studio 2015 or newer)


### Getting Started

**Step 1**. Clone the latest version of **ASP.NET Core Starter Kit** on your local machine by running:

```shell
$ git clone -o aspnet-starter-kit -b master --single-branch \
      https://github.com/kriasoft/aspnet-starter-kit.git MyApp
$ cd MyApp
```

Alternatively, scaffold your project with [Yeoman](http://yeoman.io/):

```shell
$ npm install -g yo
$ npm install -g generator-aspnetcore
$ yo aspnetcore
```

**Step 2**. Install project dependencies listed in [`project.json`](server/project.json) and
[`package.json`](package.json) files: 

```shell
$ npm install                   # Install both Node.js and .NET Core dependencies
```

**Step 3**. Finally, launch your web app:

```shell
$ node run                      # Compile and lanch the app, same as running: npm start
```

The app should become available at [http://localhost:5000/](http://localhost:5000/).
See [`run.js`](run.js) for other available commands such as `node run build`, `node run publish` etc.
You can also run your app in a release (production) mode by running `node run --release`, or without
Hot Module Replacement (HMR) by running `node run --no-hmr`.


### How to Deploy

Before you can deploy your app to [Azure App Service](https://azure.microsoft.com/services/app-service/),
you need to open Web App settings in [Azure Portal](https://portal.azure.com/), go to "Deployment
Source", select "Local Git Repository" and hit [OK]. Then copy and paste "Git clone URL" of your
Web App into [`run.js/publish`](run.js) file. Finally, whenever you need to compile your
app into a distributable format and upload that to Windows Azure App Service, simply run:

```shell
$ node run publish              # Same as running: npm run publish
```

### How to Update

We work hard on keeping the project up-to-date and adding new features. Down the road, after
starting a new web application project based on this boilerplate, you can always fetch and merge
the latest changes from this (upstream) repo back into your project by running:

```shell
$ git checkout master
$ git fetch aspnet-starter-kit
$ git merge aspnet-starter-kit/master 
```

Alternatively, pull the latest version of this repository into a separate folder and compare it with
your project by using a diff tool such as [Beyond Compare](http://www.scootersoftware.com/).


### How to Contribute

Anyone and everyone is welcome to [contribute](CONTRIBUTING.md) to this project. The best way to
start is by checking our [open issues](https://github.com/kriasoft/aspnet-starter-kit/issues),
[submit a new issues](https://github.com/kriasoft/aspnet-starter-kit/issues/new?labels=bug) or
[feature request](https://github.com/kriasoft/aspnet-starter-kit/issues/new?labels=enhancement),
participate in discussions, upvote or downvote the issues you like or dislike, send [pull
requests](CONTRIBUTING.md#pull-requests).


### Learn React.js, ES6 and ASP.NET Core

:mortar_board: &nbsp; **[React.js Training Program](http://www.reactjsprogram.com/?asdf=36750_q0pu0tfa)** by Tyler McGinnis<br>
:mortar_board: &nbsp; **[React for Beginners](https://reactforbeginners.com/friend/konstantin)** and **[ES6 Training Course](https://es6.io/friend/konstantin)** by Wes Bos<br>
:green_book: &nbsp; **[React: Up & Running: Building Web Applications](http://amzn.to/2bBkZs1)** by Stoyan Stefanov (Aug, 2016)<br>
:green_book: &nbsp; **[Getting Started with React](http://amzn.to/2beVRI9)** by Doel Sengupta and Manu Singhal (Apr, 2016)<br>
:green_book: &nbsp; **[You Don't Know JS: ES6 & Beyond](http://amzn.to/2bFzlqe)** by Kyle Simpson (Dec, 2015)<br>
:green_book: &nbsp; **[C# 6 and .NET Core 1.0: Modern Cross-Platform Development](http://amzn.to/2beV5uS)** by Mark J. Price (Mar, 2016)<br>
:green_book: &nbsp; **[Professional C# 6 and .NET Core 1.0](http://amzn.to/2bhILsn)** by Christian Nagel (Apr, 2016)<br>


### Related Projects

* [React App SDK](https://github.com/kriasoft/react-app) — build React applications with a single dev dependency and no build configuration
* [React Starter Kit](https://github.com/kriasoft/react-starter-kit) — Isomorphic web app boilerplate (Node.js, Express, GraphQL, React)
* [Babel Starter Kit](https://github.com/kriasoft/babel-starter-kit) — JavaScript library boilerplate (ES2015+, Babel, Rollup)
* [ASP.NET Core Starter Kit `|>` F#](https://github.com/kriasoft/fsharp-starter-kit) — Web app boilerplate (F#, .NET Core, Kestrel, GraphQL, React)
* [Universal Router](https://github.com/kriasoft/universal-router) — Isomorphic router for web and single-page applications (SPA)
* [Membership Database](https://github.com/membership/membership.db) — SQL database boilerplate for web app users, roles and auth tokens


### Get in Touch

* [#aspnet-starter-kit](https://gitter.im/kriasoft/aspnet-starter-kit) on Gitter
* [@koistya](https://twitter.com/koistya) on [Codementor](https://www.codementor.io/koistya)
  or [Skype](http://hatscripts.com/addskype?koistya)


### License

Copyright © 2014-present [Kriasoft](https://kriasoft.com). This source code is licensed under the MIT
license found in the [LICENSE.txt](https://github.com/kriasoft/react-starter-kit/blob/master/LICENSE.txt)
file. The documentation to the project is licensed under the [CC BY-SA 4.0](http://creativecommons.org/licenses/by-sa/4.0/)
license.


---
Made with ♥ by Konstantin Tarkus ([@koistya](https://twitter.com/koistya)) and [contributors](https://github.com/kriasoft/aspnet-starter-kit/graphs/contributors)
