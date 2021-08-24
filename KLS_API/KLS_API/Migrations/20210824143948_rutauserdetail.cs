using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class rutauserdetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Viajes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeCreated",
                table: "Viajes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeUpdated",
                table: "Viajes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Viajes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResetToken",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "TimeCreated",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "TimeUpdated",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "ResetToken",
                table: "AspNetUsers");
        }
    }
}
