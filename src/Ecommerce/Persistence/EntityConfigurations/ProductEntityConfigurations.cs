using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Persistence.EntityConfigurations;

public class ProductEntityConfigurations: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);

        // builder.HasOne(x => x.Post)
        //     .WithMany(x => x.Comments)
        //     .HasForeignKey(x => x.PostId);
        //
        // builder.HasMany(x => x.Children)
        //     .WithOne(x => x.Parent)
        //     .HasForeignKey(x => x.ParentId);
    }
}
