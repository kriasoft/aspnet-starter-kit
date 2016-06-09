/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

import ErrorPage from './ErrorPage';

const path = '/error';

const action = () => {
  return {
    title: 'Page Not Found',
    component: ErrorPage,
  };
};

export default { path, action };
