using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class Transportistas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "rendimiento",
                table: "Cat_Tipos_Unidades",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "mantenimiento",
                table: "Cat_Tipos_Unidades",
                type: "decimal(2,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "llantas",
                table: "Cat_Tipos_Unidades",
                type: "decimal(2,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "litros",
                table: "Cat_Tipos_Unidades",
                type: "decimal(2,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "limite_peso",
                table: "Cat_Tipos_Unidades",
                type: "decimal(3,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(3,2)");

            migrationBuilder.CreateTable(
                name: "Transportista",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreComercial = table.Column<string>(type: "varchar(55)", nullable: true),
                    Tamanio = table.Column<string>(type: "varchar(22)", nullable: true),
                    Servicio = table.Column<string>(type: "varchar(15)", nullable: true),
                    NivelServicio = table.Column<int>(nullable: false),
                    Comentario = table.Column<string>(type: "varchar(100)", nullable: true),
                    FechaUltimoViaje = table.Column<DateTime>(nullable: false),
                    Estatus = table.Column<int>(nullable: false),
                    RazonSocial = table.Column<string>(type: "varchar(85)", nullable: true),
                    Rfc = table.Column<string>(type: "varchar(25)", nullable: true),
                    DireccionFiscal = table.Column<string>(type: "varchar(250)", nullable: true),
                    DireccionOficinas = table.Column<string>(type: "varchar(250)", nullable: true),
                    DireccionPatio = table.Column<string>(type: "varchar(250)", nullable: true),
                    GoogleMaps = table.Column<string>(type: "varchar(250)", nullable: true),
                    PaginaWeb = table.Column<string>(type: "varchar(250)", nullable: true),
                    Facebook = table.Column<string>(type: "varchar(250)", nullable: true),
                    OtraRed = table.Column<string>(type: "varchar(250)", nullable: true),
                    Banco = table.Column<string>(type: "varchar(90)", nullable: true),
                    Cuenta = table.Column<string>(type: "varchar(25)", nullable: true),
                    UsuarioMaster = table.Column<string>(type: "varchar(35)", nullable: true),
                    Contrasena = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportista", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transportista");

            migrationBuilder.AlterColumn<decimal>(
                name: "rendimiento",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "mantenimiento",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "llantas",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "litros",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "limite_peso",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(3,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)");
        }
    }
}
