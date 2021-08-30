using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class maintravelstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaLlegada",
                table: "MainTravels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaSalida",
                table: "MainTravels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Folio",
                table: "MainTravels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "MainTravels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subestatus",
                table: "MainTravels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaLlegada",
                table: "MainTravels");

            migrationBuilder.DropColumn(
                name: "FechaSalida",
                table: "MainTravels");

            migrationBuilder.DropColumn(
                name: "Folio",
                table: "MainTravels");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "MainTravels");

            migrationBuilder.DropColumn(
                name: "Subestatus",
                table: "MainTravels");
        }
    }
}
