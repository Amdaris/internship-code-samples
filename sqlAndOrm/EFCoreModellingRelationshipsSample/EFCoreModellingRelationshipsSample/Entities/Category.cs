namespace EFCoreModellingRelationshipsSample.Entities;

public class Category
{
    private Category()
    {
    }

    public Category(string name) : this()
    {
        Name = name;
    }

    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public ICollection<Book> Books { get; init; } = null!;
}