using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class catTipoUnidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Rendimiento",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ejes",
                table: "Cat_Tipos_Unidades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "estatus",
                table: "Cat_Tipos_Unidades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "limite_peso",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(3,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "limite_volumen",
                table: "Cat_Tipos_Unidades",
                type: "Varchar(35)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "litros",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "llantas",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "mantenimiento",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rendimiento",
                table: "Cat_Tipos_Unidades");

            migrationBuilder.DropColumn(
                name: "ejes",
                table: "Cat_Tipos_Unidades");

            migrationBuilder.DropColumn(
                name: "estatus",
                table: "Cat_Tipos_Unidades");

            migrationBuilder.DropColumn(
                name: "limite_peso",
                table: "Cat_Tipos_Unidades");

            migrationBuilder.DropColumn(
                name: "limite_volumen",
                table: "Cat_Tipos_Unidades");

            migrationBuilder.DropColumn(
                name: "litros",
                table: "Cat_Tipos_Unidades");

            migrationBuilder.DropColumn(
                name: "llantas",
                table: "Cat_Tipos_Unidades");

            migrationBuilder.DropColumn(
                name: "mantenimiento",
                table: "Cat_Tipos_Unidades");
        }
    }
}
