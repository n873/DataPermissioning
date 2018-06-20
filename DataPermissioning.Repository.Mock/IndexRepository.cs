using System;
using System.Collections.Generic;
using System.Linq;
using DataPermissioning.Domain.Model;
using DataPermissioning.Utility.Mock;

namespace DataPermissioning.Repository.Mock
{
    public class IndexRepository : IIndexRepository
    {
        private readonly IEnumerable<IIndex> Indices;
        public IndexRepository()
        {
            Indices = MockUtility.GenerateIndexMocks();
        }

        public IIndex GetIndex(string indexName)
        {
            try
            {
                return Indices.FirstOrDefault(index => index.Name == indexName);
            }
            catch (Exception) { throw; }
        }

        public IEnumerable<IIndex> GetIndices()
        {
            try
            {
                return Indices.ToList();
            }
            catch (Exception) { throw; }
        }

        public IEnumerable<IIndex> GetIndices(string ticker)
        {
            try
            {
                return Indices.Where(index => index.Ticker == ticker).ToList();
            }
            catch (Exception) { throw; }
        }
    }
}
