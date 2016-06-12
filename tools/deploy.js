/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

const path = require('path');
const cp = require('./lib/cp');
const task = require('./lib/task');

const remote = {
  name: 'azure',
  url: 'https://<user>@<app>.scm.azurewebsites.net:443/<app>.git',
};

const opts = { cwd: path.resolve(__dirname, '../build') };

module.exports = task('deploy', Promise.resolve()
  .then(() => require('./clean'))
  .then(() => cp.spawn('git', ['init', '--quiet'], opts))
  .then(() => cp.spawn('git', ['config', '--get', `remote.${remote.name}.url`], opts)
     .then(() => cp.spawn('git', ['remote', 'set-url', remote.name, remote.url], opts))
     .catch(() => cp.spawn('git', ['remote', 'add', remote.name, remote.url], opts))
   )
  .then(() => cp.spawn('git', ['ls-remote', '--exit-code', remote.url, 'master'], opts)
    .then(() => Promise.resolve()
      .then(() => cp.spawn('git', ['fetch', remote.name], opts))
      .then(() => cp.spawn('git', ['reset', `${remote.name}/master`, '--hard'], opts))
      .then(() => cp.spawn('git', ['clean', '--force'], opts))
    )
    .catch(() => Promise.resolve())
  )
  .then(() => require('./build'))
  .then(() => cp.spawn('git', ['add', '.', '--all'], opts))
  .then(() => cp.spawn('git', ['commit', '--message', new Date().toUTCString()], opts)
    .catch(() => Promise.resolve()))
  .then(() => cp.spawn('git', ['push', remote.name, 'master', '--force', '--set-upstream'], opts))
);
