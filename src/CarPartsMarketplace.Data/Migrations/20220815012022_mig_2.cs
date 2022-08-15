using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPartsMarketplace.Data.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "ApplicationUsers");

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmation",
                table: "ApplicationUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "ApplicationUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmation",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "ApplicationUsers");

            migrationBuilder.RenameTable(
                name: "ApplicationUsers",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
