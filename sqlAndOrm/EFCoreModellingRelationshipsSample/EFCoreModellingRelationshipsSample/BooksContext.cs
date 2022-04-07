using System.Reflection;
using EFCoreModellingRelationshipsSample.Entities;
using EFCoreModellingRelationshipsSample.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreModellingRelationshipsSample;

public class BooksContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Review> Reviews => Set<Review>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<PriceOffer> PriceOffers => Set<PriceOffer>();
    public DbSet<ClassicBook> ClassicBooks => Set<ClassicBook>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ModellingRelationshipsSampleDb")
            .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
            .EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Review>()
        //    .HasOne(review => review.Book)
        //    .WithMany(book => book.Reviews)
        //    .HasForeignKey(x => x.BookFkV2);

        modelBuilder.Entity<PriceOffer>()
            .HasOne(x => x.Book)
            .WithOne(x => x.PriceOffer)
            .HasForeignKey<PriceOffer>("BookFk")
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Book>().ToTable("Books");
        modelBuilder.Entity<ClassicBook>().ToTable("ClassicBooks");

        modelBuilder.ApplyConfiguration(new ReviewEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new BookEntityTypeConfiguration());

        //alternative
        //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}