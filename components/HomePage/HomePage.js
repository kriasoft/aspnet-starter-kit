/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

import React from 'react';
import Layout from '../Layout';

class HomePage extends React.Component {

  componentDidMount() {
    document.title = 'ASP.NET Core Starter Kit';
  }

  render() {
    return (
      <Layout>
        <h1>Home Page</h1>
        <p>Coming soon.</p>
      </Layout>
    )
  }

}

export default HomePage;
