namespace DataPermissioning.Domain.Model
{
    public interface IIndex
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        string Ticker { get; set; }
    }
}