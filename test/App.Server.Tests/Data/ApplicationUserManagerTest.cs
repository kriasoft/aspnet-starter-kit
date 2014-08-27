// Copyright (c) KriaSoft, LLC.  All rights reserved.
// Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Threading.Tasks;

using App.Server.Data;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Server.Tests.Data
{
    [TestClass]
    public class ApplicationUserManagerTest
    {
        // For a list of users refer to `./src/App.Database/Reference Data/User.sql`

        [TestMethod, TestCategory("Integration")]
        public async Task UserManager_FindAsync()
        {
            using (var db = new ApplicationDbContext())
            using (var store = new UserStore(db))
            using (var manager = new ApplicationUserManager(store))
            {
                var user = await manager.FindAsync("user", "Passw0rd");
                Assert.IsNotNull(user);
                Assert.AreEqual("user@example.com", user.Email);

                user = await manager.FindAsync("user", "wrong-pass");
                Assert.IsNull(user);
            }
        }
    }
}
