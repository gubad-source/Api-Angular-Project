using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    class CardsConfiguration : IEntityTypeConfiguration<Cards>
    {
        public void Configure(EntityTypeBuilder<Cards> builder)
        {
            builder.HasKey(m=>m.Id);
            builder.Property(m => m.Id)
                   .ValueGeneratedOnAdd();
            builder.Property(m => m.Status)
                   .HasDefaultValue(true)
                   .IsRequired();
            builder.Property(m => m.Title)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(m => m.Content)
                   .IsRequired()
                   .HasMaxLength(500);
            builder.Property(m => m.Photo)
                    .IsRequired()
                    .HasMaxLength(100);
            builder.ToTable("Cardss");
        }
    }
}
