﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Persistence.Configurations
{
    class CategoryBuilder : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category")
                    .HasKey(e => e.Id);

            builder.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .IsRequired();

            builder.Property(e => e.ParentId)
                    .IsRequired()
                    .HasDefaultValue(1);

            builder.Property(e => e.Name)
                    .IsRequired();

            builder.HasMany<Category>(e => e.SubCategories)
                    .WithOne(e => e.ParentCategory)
                    .HasForeignKey(e => e.ParentId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
