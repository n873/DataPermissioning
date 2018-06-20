using DataPermissioning.Domain.Model;
using System.Collections.Generic;

namespace DataPermissioning.Repository
{
    public interface IClientRepository
    {
        IClient Get(string name);
        IEnumerable<IClient> Get();
    }
}
