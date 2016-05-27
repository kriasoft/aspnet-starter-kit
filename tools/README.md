## Build Automation Scripts and Utilities

The build automation scripts are written in ES2015 flavor of JavaScript and require
[Node.js](https://nodejs.org/) v6 (or newer) to run. The reason for that is these scripts must
work well on any platform (OS X, Windows, Linux) and every web developer should be already
familiar with JavaScript; ES2015 syntax ensures that the code remains clean and easy to
understand.
 

#### `tools/clean.js`

Removes all the files and child directories from the the output (`build`) folder, except for the
`.git` directory that is used for Git-based deployments (see `tools/deploy.js`).

```sh
$ node tools/clean
```


#### `tools/build.js`

Compiles both client-side and server-side code into a distributable format ready to be deployed to
a web server (it runs `clean`, `bundle` and `copy` scripts behind the scene).

```sh
$ node tools/build --production
```

| Option               | Description                                                                     | Default
| -------------------- | ------------------------------------------------------------------------------- | ---------
| `--production`, `-p` | Minimize and optimize the output bundle for running in a production environment | `false`


#### `tools/deploy.js`

Deployes the compiled version of the app from the `build` folder to
[Azure App Service](https://azure.microsoft.com/en-us/services/app-service/) via Git.

```sh
$ node tools/deploy --production
```

| Option               | Description                                                                     | Default
| -------------------- | ------------------------------------------------------------------------------- | ---------
| `--production`, `-p` | Minimize and optimize the output bundle for running in a production environment | `false`


#### `tools/bundle.js`

Creates client-side application bundle from the source files in the `client` folder with
[Webpack](https://webpack.github.io/).

```sh
$ node tools/bundle --production
```

| Option               | Description                                                                     | Default
| -------------------- | ------------------------------------------------------------------------------- | ---------
| `--production`, `-p` | Minimize and optimize the output bundle for running in a production environment | `false`


#### `tools/copy.js`

Copies files from the `public` folder to `build/public`.

```sh
$ node tools/copy
```
