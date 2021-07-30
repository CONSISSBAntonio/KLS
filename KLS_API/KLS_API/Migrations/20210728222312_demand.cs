using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class demand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrdenCompra",
                table: "Viajes");

            migrationBuilder.AddColumn<string>(
                name: "ReferenciaUno",
                table: "Viajes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TiempoAnticipacion",
                table: "Viajes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Demands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    OriginId = table.Column<int>(nullable: false),
                    DestinationId = table.Column<int>(nullable: false),
                    RouteId = table.Column<int>(nullable: false),
                    Folio = table.Column<string>(nullable: true),
                    FechaDisponibilidad = table.Column<DateTime>(nullable: false),
                    FechaLlegada = table.Column<DateTime>(nullable: false),
                    Arribo = table.Column<string>(nullable: true),
                    TipoViaje = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Demands_Clientes_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demands_Cl_Has_Destinos_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Cl_Has_Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demands_Cl_Has_Origen_OriginId",
                        column: x => x.OriginId,
                        principalTable: "Cl_Has_Origen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demands_Ruta_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Ruta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demands_Cat_Tipos_Unidades_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Cat_Tipos_Unidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demands_ClientId",
                table: "Demands",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Demands_DestinationId",
                table: "Demands",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Demands_OriginId",
                table: "Demands",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Demands_RouteId",
                table: "Demands",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Demands_UnitId",
                table: "Demands",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demands");

            migrationBuilder.DropColumn(
                name: "ReferenciaUno",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "TiempoAnticipacion",
                table: "Viajes");

            migrationBuilder.AddColumn<string>(
                name: "OrdenCompra",
                table: "Viajes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
