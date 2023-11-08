using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Models.Group>
    {
        private const string TableName = "Group";

        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                  .HasKey(p => p.GroupId)
                  .HasName($"pk_(TableName) group_id");

            builder
                  .Property(p => p.GroupId)
                  .ValueGeneratedOnAdd();

            builder.Property(p => p.GroupId)
                .HasColumnName("group_id")
                .HasComment("Идентификатор записи группы");

            builder.Property(p => p.NumberGroup)
                .IsRequired()
                .HasColumnName("num_group")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Номер группы");

            builder.Property(p => p.YearGroup)
                .IsRequired()
                .HasColumnName("group_year")
                .HasColumnType(ColumnType.Int).HasMaxLength(100)
                .HasComment("Год поступления");

            builder.Property(p => p.ExistGroup)
                .IsRequired()
                .HasColumnName("group_exist")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Факт существования группы");

            builder.Property(p => p.SpecId)
                .IsRequired()
                .HasColumnName("spec_id")
                .HasColumnType(ColumnType.Int).HasMaxLength(100)
                .HasComment("Идентификатор специальности");

            builder.ToTable(TableName)
                .HasOne(p => p.Specialization)
                .WithMany()
                .HasForeignKey(p => p.SpecId)
                .HasConstraintName("fk_f_spec_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(p => p.SpecId, $"idx_{TableName}_fk_f_spec_id");

            builder.Navigation(p => p.Specialization)
                .AutoInclude();
        }
    }
}
