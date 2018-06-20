using DataPermissioning.Domain.Model;
using DataPermissioning.Repository.Db;
using DataPermissioning.Utility.Mock;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataPermissioning.Repository.Mock
{
    //This approach is not ideal - InMemoryDatabse would be more appropriate when using EF Core
    public class IndexIncludePermissionRepository : IIndexIncludePermissionRepository
    {
        private readonly IEnumerable<IIndexIncludePermission> IndexIncludePermissions;

        public IndexIncludePermissionRepository()
        {
            IndexIncludePermissions = MockUtility.GenerateIndexIncludePermissionMocks();
        }

        public IndexIncludePermissionRepository(IIndexIncludePermissionRepositoryDbContext dbContext)
        {
            //IndexIncludePermissions = dbContext.Get();
        }

        public IEnumerable<IIndexIncludePermission> Get() {
            try
            {
                return IndexIncludePermissions.ToList();
            }
            catch (Exception) { throw; }
        }

        public IEnumerable<IIndexIncludePermission> Get(string clientName)
        {
            try
            {
                return IndexIncludePermissions.Where(permission => permission.ClientName == clientName).ToList();
            }
            catch (Exception) { throw; }
        }
    }

    //This approach is not ideal - InMemoryDatabse would be more appropriate when using EF Core
    public class IndexExcludePermissionRepository : IIndexExcludePermissionRepository
    {
        private readonly IEnumerable<IIndexExcludePermission> IndexExcludePermissions;

        public IndexExcludePermissionRepository()
        {
            IndexExcludePermissions = MockUtility.GenerateIndexExcludePermissionMocks();
        }

        public IndexExcludePermissionRepository(IIndexIncludePermissionRepositoryDbContext dbContext)
        {
            IndexExcludePermissions = dbContext.Get();
        }

        public IEnumerable<IIndexExcludePermission> Get()
        {
            try
            {
                return IndexExcludePermissions.ToList();
            }
            catch (Exception) { throw; }
        }

        public IEnumerable<IIndexExcludePermission> Get(string clientName)
        {
            try
            {
                return IndexExcludePermissions.Where(permission => permission.ClientName == clientName).ToList();
            }
            catch (Exception) { throw; }
        }
    }
}
