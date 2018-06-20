namespace DataPermissioning.Domain.Model
{
    public interface IIndexExcludePermission : IPermission
    {
        string ClientName { get; set; }
        int Id { get; set; }
        string IndexName { get; set; }
        string Ticker { get; set; }
    }
}