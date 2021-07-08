using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class routesClientesIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Cliente_Kls",
                table: "Cl_Has_Routes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Ruta",
                table: "Cl_Has_Routes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Cliente_Kls",
                table: "Cl_Has_Routes");

            migrationBuilder.DropColumn(
                name: "Id_Ruta",
                table: "Cl_Has_Routes");
        }
    }
}
