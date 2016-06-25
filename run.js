/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

const fs = require('fs');
const del = require('del');
const path = require('path');
const cp = require('child_process');
const webpack = require('webpack');
const webpackConfig = require('./webpack.config');

const tasks = new Map();

function run(name) {
  const start = new Date();
  console.log(`Starting '${name}'...`);
  return Promise.resolve().then(() => tasks.get(name)()).then(() => {
    const end = new Date();
    const time = end.getTime() - start.getTime();
    console.log(`Finished '${name}' after ${time}ms`);
  }, err => console.error(err.stack));
}

// Clean up the output directory
tasks.set('clean', () => del(['main.*.js', 'main.*.js.map'], { dot: true }));

// Compile application bundle from source files
tasks.set('build', () => Promise.resolve()
  .then(() => run('clean'))
  .then(() => new Promise((resolve, reject) => {
    const compiler = webpack(webpackConfig);
    compiler.run((err, stats) => {
      if (err) {
        reject(err);
      } else {
        console.log(stats.toString(webpackConfig.stats));
        resolve();
      }
    });
  }))
  .then(() => new Promise(resolve => {
    const assets = require('./assets.json');
    let html = fs.readFileSync('./index.html', 'utf8');
    html = html.replace(/"main\..+"/, `"${assets.main.js.substr(1)}"`);
    fs.writeFileSync('./index.html', html, 'utf8');
    resolve();
  }))
);

// Compile application bundle and start watching for changes in source files
tasks.set('start', () => Promise.resolve()
// Clean up the output directory
  .then(() => require('./clean'))

  // Fix path to the application bundle in index.html
  .then(() => new Promise(resolve => {
    let html = fs.readFileSync('./index.html', 'utf8');
    html = html.replace(/"main\..+"/, `"main.bundle.js"`);
    fs.writeFileSync('./index.html', html, 'utf8');
    resolve();
  }))

  // Launch Webpack compiler in watch mode
  .then(() => new Promise((resolve, reject) => {
    const compiler = webpack(webpackConfig);
    compiler.watch({}, (err, stats) => {
      if (err) {
        reject(err);
      } else {
        console.log(stats.toString(webpackConfig.stats));
        resolve();
      }
    });
  }))

  // Launch ASP.NET Core Server in a child process
  .then(() => new Promise(resolve => {
    const options = {
      cwd: path.resolve(__dirname, '../'),
      stdio: ['ignore', 'pipe', 'inherit'],
    };
    cp.spawn('node', ['./node_modules/http-server/bin/http-server', './'], options).stdout.on('data', data => {
      process.stdout.write(data);
      if (data.indexOf('Application started.') !== -1) {
        resolve();
      }
    });
  }))
);

// Execute the specified task. E.g.: node run build
run(process.argv[2] || 'start');
