using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPartsMarketplace.Data.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Offers",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Offers",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastActivity",
                table: "Offers",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Offers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Offers",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

          }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Offers",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Offers",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastActivity",
                table: "Offers",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Offers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Offers",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(5567), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(5569), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(5570), new byte[] { 153, 53, 59, 63, 244, 179, 209, 197, 65, 111, 45, 2, 166, 12, 74, 66, 208, 58, 62, 212, 249, 116, 213, 67, 241, 122, 68, 249, 69, 202, 60, 233, 162, 229, 96, 17, 125, 249, 127, 161, 236, 32, 246, 188, 246, 29, 84, 211, 45, 170, 68, 105, 46, 241, 65, 233, 182, 225, 182, 174, 97, 133, 20, 98 }, new byte[] { 46, 241, 20, 98, 216, 3, 249, 248, 64, 83, 34, 213, 162, 26, 27, 151, 48, 64, 161, 200, 4, 237, 206, 58, 30, 82, 198, 242, 243, 132, 141, 242, 236, 120, 241, 99, 227, 203, 144, 204, 211, 244, 72, 114, 121, 0, 6, 206, 41, 112, 57, 32, 198, 171, 4, 23, 184, 176, 18, 164, 39, 30, 78, 192, 55, 135, 181, 221, 138, 112, 149, 74, 216, 105, 213, 82, 4, 91, 188, 222, 45, 44, 242, 167, 247, 86, 153, 221, 146, 165, 72, 17, 111, 60, 55, 85, 23, 36, 171, 96, 233, 133, 21, 34, 246, 226, 23, 238, 119, 132, 184, 192, 244, 2, 4, 197, 137, 8, 208, 254, 113, 73, 210, 66, 117, 46, 82, 20 } });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8962), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8963), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8967), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8968), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8969), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8970), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(38), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(40), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(44), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(44), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(45), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(46), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1654), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1656), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1660), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1661), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2616), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2619), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2623), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2624), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8530), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8531), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8537), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8538), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8540), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8540), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2746), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2748), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2751), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2752), new DateTime(2022, 8, 20, 10, 1, 58, 260, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(6496), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(6497), new DateTime(2022, 8, 20, 10, 1, 58, 259, DateTimeKind.Utc).AddTicks(6495) });
        }
    }
}
