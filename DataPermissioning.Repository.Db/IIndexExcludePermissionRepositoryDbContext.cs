using System.Collections.Generic;
using DataPermissioning.Domain.Model;

namespace DataPermissioning.Repository.Db
{
    public interface IIndexExcludePermissionRepositoryDbContext
    {
        IEnumerable<IPermission> Get();
    }
}