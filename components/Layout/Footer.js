/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

import React from 'react';
import s from './Footer.css';

class Footer extends React.Component {

  componentDidMount() {
    window.componentHandler.upgradeElement(this.refs.root);
  }

  componentWillUnmount() {
    window.componentHandler.downgradeElements(this.refs.root);
  }

  render() {
    return (
      <footer className="mdl-mini-footer" ref="root">
        <div className="mdl-mini-footer__left-section">
          <div className="mdl-logo">© 2016 Kriasoft</div>
        </div>
        <div className="mdl-mini-footer__right-section">
          <ul className="mdl-mini-footer__link-list">
            <li>This project is maintained by <a href="https://twitter.com/koistya"><strong>@koistya</strong></a></li>
          </ul>
        </div>
      </footer>
    );
  }

}

export default Footer;
