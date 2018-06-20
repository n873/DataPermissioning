using DataPermissioning.Domain.Enum;
using DataPermissioning.Domain.Model;
using System.Collections.Generic;
using IndexName = DataPermissioning.Domain.Constant.Index;
using ClientName = DataPermissioning.Domain.Constant.Client;

namespace DataPermissioning.Utility.Mock
{
    public static class MockUtility
    {
        public static IEnumerable<IIndex> GenerateIndexMocks()
        {
            return new List<Index> {
                new Index {
                    Id = 1,
                    Name =  IndexName.SPDRSP500ETF,
                    Ticker = IndexTicker.SPY.ToString(),
                    Price = 272.12m
                },
                new Index {
                    Id = 1,
                    Name =  IndexName.SPDRDowJonesIndustrialAverageETF,
                    Ticker = IndexTicker.DIA.ToString(),
                    Price = 250.80m
                },
                new Index {
                    Id = 1,
                    Name =  IndexName.SP500HighDividendIndex,
                    Ticker = IndexTicker.SPYD.ToString(),
                    Price = 36.58m
                },
                new Index {
                    Id = 1,
                    Name =  IndexName.VanguardTotalStockMarketETF,
                    Ticker = IndexTicker.VTI.ToString(),
                    Price = 139.34m
                }
            };
        }

        public static IEnumerable<IClient> GenerateClientMocks()
        {
            return new List<Client> {
                new Client {
                    Id = 1,
                    Name = "A"
                },
                new Client {
                    Id = 1,
                    Name = "B"
                },
            };
        }

        public static IEnumerable<IIndexIncludePermission> GenerateIndexIncludePermissionMocks()
        {
            return new List<IndexIncludePermission> {
                new IndexIncludePermission {
                    Id = 1,
                    ClientName = ClientName.A,
                    Ticker = IndexTicker.SPY.ToString()
                }
            };
        }

        public static IEnumerable<IIndexExcludePermission> GenerateIndexExcludePermissionMocks()
        {
            return new List<IndexExcludePermission> {
                new IndexExcludePermission {
                    Id = 1,
                    ClientName = ClientName.B,
                    Ticker = IndexTicker.VTI.ToString()
                }
            };
        }
    }
}
