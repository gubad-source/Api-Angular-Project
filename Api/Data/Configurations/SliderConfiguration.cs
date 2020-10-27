﻿using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.HasKey(m => m.Id);
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
            builder.Property(m => m.Header)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(m => m.Profession)
               .HasMaxLength(50)
               .IsRequired();
            builder.ToTable("Sliders");
        }
    }
}
