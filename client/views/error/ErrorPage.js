/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

import React from 'react';
import Layout from '../../components/Layout';

class ErrorPage extends React.Component {

  componentDidMount() {
    document.title = 'Page Not Found';
  }

  render() {
    return (
      <Layout>
        <h1 className="mdl-typography--title">Page Not Found</h1>
        <p className="mdl-typography--body-1">
          Sorry, this page does not exist.
        </p>
      </Layout>
    );
  }

}

export default ErrorPage;
