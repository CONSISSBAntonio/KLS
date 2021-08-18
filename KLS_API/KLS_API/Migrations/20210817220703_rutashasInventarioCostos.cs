using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class rutashasInventarioCostos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                table: "ruta_has_inventario");

            migrationBuilder.AddColumn<decimal>(
                name: "Circuito",
                table: "ruta_has_inventario",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoOne",
                table: "ruta_has_inventario",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoTwo",
                table: "ruta_has_inventario",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Circuito",
                table: "ruta_has_inventario");

            migrationBuilder.DropColumn(
                name: "CostoOne",
                table: "ruta_has_inventario");

            migrationBuilder.DropColumn(
                name: "CostoTwo",
                table: "ruta_has_inventario");

            migrationBuilder.AddColumn<int>(
                name: "Costo",
                table: "ruta_has_inventario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
