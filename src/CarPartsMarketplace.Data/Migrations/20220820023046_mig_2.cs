using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPartsMarketplace.Data.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchasingUserId",
                table: "Products",
                type: "integer",
                nullable: true,
                defaultValue: 0);

           }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasingUserId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(4427), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(4429), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(4430), new byte[] { 181, 100, 113, 199, 66, 71, 180, 18, 2, 166, 173, 23, 252, 48, 221, 132, 187, 24, 251, 248, 206, 24, 234, 204, 35, 213, 16, 60, 32, 123, 177, 100, 86, 47, 91, 164, 254, 86, 57, 228, 155, 43, 170, 248, 116, 217, 240, 157, 143, 29, 105, 78, 86, 201, 50, 133, 58, 2, 108, 128, 49, 30, 35, 200 }, new byte[] { 95, 87, 185, 66, 250, 106, 134, 7, 79, 91, 89, 87, 153, 30, 69, 118, 112, 199, 163, 158, 101, 104, 117, 167, 210, 182, 106, 209, 205, 225, 204, 37, 210, 134, 116, 87, 128, 187, 7, 12, 84, 227, 225, 24, 58, 167, 164, 253, 229, 108, 41, 227, 148, 159, 177, 43, 47, 223, 225, 108, 224, 2, 170, 131, 251, 167, 64, 182, 111, 128, 53, 67, 119, 43, 59, 222, 84, 186, 122, 97, 251, 156, 92, 133, 80, 71, 249, 21, 2, 192, 49, 194, 109, 105, 221, 218, 125, 118, 164, 45, 68, 39, 194, 74, 9, 183, 156, 143, 40, 178, 166, 54, 33, 248, 17, 176, 130, 48, 206, 248, 59, 23, 149, 57, 116, 33, 121, 140 } });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8837), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8839), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8842), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8843), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8844), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8845), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9898), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9899), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9902), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9904), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9906), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9906), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1058), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1060), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1064), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1064), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1529), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1535), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1543), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1544), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8396), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8399), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8405), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8406), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8454), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8455), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1891), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1893), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1896), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1898), new DateTime(2022, 8, 20, 0, 31, 39, 79, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(5993), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(5993), new DateTime(2022, 8, 20, 0, 31, 39, 78, DateTimeKind.Utc).AddTicks(5991) });
        }
    }
}
