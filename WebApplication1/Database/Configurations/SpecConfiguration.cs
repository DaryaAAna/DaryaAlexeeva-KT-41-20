﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Database.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Database.Configurations
{
    public class SpecConfiguration : IEntityTypeConfiguration<Models.Specialization>
    {
        private const string TableName = "Specialization";

        public void Configure(EntityTypeBuilder<Specialization> builder)
        {
            builder
                     .HasKey(p => p.SpecId)
                     .HasName($"pk_(TableName) spec_id");

            builder
                  .Property(p => p.SpecId)
                  .ValueGeneratedOnAdd();

            builder.Property(p => p.SpecId)
               .HasColumnName("spec_id")
               .HasComment("Идентификатор специальности");

            builder.Property(p => p.SpecName)
                .IsRequired()
                .HasColumnName("spec_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Специальность");
        }
    }
}
