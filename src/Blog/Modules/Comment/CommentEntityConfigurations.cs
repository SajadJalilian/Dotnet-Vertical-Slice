using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Modules.Comment;

public class CommentEntityConfigurations : IEntityTypeConfiguration<CommentEntity>
{
    public void Configure(EntityTypeBuilder<CommentEntity> builder)
    {
        builder.ToTable("Comments");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Text)
            .HasMaxLength(1000);

        builder.HasOne(x => x.PostEntity)
            .WithMany(x => x.Comments)
            .HasForeignKey(x => x.PostId);

        builder.HasMany(x => x.Children)
            .WithOne(x => x.Parent)
            .HasForeignKey(x => x.ParentId);
    }
}