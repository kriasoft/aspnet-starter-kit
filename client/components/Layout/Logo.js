/**
 * ASP.NET Core Starter Kit (https://dotnetreact.com)
 *
 * Copyright © 2014-present Kriasoft, LLC. All rights reserved.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE.txt file in the root directory of this source tree.
 */

import React, { PropTypes } from 'react';

function Logo({ width, height, ...other }) {
  return (
    <svg
      viewBox="0 0 500 516.813"
      width={width || ((height * 500) / 516.813)}
      height={height || ((width * 500) / 516.813)} {...other}
    >
      <path
        d="M483.292 64.07L372.104 19.5 178.024 208.5 61.15 119.534l-44.44 22.35-.045 233.313
        44.233 22.19 116.778-88.894 194.557 188.83 111.102-44.398z" fill="#038fd6" stroke="#fff"
        strokeWidth="33.33"
      />
      <path
        d="M361.037 175.128L249.98 258.15l111.1 83.673zM72.192 208.596l.067 99.858
        55.482-50.267z" fill="#fff"
      />
    </svg>
  );
}

Logo.propTypes = {
  width: PropTypes.number,
  height: PropTypes.number,
};

export default Logo;
