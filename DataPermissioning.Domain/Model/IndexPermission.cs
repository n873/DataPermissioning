namespace DataPermissioning.Domain.Model
{
    public class IndexIncludePermission : IIndexIncludePermission
    {
        public int Id { get; set; }

        public string ClientName { get; set; }
        public string Ticker { get; set; }
        public string IndexName { get; set; }
    }

    public class IndexExcludePermission : IIndexExcludePermission
    {
        public int Id { get; set; }

        public string ClientName { get; set; }
        public string Ticker { get; set; }
        public string IndexName { get; set; }
    }
}
