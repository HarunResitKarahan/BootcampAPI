﻿// <auto-generated />
using BootcampAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BootcampAPI.Migrations
{
    [DbContext(typeof(DBFullStackContext))]
    [Migration("20221110191251_deneme")]
    partial class deneme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BootcampAPI.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("BootcampAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PictureUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BootcampAPI.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategorys");
                });

            modelBuilder.Entity("BootcampAPI.Models.Product", b =>
                {
                    b.HasOne("BootcampAPI.Models.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("BootcampAPI.Models.SubCategory", b =>
                {
                    b.HasOne("BootcampAPI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
