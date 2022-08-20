using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPartsMarketplace.Data.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfferReturn",
                table: "Offers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

          }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfferReturn",
                table: "Offers");

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(8674), new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(8676), new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(8677), new byte[] { 182, 131, 172, 82, 28, 91, 201, 162, 36, 242, 204, 213, 253, 9, 1, 27, 204, 97, 216, 106, 185, 89, 58, 166, 226, 23, 59, 229, 181, 239, 232, 24, 13, 138, 17, 178, 250, 8, 30, 49, 46, 153, 48, 144, 57, 26, 42, 132, 11, 117, 229, 189, 224, 7, 3, 56, 239, 9, 16, 254, 19, 134, 101, 245 }, new byte[] { 171, 161, 143, 254, 245, 3, 147, 230, 167, 89, 253, 246, 242, 237, 213, 222, 51, 92, 18, 129, 138, 242, 21, 90, 148, 188, 118, 85, 190, 79, 175, 66, 246, 96, 57, 241, 215, 163, 127, 200, 97, 205, 189, 138, 0, 115, 188, 175, 77, 182, 119, 114, 32, 142, 247, 199, 57, 68, 186, 223, 214, 109, 187, 58, 197, 193, 215, 25, 222, 168, 158, 238, 12, 92, 225, 249, 191, 117, 65, 9, 62, 74, 14, 94, 99, 193, 138, 107, 64, 34, 154, 60, 13, 195, 31, 162, 1, 154, 153, 214, 59, 102, 120, 170, 195, 38, 205, 206, 66, 254, 172, 9, 145, 230, 65, 209, 32, 40, 58, 213, 9, 191, 23, 173, 143, 82, 87, 242 } });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2932), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2934), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2937), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2938), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2939), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2940), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(4059), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(4061), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(4064), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(4065), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(4066), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(4067), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(5130), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(5132), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(5136), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(5137), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(4966), new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(4976), new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(4982), new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(4983), new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2471), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2473), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2479), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2480), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2482), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2483), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(6116), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(6117), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(6120), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(6121), new DateTime(2022, 8, 20, 10, 2, 56, 699, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(9802), new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(9803), new DateTime(2022, 8, 20, 10, 2, 56, 698, DateTimeKind.Utc).AddTicks(9801) });
        }
    }
}
