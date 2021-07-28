using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class rutaupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrdenCompra",
                table: "Viajes");

            migrationBuilder.AddColumn<string>(
                name: "ReferenciaUno",
                table: "Viajes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TiempoAnticipacion",
                table: "Viajes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReferenciaUno",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "TiempoAnticipacion",
                table: "Viajes");

            migrationBuilder.AddColumn<string>(
                name: "OrdenCompra",
                table: "Viajes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
