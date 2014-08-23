// Copyright (c) KriaSoft, LLC.  All rights reserved.
// Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;

namespace App.Server.Data
{
    public class UserRoleStore : IQueryableRoleStore<UserRole, int>
    {
        private readonly ApplicationDbContext _db;

        public UserRoleStore(ApplicationDbContext db)
        {
            if (db == null)
            {
                throw new ArgumentNullException("db");
            }

            _db = db;
        }

        // IQueryableRoleStore<UserRole, TKey>

        public IQueryable<UserRole> Roles
        {
            get { return _db.UserRoles; }
        }

        // IRoleStore<UserRole, TKey>

        public virtual Task CreateAsync(UserRole role)
        {
            if (role == null)
            {
                throw new ArgumentNullException("role");
            }

            _db.UserRoles.Add(role);
            return _db.SaveChangesAsync();
        }

        public Task DeleteAsync(UserRole role)
        {
            if (role == null)
            {
                throw new ArgumentNullException("role");
            }

            _db.UserRoles.Remove(role);
            return _db.SaveChangesAsync();
        }

        public Task<UserRole> FindByIdAsync(int roleId)
        {
            return _db.UserRoles.FindAsync(new[] { roleId });
        }

        public Task<UserRole> FindByNameAsync(string roleName)
        {
            return _db.UserRoles.FirstOrDefaultAsync(r => r.Name == roleName);
        }

        public Task UpdateAsync(UserRole role)
        {
            if (role == null)
            {
                throw new ArgumentNullException("role");
            }

            _db.Entry(role).State = EntityState.Modified;
            return _db.SaveChangesAsync();
        }

        // IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && _db != null)
            {
                _db.Dispose();
            }
        }
    }
}