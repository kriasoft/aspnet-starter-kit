/**
 * Yeoman Generator Starter Kit
 *
 * Copyright © 2016-present Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

import path from 'path';
import assert from 'yeoman-assert';
import helpers from 'yeoman-test';

describe('generator:app', () => {

  before(() => helpers.run(path.join(__dirname, '../generators/app'))
    .withPrompts({ someAnswer: true })
    .toPromise()
  );

  it('creates files', () => {
    assert.file([
      'client/components/Layout/Layout.js',
      'client/components/Layout/package.json',
      'client/components/Link/Link.js',
      'client/components/Link/package.json',
      'client/utils/markdown-loader.js',
      'client/utils/routes-loader.js',
      'client/history.js',
      'client/main.js',
      'client/router.js',
      'client/routes.json',
      'client/store.js',
      'client/views/home/Home.js',
      'client/views/home/package.json',
      'client.test/.eslintrc',
      'client.test/test.js',
      'docs/recipes/how-to-integrate-material-design-lite.md',
      'docs/recipes/how-to-use-sass.md',
      'docs/README.md',
      'docs/routing-and-navigation.md',
      'public/apple-touch-icon.png',
      'public/crossdomain.xml',
      'public/favicon.ico',
      'public/humans.txt',
      'public/robots.txt',
      'public/tile.png',
      'public/tile-wide.png',
      '.editorconfig',
      '.gitattributes',
      '.gitignore',
      'global.json',
      'jsconfig.json',
      'LICENSE.txt',
      'package.json',
      'README.md',
      'run.js',
      'webpack.config.js',
    ]);

    assert.noFile([
      'CONTRIBUTING.md',
    ]);
  });

});
