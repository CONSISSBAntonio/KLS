using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class tr_has_operadores_rutas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NoTelefono",
                table: "Tr_Has_Operadores",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.AddColumn<string>(
                name: "FotoIne",
                table: "Tr_Has_Operadores",
                type: "varchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoLicencia",
                table: "Tr_Has_Operadores",
                type: "varchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruta",
                table: "Tr_Has_Operadores",
                type: "varchar(15)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoIne",
                table: "Tr_Has_Operadores");

            migrationBuilder.DropColumn(
                name: "FotoLicencia",
                table: "Tr_Has_Operadores");

            migrationBuilder.DropColumn(
                name: "Ruta",
                table: "Tr_Has_Operadores");

            migrationBuilder.AlterColumn<string>(
                name: "NoTelefono",
                table: "Tr_Has_Operadores",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
