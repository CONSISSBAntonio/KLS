using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class Transportistas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RazonSocial",
                table: "Transportista",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(85)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GradoConfiabilidad",
                table: "Transportista",
                type: "varchar(15)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradoConfiabilidad",
                table: "Transportista");

            migrationBuilder.AlterColumn<string>(
                name: "RazonSocial",
                table: "Transportista",
                type: "varchar(85)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);
        }
    }
}
