namespace DataPermissioning.Domain.Model
{
    public interface IPermission
    {
        int Id { get; set; }

        string ClientName { get; set; }
    }
}