using EFCoreModellingRelationshipsSample;
using EFCoreModellingRelationshipsSample.Entities;
using Microsoft.EntityFrameworkCore;

await using var context = new BooksContext();

//context.Database.EnsureDeleted();
//context.Database.EnsureCreated();

//Seeder.SeedData();

//var books = await context.Books
//    .Include(book => book.PriceOffer)
//    .Include(book => book.Categories)
//    .ToListAsync();

//var cbook = new ClassicBook
//{
//    ClassicAuth = nameof(ClassicBook.ClassicAuth),
//    Title = nameof(ClassicBook.Title),
//    Publisher = nameof(ClassicBook.Publisher),
//    PublishedOn = DateTime.Now,
//    Price = 2,
//};

//context.ClassicBooks.Add(cbook);
//await context.SaveChangesAsync();

//var cbook = await context.ClassicBooks.FirstAsync();

//var book = await context.Books
//    .FirstAsync();

//context.Remove(book);
//await context.SaveChangesAsync();

var books = await context.Books.GroupBy(x => x.Publisher)
    .Select(x => new
    {
        Name = x.Key,
        AveragePrice = x.Average(y => y.Price),
        Count = x.Count()
    })
    .ToListAsync();

Console.ReadKey();
