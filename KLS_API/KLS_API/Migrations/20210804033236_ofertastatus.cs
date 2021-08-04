using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class ofertastatus : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Oferta",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassEspejo",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "UsuarioEspejo",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Oferta");
        }
    }
}
