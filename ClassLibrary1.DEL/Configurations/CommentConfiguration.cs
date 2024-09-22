using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.DAL.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.Property(x => x.Text).HasMaxLength(20);
        builder.Property(x => x.comment).HasMaxLength(250);
        builder
            .HasMany(x => x.Posts)
            .WithMany(x => x.Comments);
    }
}
