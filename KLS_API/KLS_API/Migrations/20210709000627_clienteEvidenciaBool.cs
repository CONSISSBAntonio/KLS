using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class clienteEvidenciaBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Fisica",
                table: "Cl_Has_Evidencia",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mandatario",
                table: "Cl_Has_Evidencia",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fisica",
                table: "Cl_Has_Evidencia");

            migrationBuilder.DropColumn(
                name: "Mandatario",
                table: "Cl_Has_Evidencia");
        }
    }
}
