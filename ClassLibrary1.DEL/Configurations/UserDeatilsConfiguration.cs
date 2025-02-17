﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.DAL.Configurations;

public class UserDetailsConfiguration : IEntityTypeConfiguration<UserDetails>
{
    public void Configure(EntityTypeBuilder<UserDetails> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(20);
        builder.Property(x => x.Surname).HasMaxLength(20);

        builder
            .HasOne<User>()
            .WithOne(u => u.UserDetails)
            .HasForeignKey<User>(u => u.UserDetailsId);

    }
}