/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

const path = require('path');
const cp = require('child_process');
const webpack = require('webpack');
const webpackConfig = require('./webpack.config');
const task = require('./lib/task');

module.exports = task('start', () => Promise.resolve()

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
      cwd: path.resolve(__dirname, '../server/'),
      stdio: ['ignore', 'pipe', 'inherit'],
      env: {
        ASPNETCORE_ENVIRONMENT: 'Development',
      },
    };
    cp.spawn('dotnet', ['run'], options).stdout.on('data', data => {
      process.stdout.write(data);
      if (data.indexOf('Application started.') !== -1) {
        resolve();
      }
    });
  }))

);
