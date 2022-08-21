using Bogus;
using EFCoreModellingRelationshipsSample.Entities;

namespace EFCoreModellingRelationshipsSample;

public class Seeder
{
    public static void SeedData()
    {
        using var context = new BooksContext();

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        var categories = GetPreconfiguredCategories().ToList();
        var books = GetPreconfiguredBooks(categories).ToList();
        var reviews = GetPreconfiguredReviews(books).ToList();
        var priceOffers = GetPreconfiguredPriceOffers(books).ToList();

        context.Categories.AddRange(categories);
        context.Books.AddRange(books);
        context.Reviews.AddRange(reviews);
        context.PriceOffers.AddRange(priceOffers);

        context.SaveChanges();
    }

    // To use diagrams in LocalDB you can elevate database privileges
    //context.Database.ExecuteSqlRaw("alter authorization on database::ModellingRelationshipsSampleDb to sa");

    private static IEnumerable<Book> GetPreconfiguredBooks(List<Category> categories)
    {
        string[] bookNames =
        {
            ".NET Bot Black Sweatshirt",
            ".NET Black & White Mug",
            "Prism White T-Shirt",
            ".NET Foundation Sweatshirt",
            "Roslyn Red Sheet",
            ".NET Blue Sweatshirt",
            "Roslyn Red T-Shirt",
            "Kudu Purple Sweatshirt"
        };

        var publisherNames = Enumerable.Range(1, 3)
            .Select(_ => new Faker().Company.CompanyName())
            .ToList();


        return bookNames.ToList().Select(bookName =>
            new Faker<Book>()
                .RuleFor(book => book.Title, bookName)
                .RuleFor(book => book.Description, (_, book) => book.Title.ToUpper())
                .RuleFor(book => book.Publisher, faker => faker.PickRandom(publisherNames))
                .RuleFor(book => book.Price, faker => faker.Random.Decimal(100, 5_000))
                .RuleFor(book => book.PublishedOn, faker => faker.Date.Recent())
                .RuleFor(book => book.Categories,
                    faker => faker.PickRandom(categories, faker.Random.Int(2, categories.Count - 1)).ToList())
                .Generate());
    }

    private static IEnumerable<Book> GetPreconfiguredBooks()
    {
        string[] bookNames =
        {
            ".NET Bot Black Sweatshirt",
            ".NET Black & White Mug",
            "Prism White T-Shirt",
            ".NET Foundation Sweatshirt",
            "Roslyn Red Sheet",
            ".NET Blue Sweatshirt",
            "Roslyn Red T-Shirt",
            "Kudu Purple Sweatshirt"
        };

        var publisherNames = Enumerable.Range(1, 3)
            .Select(_ => new Faker().Company.CompanyName())
            .ToList();


        return bookNames.ToList().Select(bookName =>
            new Faker<Book>()
                .RuleFor(book => book.Title, bookName)
                .RuleFor(book => book.Description, (_, book) => book.Title.ToUpper())
                .RuleFor(book => book.Publisher, faker => faker.PickRandom(publisherNames))
                .RuleFor(book => book.Price, faker => faker.Random.Decimal(100, 5_000))
                .RuleFor(book => book.PublishedOn, faker => faker.Date.Recent())
                .Generate());
    }

    private static IEnumerable<Review> GetPreconfiguredReviews(IEnumerable<Book> books) =>
        books.ToList()
            .SelectMany(book => new Faker<Review>()
                .RuleFor(review => review.NumStars, faker => faker.Random.Number(1, 5))
                .RuleFor(review => review.Comment, faker => faker.Lorem.Paragraph())
                .RuleFor(review => review.VoterName, faker => faker.Name.FullName())
                .RuleFor(review => review.Book, book)
                .Generate(new Faker().Random.Number(5, 25))
            );

    private static IEnumerable<Category> GetPreconfiguredCategories() =>
        new List<Category>
        {
            new("Azure"),
            new(".NET"),
            new("Visual Studio"),
            new("SQL Server"),
            new("Other")
        };

    private static IEnumerable<PriceOffer> GetPreconfiguredPriceOffers(IEnumerable<Book> books) =>
        books.ToList()
            .Select(book => new Faker<PriceOffer>()
                .RuleFor(priceOffer => priceOffer.Book, book)
                .RuleFor(priceOffer => priceOffer.NewPrice, faker => faker.Random.Decimal(100, 5_000))
                .RuleFor(priceOffer => priceOffer.PromotionalText, faker => faker.Lorem.Paragraph())
                .Generate()
            );
}