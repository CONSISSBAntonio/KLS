using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class espejo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PassEspejo",
                table: "Viajes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioEspejo",
                table: "Viajes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassEspejo",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "UsuarioEspejo",
                table: "Viajes");
        }
    }
}
