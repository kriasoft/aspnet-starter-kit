// Copyright (c) KriaSoft, LLC.  All rights reserved.
// Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Web.Http.Controllers;
using System.Web.Http.Metadata;
using System.Web.Http.Validation;

namespace App.Server.Http.Validation
{
    /// <summary>
    /// Same as default BodyModelValidator but removes prefixes from ModelState error keys.
    /// Before: { modelState: "userDto.email": "The Email field is not a valid e-mail address." }
    /// After:  { modelState: "email": "The Email field is not a valid e-mail address." }
    /// </summary>
    public class CustomBodyModelValidator : IBodyModelValidator
    {
        private IBodyModelValidator _validator;

        public CustomBodyModelValidator(IBodyModelValidator validator)
        {
            _validator = validator;
        }

        public bool Validate(object model, Type type, ModelMetadataProvider metadataProvider, HttpActionContext actionContext, string keyPrefix)
        {
            return _validator.Validate(model, type, metadataProvider, actionContext, string.Empty);
        }
    }
}