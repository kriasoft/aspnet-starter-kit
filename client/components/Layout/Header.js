/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

import React from 'react';
import Navigation from './Navigation';

class Header extends React.Component {

  componentDidMount() {
    window.componentHandler.upgradeElement(this.refs.root);
  }

  componentWillUnmount() {
    window.componentHandler.downgradeElements(this.refs.root);
  }

  render() {
    return (
      <header className="mdl-layout__header" ref="root">
        <div className="mdl-layout__header-row">
          <span className="mdl-layout-title">React Static Boilerplate</span>
          <div className="mdl-layout-spacer"></div>
          <Navigation />
        </div>
      </header>
    );
  }

}

export default Header;
