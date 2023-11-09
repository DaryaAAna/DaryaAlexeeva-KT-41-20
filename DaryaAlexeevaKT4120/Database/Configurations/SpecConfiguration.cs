using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DaryaAlexeevaKT4120.Database.Helpers;
using DaryaAlexeevaKT4120.Models;

namespace DaryaAlexeevaKT4120.Database.Configurations
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
