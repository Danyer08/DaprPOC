namespace Domain.Entities;

public class ProductEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public int? Stock { get; set; }
}