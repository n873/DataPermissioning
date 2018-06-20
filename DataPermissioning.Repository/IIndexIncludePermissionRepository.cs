using DataPermissioning.Domain.Model;
using System.Collections.Generic;

namespace DataPermissioning.Repository
{
    public interface IIndexIncludePermissionRepository
    {
        IEnumerable<IIndexIncludePermission> Get();
        IEnumerable<IIndexIncludePermission> Get(string ClientName);
    }
}
