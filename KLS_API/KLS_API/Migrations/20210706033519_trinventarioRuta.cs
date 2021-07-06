using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class trinventarioRuta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FotoUnidad",
                table: "Tr_Has_Inventario",
                type: "varchar(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FotoPoliza",
                table: "Tr_Has_Inventario",
                type: "varchar(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruta",
                table: "Tr_Has_Inventario",
                type: "varchar(250)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ruta",
                table: "Tr_Has_Inventario");

            migrationBuilder.AlterColumn<string>(
                name: "FotoUnidad",
                table: "Tr_Has_Inventario",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FotoPoliza",
                table: "Tr_Has_Inventario",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldNullable: true);
        }
    }
}
