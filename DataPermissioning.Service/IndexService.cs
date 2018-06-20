using DataPermissioning.Common.Extension;
using DataPermissioning.Domain.Enum;
using DataPermissioning.Domain.Model;
using DataPermissioning.Repository;
using DataPermissioning.Repository.Mock;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataPermissioning.Service
{
    public class IndexService
    {
        private readonly IIndexRepository IndexRepository;
        private readonly IIndexIncludePermissionRepository IndexIncludePermissionRepository;
        private readonly IIndexExcludePermissionRepository IndexExcludePermissionRepository;
        private readonly IEnumerable<Index> Indices;

        public IndexService()
        {
            IndexRepository = new IndexRepository();
            IndexIncludePermissionRepository = new IndexIncludePermissionRepository();
            IndexExcludePermissionRepository = new IndexExcludePermissionRepository();
        }

        public IndexService(IIndexRepository indexRepository, 
            IIndexIncludePermissionRepository indexIncludePermissionRepository,
            IIndexExcludePermissionRepository indexExcludePermissionRepository)
        {
            IndexRepository = indexRepository;
            IndexIncludePermissionRepository = indexIncludePermissionRepository;
            IndexExcludePermissionRepository = indexExcludePermissionRepository;
        }

        public IEnumerable<IIndex> GetIndices(IClient client) {
            try
            {
                IEnumerable<IIndex> indices = new List<Index>();
                var indexTickerFilter = IndexTickerFilter.All;

                var includeList = IndexIncludePermissionRepository.Get(client.Name);
                var excludeList = IndexExcludePermissionRepository.Get(client.Name);

                if (indexTickerFilter == IndexTickerFilter.Include)
                    indices = IndexRepository.GetByTickers(includeList.ToTickerStringList()).ToList();

                if (indexTickerFilter == IndexTickerFilter.Exlude)
                {
                    indices = IndexRepository.Get().ToList();
                    var indexesToExclude = IndexRepository.GetExcludingTickers(excludeList.ToTickerStringList());
                    //foreach (var indexToExclude in indexesToExclude)
                        

                }
                return null;
            }
            catch (Exception) { throw; }
        }
    }

    public class Client
    {
    }
}
