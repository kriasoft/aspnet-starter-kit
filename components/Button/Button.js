/**
 * ASP.NET Core Starter Kit
 *
 * Copyright © 2014-2016 Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

import React, { PropTypes } from 'react';
import cx from 'classnames';

class Button extends React.Component {

  static propTypes = {
    className: PropTypes.string,
    href: PropTypes.string,
    raised: PropTypes.bool.isRequired,
    rippleEffect: PropTypes.bool.isRequired,
  };

  static defaultProps = {
    raised: false,
    rippleEffect: false,
  };

  componentDidMount() {
    window.componentHandler.upgradeElement(this.refs.root);
  }

  componentWillUnmount() {
    window.componentHandler.downgradeElements(this.refs.root);
  }

  render() {
    const { className, ...props } = this.props;
    console.log(className);
    const cn = cx('mdl-button mdl-js-button', className, {
      'mdl-button--raised': this.props.raised,
      'mdl-js-ripple-effect': this.props.rippleEffect,
    });

    return React.createElement(this.props.href ? 'a' : 'button', {
      className: cn,
      ref: 'root',
      ...props,
    });
  }

}

export default Button;
