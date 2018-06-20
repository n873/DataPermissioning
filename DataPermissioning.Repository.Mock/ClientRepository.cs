using System;
using System.Collections.Generic;
using System.Linq;
using DataPermissioning.Domain.Model;
using DataPermissioning.Utility.Mock;

namespace DataPermissioning.Repository.Mock
{
    public class ClientRepository : IClientRepository
    {
        private readonly IEnumerable<IClient> Clients;
        public ClientRepository()
        {
            Clients = MockUtility.GenerateClientMocks();
        }

        public IClient Get(string name)
        {
            try
            {
                return Clients.FirstOrDefault(client => client.Name == name);
            }
            catch (Exception) { throw; }
        }

        public IEnumerable<IClient> Get()
        {
            try
            {
                return Clients.ToList();
            }
            catch (Exception) { throw; }
        }
    }
}
