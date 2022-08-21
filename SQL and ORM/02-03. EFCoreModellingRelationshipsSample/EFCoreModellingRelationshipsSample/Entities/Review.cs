using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreModellingRelationshipsSample.Entities;

public class Review
{
    public int Id { get; init; }
    public string VoterName { get; init; } = null!;
    public int NumStars { get; init; }
    public string Comment { get; init; } = null!;
    public Book Book { get; init; } = null!;
    public int BookId { get; set; }
}