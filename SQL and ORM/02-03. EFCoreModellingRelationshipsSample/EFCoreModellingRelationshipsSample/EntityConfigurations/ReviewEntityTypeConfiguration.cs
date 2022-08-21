using EFCoreModellingRelationshipsSample.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreModellingRelationshipsSample.EntityConfigurations;

public class ReviewEntityTypeConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> reviewConfiguration)
    {
        reviewConfiguration
            .HasOne(review => review.Book)
            .WithMany(book => book.Reviews)
            .HasForeignKey(x => x.BookId);
    }
}