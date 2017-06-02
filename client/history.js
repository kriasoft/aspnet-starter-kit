/**
 * ASP.NET Core Starter Kit (https://dotnetreact.com)
 *
 * Copyright © 2014-present Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

// tried to upgrade to version 4.6.1 from 3.0.0 of history but breaking changes, useQueries no longer exists
// https://github.com/ReactTraining/history/issues/364
// TODO: revisit this

import createHistory from 'history/createBrowserHistory';
//import useQueries from 'history/lib/useQueries';

//export default useQueries(createBrowserHistory)();
const history = createHistory();

export default history;
