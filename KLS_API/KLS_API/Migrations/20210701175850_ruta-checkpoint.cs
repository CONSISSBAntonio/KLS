using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class rutacheckpoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cat_CiudadId",
                table: "Ruta_Has_Checkpoint");

            migrationBuilder.DropColumn(
                name: "tipodeviaje",
                table: "Ruta");

            migrationBuilder.DropColumn(
                name: "totalhoras",
                table: "Ruta");

            migrationBuilder.AlterColumn<int>(
                name: "tiempo",
                table: "Ruta_Has_Checkpoint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "Ruta_Has_Checkpoint",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "frecvalidacion",
                table: "Ruta",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "eficiencia",
                table: "Ruta",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Facturacion",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "VARCHAR(300)", nullable: true),
                    fullpath = table.Column<string>(nullable: true),
                    fechacarga = table.Column<DateTime>(nullable: false),
                    usuarioId = table.Column<int>(nullable: false),
                    usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturacion", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturacion");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "Ruta_Has_Checkpoint");

            migrationBuilder.AlterColumn<string>(
                name: "tiempo",
                table: "Ruta_Has_Checkpoint",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Cat_CiudadId",
                table: "Ruta_Has_Checkpoint",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "frecvalidacion",
                table: "Ruta",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "eficiencia",
                table: "Ruta",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "tipodeviaje",
                table: "Ruta",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "totalhoras",
                table: "Ruta",
                type: "varchar(20)",
                nullable: true);
        }
    }
}
