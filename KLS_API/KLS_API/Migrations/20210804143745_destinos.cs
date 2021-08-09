using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class destinos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToleranciaDestino",
                table: "Oferta");

            migrationBuilder.DropColumn(
                name: "ToleranciaOrigen",
                table: "Oferta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ToleranciaDestino",
                table: "Oferta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToleranciaOrigen",
                table: "Oferta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
