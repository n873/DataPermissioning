using System.Collections.Generic;
using DataPermissioning.Domain.Model;

namespace DataPermissioning.Repository.Db
{
    public interface IIndexIncludePermissionRepositoryDbContext
    {
        IEnumerable<IPermission> Get();
    }
}