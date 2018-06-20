using DataPermissioning.Domain.Model;
using System.Collections.Generic;

namespace DataPermissioning.Repository
{
    public interface IIndexExcludePermissionRepository
    {
        IEnumerable<IIndexExcludePermission> Get();
        IEnumerable<IIndexExcludePermission> Get(string ClientName);
    }
}
