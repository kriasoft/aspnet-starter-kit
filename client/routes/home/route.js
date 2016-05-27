/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

import Home from './Home';

const path = '/';

const action = () => {
  return {
    title: 'Home Page',
    component: Home
  };
};

export default { path, action };
