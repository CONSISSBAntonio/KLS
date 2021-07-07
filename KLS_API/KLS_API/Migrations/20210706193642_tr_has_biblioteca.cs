using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class tr_has_biblioteca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Archivo",
                table: "Tr_Has_Biblioteca",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruta",
                table: "Tr_Has_Biblioteca",
                type: "varchar(155)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Archivo",
                table: "Tr_Has_Biblioteca");

            migrationBuilder.DropColumn(
                name: "Ruta",
                table: "Tr_Has_Biblioteca");
        }
    }
}
