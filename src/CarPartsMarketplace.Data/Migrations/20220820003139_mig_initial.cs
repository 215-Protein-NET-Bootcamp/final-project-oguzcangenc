using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarPartsMarketplace.Data.Migrations
{
    public partial class mig_initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmailConfirmation = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    CreatedAt = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastActivity = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastActivity = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastActivity = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastActivity = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastActivity = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastActivity = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    OperationClaimId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastActivity = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    BrandId = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ColorId = table.Column<int>(type: "integer", nullable: true),
                    UsageId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    IsOfferable = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    IsSold = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastActivity = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Usages_UsageId",
                        column: x => x.UsageId,
                        principalTable: "Usages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastActivity = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "CreatedAt", "CreatedDate", "Email", "EmailConfirmation", "FirstName", "LastActivity", "LastName", "ModifiedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(4427), "admin@admin.com", true, "Admin", new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(4429), "Admin", new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(4430), new byte[] { 181, 100, 113, 199, 66, 71, 180, 18, 2, 166, 173, 23, 252, 48, 221, 132, 187, 24, 251, 248, 206, 24, 234, 204, 35, 213, 16, 60, 32, 123, 177, 100, 86, 47, 91, 164, 254, 86, 57, 228, 155, 43, 170, 248, 116, 217, 240, 157, 143, 29, 105, 78, 86, 201, 50, 133, 58, 2, 108, 128, 49, 30, 35, 200 }, new byte[] { 95, 87, 185, 66, 250, 106, 134, 7, 79, 91, 89, 87, 153, 30, 69, 118, 112, 199, 163, 158, 101, 104, 117, 167, 210, 182, 106, 209, 205, 225, 204, 37, 210, 134, 116, 87, 128, 187, 7, 12, 84, 227, 225, 24, 58, 167, 164, 253, 229, 108, 41, 227, 148, 159, 177, 43, 47, 223, 225, 108, 224, 2, 170, 131, 251, 167, 64, 182, 111, 128, 53, 67, 119, 43, 59, 222, 84, 186, 122, 97, 251, 156, 92, 133, 80, 71, 249, 21, 2, 192, 49, 194, 109, 105, 221, 218, 125, 118, 164, 45, 68, 39, 194, 74, 9, 183, 156, 143, 40, 178, 166, 54, 33, 248, 17, 176, 130, 48, 206, 248, 59, 23, 149, 57, 116, 33, 121, 140 } });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "CreatedDate", "LastActivity", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8837), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8839), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8838), "Dayco" },
                    { 2, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8842), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8843), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8843), "Ngk" },
                    { 3, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8844), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8845), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8844), "Bosch" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedDate", "LastActivity", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9898), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9899), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9899), "Triger Kayışları" },
                    { 2, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9902), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9904), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9903), "Ateşleme" },
                    { 3, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9906), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9906), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9906), "Fren Sistemi" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedAt", "CreatedDate", "LastActivity", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1058), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1060), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1059), "Siyah" },
                    { 2, 1, new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1064), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1064), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1064), "Beyaz" }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedAt", "CreatedDate", "IsDeleted", "LastActivity", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1529), false, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1535), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1536), "admin" },
                    { 2, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1543), false, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1544), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1544), "customer" }
                });

            migrationBuilder.InsertData(
                table: "Usages",
                columns: new[] { "Id", "CreatedAt", "CreatedDate", "IsDeleted", "LastActivity", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1891), false, new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1893), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1892), "Sıfır" },
                    { 2, 1, new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1896), false, new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1898), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1897), "İkinci El" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "ColorId", "CreatedAt", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "IsOfferable", "LastActivity", "ModifiedDate", "Name", "Price", "UsageId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8396), "Dayco Triger Seti 1.2 16V Dacıa Logan Sandero Clio Kango Modus Symbol Twıngo", "placeholder.jpg", false, true, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8399), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8399), "Dayco Triger Seti 1.2 16V", 1500m, 1, 1 },
                    { 2, 2, 2, 2, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8405), "Kutu İçeriği: 4 adet NGK Spark Plugs CNG/LPG BKR-GAS 7987 İnce Paso Kalem Buji", "placeholder.jpg", false, true, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8406), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8406), "Ngk Ateşleme Lpg Buji Takımı", 358m, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "ColorId", "CreatedAt", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "LastActivity", "ModifiedDate", "Name", "Price", "UsageId", "UserId" },
                values: new object[] { 3, 3, 3, 1, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8454), "On Fren Dısk Havalandırmalı Bmw 1 Serısı E81 E82 E87 E88 03-12 3 Serısı E90 E91 318d 318ı 320sı 320d 320ı 325sı 325xı 05-11 Bosch 0986479216", "placeholder.jpg", false, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8455), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8455), "Bosch On Fren Dısk+Balata Set Ferrari", 657m, 1, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedAt", "CreatedDate", "IsDeleted", "LastActivity", "ModifiedDate", "OperationClaimId", "UserId" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(5993), false, new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(5993), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(5991), 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ProductId",
                table: "Offers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UsageId",
                table: "Products",
                column: "UsageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Usages");
        }
    }
}
