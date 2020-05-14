﻿// <auto-generated />
using System;
using ConsoleModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleModels.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200514072837_RenameGoodsToGood")]
    partial class RenameGoodsToGood
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleModels.Models.Good", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("GoodsType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsFolder")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPredefined")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LicenseID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<Guid?>("ParentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("QuantityOnConsist")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("UnitOfConsist")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("UnitOfSale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("UnitOfStore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("IsFolder");

                    b.HasIndex("IsPredefined");

                    b.HasIndex("LicenseID");

                    b.HasIndex("Name");

                    b.HasIndex("ParentID");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("ConsoleModels.Models.RcordOfGoodConsist", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("GoodID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Brutto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Netto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Unit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id", "GoodID");

                    b.HasIndex("GoodID");

                    b.ToTable("RcordOfGoodConsist");
                });

            modelBuilder.Entity("ConsoleModels.Models.References.Contragents", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsFolder")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPredefined")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LicenseID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid?>("ParentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("IsFolder");

                    b.HasIndex("IsPredefined");

                    b.HasIndex("LicenseID");

                    b.HasIndex("Name");

                    b.HasIndex("ParentID");

                    b.ToTable("Contragents");
                });

            modelBuilder.Entity("ConsoleModels.Models.References.Storeges", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsFolder")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPredefined")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LicenseID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid?>("ParentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("IsFolder");

                    b.HasIndex("IsPredefined");

                    b.HasIndex("LicenseID");

                    b.HasIndex("Name");

                    b.HasIndex("ParentID");

                    b.ToTable("Storeges");
                });

            modelBuilder.Entity("ConsoleModels.Models.Good", b =>
                {
                    b.HasOne("ConsoleModels.Models.Good", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("ConsoleModels.Models.RcordOfGoodConsist", b =>
                {
                    b.HasOne("ConsoleModels.Models.Good", "Good")
                        .WithMany("Consist")
                        .HasForeignKey("GoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleModels.Models.References.Contragents", b =>
                {
                    b.HasOne("ConsoleModels.Models.References.Contragents", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("ConsoleModels.Models.References.Storeges", b =>
                {
                    b.HasOne("ConsoleModels.Models.References.Storeges", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.NoAction);
                });
#pragma warning restore 612, 618
        }
    }
}
