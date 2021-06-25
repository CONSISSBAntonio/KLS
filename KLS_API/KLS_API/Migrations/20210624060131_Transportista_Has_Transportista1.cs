using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class Transportista_Has_Transportista1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Tr_Has_Biblioteca",
                type: "varchar(55)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(55)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Tr_Has_Biblioteca",
                type: "varchar(55)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(55)",
                oldNullable: true);
        }
    }
}
