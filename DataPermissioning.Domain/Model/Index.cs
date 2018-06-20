namespace DataPermissioning.Domain.Model
{
    public class Index : IIndex
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Ticker { get; set; }
        public decimal Price { get; set; }
    }
}
