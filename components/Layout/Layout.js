/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

import React from 'react';
import Header from './Header';
import Footer from './Footer';
import Button from '../Button';
import s from './Layout.css';

const githubUrl = 'https://github.com/kriasoft/aspnet-starter-kit';

class Layout extends React.Component {

  componentDidMount() {
    window.componentHandler.upgradeElement(this.refs.root);
  }

  componentWillUnmount() {
    window.componentHandler.downgradeElements(this.refs.root);
  }

  render() {
    return (
      <div className="mdl-layout mdl-js-layout" ref="root">
        <div className="mdl-layout__inner-container">
          <div className={s.ribbon}>
            <Header />
            <div className={s.container}>
              <h1 className={`mdl-typography--title ${s.tagline}`}>
                <strong className={s.taglineStrong}>ASP.NET Core</strong> Starter Kit
              </h1>
              <p className={`mdl-typography--title ${s.summary}`}>
                Boilerplate and tooling for web application development
                with <strong>.NET Core</strong> and <strong>React</strong>
              </p>
              <div>
                <Button className={s.leftButton} raised={true} rippleEffect={true}>Get Started</Button>
                <Button className={s.rightButton} raised={true} rippleEffect={true} href={githubUrl}>View on GitHub</Button>
              </div>
            </div>
          </div>
          <main {...this.props} className={s.content} />
          <Footer />
        </div>
      </div>
    );
  }
}

export default Layout;
