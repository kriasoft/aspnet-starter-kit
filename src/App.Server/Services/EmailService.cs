// Copyright (c) KriaSoft, LLC.  All rights reserved.
// Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;

namespace App.Server.Services
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // TODO: Send email message
            throw new NotImplementedException();
        }
    }
}