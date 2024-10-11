using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Modules.Post;

public class PostEntityConfigurations : IEntityTypeConfiguration<PostEntity>
{
    public void Configure(EntityTypeBuilder<PostEntity> builder)
    {
        builder.ToTable("Posts");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .HasMaxLength(500);
        
        builder.Property(x => x.Body)
            .HasMaxLength(5000);

        builder.HasMany(x => x.Comments)
            .WithOne(y => y.PostEntity)
            .HasForeignKey(z => z.PostId);
    }
}