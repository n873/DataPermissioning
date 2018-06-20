using DataPermissioning.Domain.Model;
using System;
using System.Collections.Generic;

namespace DataPermissioning.Repository.Db
{
    public class IndexIncludePermissionRepositoryDbContext : IIndexIncludePermissionRepositoryDbContext //Inherits from DBContext
    {
        //Place DbSet<IndexIncludePermission> property here

        public IndexIncludePermissionRepositoryDbContext() //Accept DbContextOptions here
        {

        }

        public IEnumerable<IPermission> Get()
        {
            try
            {
                return new List<IndexIncludePermission>();
            }
            catch (Exception) { throw; }
        }
    }
}
