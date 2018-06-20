using DataPermissioning.Domain.Model;
using System;
using System.Collections.Generic;

namespace DataPermissioning.Repository.Db
{
    public class IndexExcludePermissionRepositoryDbContext : IIndexExcludePermissionRepositoryDbContext
    {
        //Place DbSet<IndexExcludePermission> property here

        public IndexExcludePermissionRepositoryDbContext() //Accept DbContextOptions here
        {

        }

        public IEnumerable<IPermission> Get()
        {
            try
            {
                return new List<IndexExcludePermission>();
            }
            catch (Exception) { throw; }
        }
    }
}
