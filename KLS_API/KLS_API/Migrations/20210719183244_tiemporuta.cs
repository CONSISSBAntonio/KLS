using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class tiemporuta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "StatusUpdated",
                table: "Viajes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SubEstatus",
                table: "Viajes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tiemporuta",
                table: "Ruta",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusUpdated",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "SubEstatus",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "tiemporuta",
                table: "Ruta");
        }
    }
}
