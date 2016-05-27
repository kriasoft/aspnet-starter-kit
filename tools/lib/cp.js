/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

const path = require('path');
const extend = require('extend');
const cp = require('child_process');

const defaults = {
  cwd: path.resolve(__dirname, '../../'),
  stdio: ['ignore', 'inherit', 'inherit'],
};

function spawn(command, args, options = {}) {
  return new Promise((resolve, reject) => {
    cp.spawn(command, args, extend({}, defaults, options)).on('close', code => {
      if (code === 0) {
        resolve();
      } else {
        reject(new Error(`${command} ${args.join(' ')} => ${code} (error)`));
      }
    });
  });
}

module.exports = { spawn };
