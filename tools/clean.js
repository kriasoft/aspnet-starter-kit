/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

const path = require('path');
const del = require('del');
const mkdirp = require('mkdirp');
const task = require('./lib/task');

module.exports = task('clean', Promise.resolve()
  .then(() => del(
    ['build/*', 'public/assets/*', '!build/.git'],
    { dot: true, cwd: path.resolve(__dirname, '../') }
  ))
  .then(() => {
    mkdirp.sync(path.resolve(__dirname, '../build/public/assets'));
    mkdirp.sync(path.resolve(__dirname, '../public/assets'));
  })
);
