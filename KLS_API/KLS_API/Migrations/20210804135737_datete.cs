using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class datete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Disponibilidad",
                table: "Oferta",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToleranciaDestino",
                table: "Oferta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToleranciaOrigen",
                table: "Oferta",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToleranciaDestino",
                table: "Oferta");

            migrationBuilder.DropColumn(
                name: "ToleranciaOrigen",
                table: "Oferta");

            migrationBuilder.AlterColumn<string>(
                name: "Fecha_Disponibilidad",
                table: "Oferta",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
