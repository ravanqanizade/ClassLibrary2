﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.DAL.Configurations;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Text).HasMaxLength(20);
        builder.Property(x => x.Comment).HasMaxLength(250);

        builder
            .HasOne(x => x.User)  //Navigation
            .WithMany(x => x.Posts) //ICollection
            .HasForeignKey(x => x.UserId);
        builder
            .HasMany(x => x.Comments)
            .WithMany(x => x.Posts);
    }
}