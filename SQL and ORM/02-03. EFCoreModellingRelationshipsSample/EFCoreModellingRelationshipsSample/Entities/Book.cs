namespace EFCoreModellingRelationshipsSample.Entities;

public class Book
{
    public int Id { get; init; }
    public string Title { get; set; } = null!;
    public string? Description { get; init; }
    public DateTime PublishedOn { get; init; }
    public string Publisher { get; init; } = null!;
    public decimal Price { get; init; }
    public ICollection<Review> Reviews { get; init; } = null!;
    public ICollection<Category> Categories { get; init; } = null!;
    public PriceOffer PriceOffer { get; init; } = null!;
}