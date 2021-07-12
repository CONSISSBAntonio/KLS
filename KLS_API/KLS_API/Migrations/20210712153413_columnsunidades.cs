using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class columnsunidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "administrativo",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(11,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "operador",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(11,4)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "administrativo",
                table: "Cat_Tipos_Unidades");

            migrationBuilder.DropColumn(
                name: "operador",
                table: "Cat_Tipos_Unidades");
        }
    }
}
