using Microsoft.EntityFrameworkCore;

namespace EFCoreModellingRelationshipsSample.Entities;

public class PriceOffer
{
    public int Id { get; init; }

    [Precision(18, 2)]
    public decimal NewPrice { get; init; }

    public string PromotionalText { get; init; } = null!;

    public Book Book { get; init; } = null!;
}