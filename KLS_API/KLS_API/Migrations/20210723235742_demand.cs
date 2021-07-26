using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class demand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Demands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Folio = table.Column<string>(nullable: true),
                    ClientId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    FechaDisponibilidad = table.Column<DateTime>(nullable: false),
                    RangoEspera = table.Column<int>(nullable: false),
                    NivelOrigen = table.Column<string>(nullable: true),
                    EstadoIdOrigen = table.Column<int>(nullable: false),
                    RegionIdOrigen = table.Column<int>(nullable: false),
                    CiudadIdOrigen = table.Column<int>(nullable: false),
                    ToleranciaOrigen = table.Column<int>(nullable: false),
                    NivelDestino = table.Column<string>(nullable: true),
                    EstadoIdDestino = table.Column<int>(nullable: false),
                    RegionIdDestino = table.Column<int>(nullable: false),
                    CiudadIdDestino = table.Column<int>(nullable: false),
                    ToleranciaDestino = table.Column<int>(nullable: false),
                    Arribo = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demands", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demands");
        }
    }
}
