using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class viaje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estatus",
                table: "Viajes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Folio",
                table: "Viajes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estatus",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "Folio",
                table: "Viajes");
        }
    }
}
