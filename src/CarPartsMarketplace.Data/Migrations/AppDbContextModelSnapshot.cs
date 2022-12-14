// <auto-generated />
using System;
using CarPartsMarketplace.Data.Context.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarPartsMarketplace.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(2463),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(2466),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(2467),
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(2472),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(2472),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(2473),
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
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(6334),
                            Email = "admin@admin.com",
                            EmailConfirmation = true,
                            FirstName = "Admin",
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(6336),
                            LastName = "Admin",
                            LockoutEnabled = false,
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(6337),
                            PasswordHash = new byte[] { 106, 191, 94, 127, 243, 87, 94, 153, 88, 72, 29, 43, 216, 180, 137, 80, 188, 83, 36, 87, 49, 106, 96, 167, 176, 85, 167, 181, 136, 182, 106, 10, 82, 205, 206, 166, 122, 111, 112, 69, 202, 162, 150, 82, 72, 219, 120, 156, 118, 145, 141, 219, 181, 130, 48, 34, 80, 181, 87, 155, 54, 124, 76, 73 },
                            PasswordSalt = new byte[] { 155, 120, 178, 221, 46, 165, 11, 191, 98, 149, 194, 132, 88, 34, 74, 133, 91, 155, 141, 100, 169, 87, 173, 108, 172, 127, 250, 208, 80, 160, 223, 89, 92, 62, 8, 10, 168, 42, 178, 64, 106, 253, 205, 219, 106, 132, 90, 66, 117, 63, 216, 61, 218, 8, 56, 174, 208, 33, 71, 231, 19, 5, 135, 141, 243, 215, 151, 204, 153, 30, 113, 245, 77, 166, 41, 231, 16, 165, 3, 163, 133, 120, 232, 222, 197, 128, 191, 164, 41, 152, 209, 192, 29, 109, 251, 177, 232, 96, 161, 114, 133, 58, 114, 179, 1, 253, 151, 218, 178, 162, 182, 110, 126, 200, 16, 192, 189, 107, 78, 146, 77, 170, 185, 184, 201, 216, 7, 48 }
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
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(7394),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(7395),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(7393),
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
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(43),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(45),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(45),
                            Name = "Dayco"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(49),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(50),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(49),
                            Name = "Ngk"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(51),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(51),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(51),
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
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(1390),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(1392),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(1391),
                            Name = "Triger Kayışları"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(1395),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(1396),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(1396),
                            Name = "Ateşleme"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(1445),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(1446),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(1445),
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
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(2669),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(2670),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(2670),
                            Name = "Siyah"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(2674),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(2675),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(2674),
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("Date")
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

                    b.Property<int>("OfferReturn")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

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
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(9580),
                            Description = "Dayco Triger Seti 1.2 16V Dacıa Logan Sandero Clio Kango Modus Symbol Twıngo",
                            ImageUrl = "placeholder.jpg",
                            IsDeleted = false,
                            IsOfferable = true,
                            IsSold = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(9581),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(9582),
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
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(9588),
                            Description = "Kutu İçeriği: 4 adet NGK Spark Plugs CNG/LPG BKR-GAS 7987 İnce Paso Kalem Buji",
                            ImageUrl = "placeholder.jpg",
                            IsDeleted = false,
                            IsOfferable = true,
                            IsSold = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(9589),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(9589),
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
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(9591),
                            Description = "On Fren Dısk Havalandırmalı Bmw 1 Serısı E81 E82 E87 E88 03-12 3 Serısı E90 E91 318d 318ı 320sı 320d 320ı 325sı 325xı 05-11 Bosch 0986479216",
                            ImageUrl = "placeholder.jpg",
                            IsDeleted = false,
                            IsOfferable = false,
                            IsSold = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(9591),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 21, DateTimeKind.Utc).AddTicks(9592),
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
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(3636),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(3638),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(3637),
                            Name = "Sıfır"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = 1,
                            CreatedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(3641),
                            IsDeleted = false,
                            LastActivity = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(3641),
                            ModifiedDate = new DateTime(2022, 8, 20, 17, 20, 13, 22, DateTimeKind.Utc).AddTicks(3641),
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
                    b.HasOne("CarPartsMarketplace.Entities.Product", "Product")
                        .WithMany("Offers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
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
