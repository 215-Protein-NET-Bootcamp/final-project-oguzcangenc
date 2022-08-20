﻿// <auto-generated />
using System;
using CarPartsMarketplace.Data.Context.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarPartsMarketplace.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220820100159_mig_3")]
    partial class mig_3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CarPartsMarketplace.Core.Entities.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedAt")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastActivity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2616),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2619),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2620),
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2623),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2624),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2624),
                            Name = "customer"
                        });
                });

            modelBuilder.Entity("CarPartsMarketplace.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<int>("CreatedAt")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastActivity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(5567),
                            Email = "admin@admin.com",
                            EmailConfirmation = true,
                            FirstName = "Admin",
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(5569),
                            LastName = "Admin",
                            LockoutEnabled = false,
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(5570),
                            PasswordHash = new byte[] { 153, 53, 59, 63, 244, 179, 209, 197, 65, 111, 45, 2, 166, 12, 74, 66, 208, 58, 62, 212, 249, 116, 213, 67, 241, 122, 68, 249, 69, 202, 60, 233, 162, 229, 96, 17, 125, 249, 127, 161, 236, 32, 246, 188, 246, 29, 84, 211, 45, 170, 68, 105, 46, 241, 65, 233, 182, 225, 182, 174, 97, 133, 20, 98 },
                            PasswordSalt = new byte[] { 46, 241, 20, 98, 216, 3, 249, 248, 64, 83, 34, 213, 162, 26, 27, 151, 48, 64, 161, 200, 4, 237, 206, 58, 30, 82, 198, 242, 243, 132, 141, 242, 236, 120, 241, 99, 227, 203, 144, 204, 211, 244, 72, 114, 121, 0, 6, 206, 41, 112, 57, 32, 198, 171, 4, 23, 184, 176, 18, 164, 39, 30, 78, 192, 55, 135, 181, 221, 138, 112, 149, 74, 216, 105, 213, 82, 4, 91, 188, 222, 45, 44, 242, 167, 247, 86, 153, 221, 146, 165, 72, 17, 111, 60, 55, 85, 23, 36, 171, 96, 233, 133, 21, 34, 246, 226, 23, 238, 119, 132, 184, 192, 244, 2, 4, 197, 137, 8, 208, 254, 113, 73, 210, 66, 117, 46, 82, 20 }
                        });
                });

            modelBuilder.Entity("CarPartsMarketplace.Core.Entities.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedAt")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastActivity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(6496),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(6497),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(6495),
                            OperationClaimId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedAt")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastActivity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8962),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8963),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8963),
                            Name = "Dayco"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8967),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8968),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8968),
                            Name = "Ngk"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8969),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8970),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8970),
                            Name = "Bosch"
                        });
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedAt")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastActivity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(38),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(40),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(39),
                            Name = "Triger Kayışları"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(44),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(44),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(44),
                            Name = "Ateşleme"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(45),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(46),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(46),
                            Name = "Fren Sistemi"
                        });
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedAt")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastActivity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1654),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1656),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1656),
                            Name = "Siyah"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1660),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1661),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1661),
                            Name = "Beyaz"
                        });
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedAt")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastActivity")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BrandId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int?>("ColorId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedAt")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOfferable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsSold")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastActivity")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric(18,2)");

                    b.Property<int>("PurchasingUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<int>("UsageId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("UsageId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            ColorId = 1,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8530),
                            Description = "Dayco Triger Seti 1.2 16V Dacıa Logan Sandero Clio Kango Modus Symbol Twıngo",
                            ImageUrl = "placeholder.jpg",
                            IsDeleted = false,
                            IsOfferable = true,
                            IsSold = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8531),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8531),
                            Name = "Dayco Triger Seti 1.2 16V",
                            Price = 1500m,
                            PurchasingUserId = 0,
                            UsageId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            CategoryId = 2,
                            ColorId = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8537),
                            Description = "Kutu İçeriği: 4 adet NGK Spark Plugs CNG/LPG BKR-GAS 7987 İnce Paso Kalem Buji",
                            ImageUrl = "placeholder.jpg",
                            IsDeleted = false,
                            IsOfferable = true,
                            IsSold = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8538),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8538),
                            Name = "Ngk Ateşleme Lpg Buji Takımı",
                            Price = 358m,
                            PurchasingUserId = 0,
                            UsageId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 3,
                            CategoryId = 3,
                            ColorId = 1,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8540),
                            Description = "On Fren Dısk Havalandırmalı Bmw 1 Serısı E81 E82 E87 E88 03-12 3 Serısı E90 E91 318d 318ı 320sı 320d 320ı 325sı 325xı 05-11 Bosch 0986479216",
                            ImageUrl = "placeholder.jpg",
                            IsDeleted = false,
                            IsOfferable = false,
                            IsSold = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8540),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8541),
                            Name = "Bosch On Fren Dısk+Balata Set Ferrari",
                            Price = 657m,
                            PurchasingUserId = 0,
                            UsageId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Usage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedAt")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastActivity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2746),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2748),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2747),
                            Name = "Sıfır"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2751),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2752),
                            ModifiedDate = new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2751),
                            Name = "İkinci El"
                        });
                });

            modelBuilder.Entity("CarPartsMarketplace.Core.Entities.UserOperationClaim", b =>
                {
                    b.HasOne("CarPartsMarketplace.Core.Entities.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarPartsMarketplace.Core.Entities.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Offer", b =>
                {
                    b.HasOne("CarPartsMarketplace.Entities.Product", null)
                        .WithMany("Offers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Product", b =>
                {
                    b.HasOne("CarPartsMarketplace.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.HasOne("CarPartsMarketplace.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarPartsMarketplace.Entities.Color", "Color")
                        .WithMany("Products")
                        .HasForeignKey("ColorId");

                    b.HasOne("CarPartsMarketplace.Entities.Usage", "Usage")
                        .WithMany("Products")
                        .HasForeignKey("UsageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarPartsMarketplace.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Usage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CarPartsMarketplace.Core.Entities.OperationClaim", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("CarPartsMarketplace.Core.Entities.User", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Color", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Product", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("CarPartsMarketplace.Entities.Usage", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
