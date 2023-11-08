﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Database;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(GroupDbContext))]
    [Migration("20231108111955_createDatabaseGroup")]
    partial class createDatabaseGroup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("group_id")
                        .HasComment("Идентификатор записи группы");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"));

                    b.Property<string>("ExistGroup")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("group_exist")
                        .HasComment("Факт существования группы");

                    b.Property<string>("NumberGroup")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("num_group")
                        .HasComment("Номер группы");

                    b.Property<int>("SpecId")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("spec_id")
                        .HasComment("Идентификатор специальности");

                    b.Property<int>("YearGroup")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("group_year")
                        .HasComment("Год поступления");

                    b.HasKey("GroupId")
                        .HasName("pk_(TableName) group_id");

                    b.HasIndex(new[] { "SpecId" }, "idx_Group_fk_f_spec_id");

                    b.ToTable("Group", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Specialization", b =>
                {
                    b.Property<int>("SpecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("spec_id")
                        .HasComment("Идентификатор специальности");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecId"));

                    b.Property<string>("SpecName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("spec_name")
                        .HasComment("Специальность");

                    b.HasKey("SpecId")
                        .HasName("pk_(TableName) spec_id");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("WebApplication1.Models.Group", b =>
                {
                    b.HasOne("WebApplication1.Models.Specialization", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_spec_id");

                    b.Navigation("Specialization");
                });
#pragma warning restore 612, 618
        }
    }
}
