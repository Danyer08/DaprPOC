namespace Domain.Entities;

public class ServiceEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public decimal? Duration { get; set; }
}