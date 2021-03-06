﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20201125193755_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entidades.CategoryEntity", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CategoryName")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entidades.InputOutputEntity", b =>
                {
                    b.Property<string>("InOutId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("InOutDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsInput")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("StorageId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InOutId");

                    b.HasIndex("StorageId");

                    b.ToTable("InputOutputs");
                });

            modelBuilder.Entity("Entidades.ProductEntity", b =>
                {
                    b.Property<string>("ProductId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entidades.StorageEntity", b =>
                {
                    b.Property<string>("StorageId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartialQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("WherehouseId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StorageId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WherehouseId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Entidades.WherehouseEntity", b =>
                {
                    b.Property<string>("WherehouseId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("WherehouseAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WherehouseName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("WherehouseId");

                    b.ToTable("Wherehouses");
                });

            modelBuilder.Entity("Entidades.InputOutputEntity", b =>
                {
                    b.HasOne("Entidades.StorageEntity", "Storage")
                        .WithMany("InputOutputs")
                        .HasForeignKey("StorageId");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("Entidades.ProductEntity", b =>
                {
                    b.HasOne("Entidades.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entidades.StorageEntity", b =>
                {
                    b.HasOne("Entidades.ProductEntity", "Product")
                        .WithMany("Storages")
                        .HasForeignKey("ProductId");

                    b.HasOne("Entidades.WherehouseEntity", "Wherehouse")
                        .WithMany("Storages")
                        .HasForeignKey("WherehouseId");

                    b.Navigation("Product");

                    b.Navigation("Wherehouse");
                });

            modelBuilder.Entity("Entidades.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entidades.ProductEntity", b =>
                {
                    b.Navigation("Storages");
                });

            modelBuilder.Entity("Entidades.StorageEntity", b =>
                {
                    b.Navigation("InputOutputs");
                });

            modelBuilder.Entity("Entidades.WherehouseEntity", b =>
                {
                    b.Navigation("Storages");
                });
#pragma warning restore 612, 618
        }
    }
}
