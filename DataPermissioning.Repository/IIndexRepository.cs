using DataPermissioning.Domain.Model;
using System.Collections.Generic;

namespace DataPermissioning.Repository
{
    public interface IIndexRepository
    {
        IEnumerable<IIndex> Get();
        IEnumerable<IIndex> Get(string ticker);
        IEnumerable<IIndex> GetByTickers(IEnumerable<string> tickers);
        IEnumerable<IIndex> GetExcludingTickers(IEnumerable<string> tickers);
        IIndex GetByIndex(string index);
    }
}
