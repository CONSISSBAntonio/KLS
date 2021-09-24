using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class rutainventariotravelservicefk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Inventario",
                table: "ruta_has_inventario");

            migrationBuilder.AddColumn<int>(
                name: "TravelServiceId",
                table: "ruta_has_inventario",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TravelServiceId",
                table: "ruta_has_inventario");

            migrationBuilder.AddColumn<int>(
                name: "Id_Inventario",
                table: "ruta_has_inventario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
