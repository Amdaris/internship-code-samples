using EFCoreModellingRelationshipsSample.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreModellingRelationshipsSample.EntityConfigurations;

public class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> bookConfiguration)
    {
        bookConfiguration
            .HasMany(book => book.Categories)
            .WithMany(category => category.Books)
            .UsingEntity<BookCategory>(bc =>
                    bc.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId),
                bc => bc.HasOne(x => x.Book).WithMany().HasForeignKey(x => x.BookId)
            );
    }
}