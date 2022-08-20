using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPartsMarketplace.Data.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PurchasingUserId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PurchasingUserId",
                table: "Products",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(7258), new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(7261), new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(7262), new byte[] { 98, 240, 78, 181, 173, 196, 68, 128, 193, 240, 191, 132, 36, 117, 26, 89, 144, 152, 129, 221, 69, 229, 113, 0, 188, 217, 213, 155, 153, 182, 134, 5, 11, 215, 103, 91, 145, 19, 156, 92, 59, 20, 174, 208, 109, 203, 22, 119, 168, 247, 228, 123, 77, 1, 25, 24, 99, 237, 225, 120, 253, 17, 239, 197 }, new byte[] { 33, 192, 61, 158, 101, 59, 83, 145, 12, 147, 18, 35, 96, 244, 7, 222, 144, 249, 30, 118, 194, 237, 109, 58, 227, 21, 114, 2, 238, 161, 15, 211, 49, 102, 209, 56, 251, 107, 152, 136, 203, 122, 53, 178, 125, 14, 7, 154, 144, 90, 245, 79, 140, 50, 28, 218, 100, 117, 184, 86, 146, 204, 135, 240, 246, 139, 58, 10, 14, 135, 31, 219, 173, 251, 171, 162, 208, 1, 125, 218, 10, 1, 96, 30, 130, 77, 158, 65, 75, 236, 198, 119, 126, 168, 72, 11, 183, 52, 43, 40, 80, 176, 193, 118, 95, 181, 101, 165, 7, 26, 233, 239, 70, 108, 18, 134, 91, 228, 32, 58, 205, 136, 98, 148, 28, 50, 16, 167 } });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(1114), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(1115), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(1120), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(1121), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(1122), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(1123), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(2387), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(2388), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(2393), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(2394), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(2395), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(2396), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(3705), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(3706), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(3710), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(3711), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(3773), new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(3780), new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(3786), new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(3787), new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(547), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(549), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(557), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(557), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(602), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(604), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(4669), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(4671), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(4675), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(4676), new DateTime(2022, 8, 20, 2, 30, 45, 763, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastActivity", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(8355), new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(8356), new DateTime(2022, 8, 20, 2, 30, 45, 762, DateTimeKind.Utc).AddTicks(8354) });
        }
    }
}
