namespace Domain.Entities;

public class PuchaserOrderEntity
{
    public Guid Id { get; set; }
    public required string Description { get; set; }
    public Guid SupplierId { get; set; }
    public required SupplierEntity SupplierEntity { get; set; }
    public required IEnumerable<ProductEntity> Products { get; set; }
}