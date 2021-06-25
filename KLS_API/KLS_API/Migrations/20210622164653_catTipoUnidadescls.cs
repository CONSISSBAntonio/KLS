using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class catTipoUnidadescls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rendimiento",
                table: "Cat_Tipos_Unidades",
                newName: "rendimiento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "rendimiento",
                table: "Cat_Tipos_Unidades",
                newName: "Rendimiento");
        }
    }
}
