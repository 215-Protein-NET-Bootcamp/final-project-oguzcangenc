using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPartsMarketplace.Data.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "ApplicationUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LockoudEnd",
                table: "ApplicationUsers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "ApplicationUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "LockoudEnd",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "ApplicationUsers");
        }
    }
}
