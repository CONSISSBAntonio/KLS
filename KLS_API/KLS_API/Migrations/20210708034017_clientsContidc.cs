using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class clientsContidc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Transportista",
                table: "Cl_Has_Contactos");

            migrationBuilder.AddColumn<int>(
                name: "Id_Cliente",
                table: "Cl_Has_Contactos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Cliente",
                table: "Cl_Has_Contactos");

            migrationBuilder.AddColumn<int>(
                name: "Id_Transportista",
                table: "Cl_Has_Contactos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
