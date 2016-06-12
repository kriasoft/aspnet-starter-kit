/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

const fs = require('fs');
const path = require('path');
const cp = require('./lib/cp');
const task = require('./lib/task');

const isDebug = !(process.argv.includes('--production') || process.argv.includes('-p'));
const config = isDebug ? 'Debug' : 'Release';

module.exports = task('build', () => Promise.resolve()
  // Clean up the output directory
  .then(() => require('./clean'))

  // Create Production/Development configuration files if they don't exist
  .then(() => new Promise(resolve => {
    let count = 2;
    const appSettings = require('../server/appsettings.json'); // use it as a template
    delete appSettings.Logging;
    ['Production', 'Development'].forEach(env => {
      const filename = path.resolve(__dirname, `../server/appsettings.${env}.json`);
      fs.writeFile(filename, JSON.stringify(appSettings, null, '  '), { flag: 'wx' }, () => {
        if (--count === 0) resolve();
      });
    });
  }))

  // Compile the ASP.NET Core app
  .then(() => cp.spawn(
    'dotnet', ['publish', 'server', '-o', 'build', '-c', config, '-r', 'coreclr']
  ))

  // Compile the JavaScript app
  .then(() => require('./bundle'))

  // Copy static files to the output folder
  .then(() => require('./copy'))
);
