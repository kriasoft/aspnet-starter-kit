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
const task = require('./lib/task');

const environments = ['Production', 'Development'];

// Create Production/Development configuration files if they don't exist
module.exports = task('appsettings', () => new Promise(resolve => {
  let count = environments.length;
  const appSettings = require('../server/appsettings.json'); // use it as a template
  delete appSettings.Logging;
  environments.forEach(env => {
    const filename = path.resolve(__dirname, `../server/appsettings.${env}.json`);
    fs.writeFile(filename, JSON.stringify(appSettings, null, '  '), { flag: 'wx' }, () => {
      if (--count === 0) resolve();
    });
  });
}));
