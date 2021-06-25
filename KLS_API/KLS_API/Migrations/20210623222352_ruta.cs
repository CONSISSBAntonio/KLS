using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class ruta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ruta",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_estadoorigen = table.Column<int>(nullable: false),
                    id_ciudadorigen = table.Column<int>(nullable: false),
                    id_estadodestino = table.Column<int>(nullable: false),
                    id_ciudaddestino = table.Column<int>(nullable: false),
                    totalkilometros = table.Column<int>(nullable: false),
                    eficiencia = table.Column<string>(type: "varchar(20)", nullable: true),
                    totalhoras = table.Column<string>(type: "varchar(20)", nullable: true),
                    seguridad = table.Column<string>(type: "varchar(20)", nullable: true),
                    demanda = table.Column<string>(type: "varchar(20)", nullable: true),
                    tipodeviaje = table.Column<string>(type: "varchar(20)", nullable: true),
                    estatus = table.Column<int>(nullable: false),
                    frecvalidacion = table.Column<string>(type: "varchar(100)", nullable: true),
                    restriccioncirc = table.Column<string>(type: "varchar(100)", nullable: true),
                    observaciones = table.Column<string>(type: "text", nullable: true),
                    actualizadopor = table.Column<string>(type: "varchar(100)", nullable: true),
                    ultimocambio = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruta", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ruta");
        }
    }
}
