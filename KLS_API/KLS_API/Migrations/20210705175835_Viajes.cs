using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class Viajes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Viajes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(nullable: false),
                    IdOrigen = table.Column<int>(nullable: false),
                    IdDestino = table.Column<int>(nullable: false),
                    IdRuta = table.Column<int>(nullable: false),
                    IdUnidad = table.Column<int>(nullable: false),
                    TipoViaje = table.Column<string>(nullable: true),
                    FechaSalida = table.Column<DateTime>(nullable: false),
                    FechaLlegada = table.Column<DateTime>(nullable: false),
                    DireccionRemitente = table.Column<string>(nullable: true),
                    DireccionDestinatario = table.Column<string>(nullable: true),
                    OrdenCompra = table.Column<string>(nullable: true),
                    ReferenciaDos = table.Column<string>(nullable: true),
                    ReferenciaTres = table.Column<string>(nullable: true),
                    Shipper = table.Column<string>(nullable: true),
                    Consignee = table.Column<string>(nullable: true),
                    HBL = table.Column<string>(nullable: true),
                    Intercom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viajes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdTravel = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    IdTransportista = table.Column<int>(nullable: false),
                    IdChofer = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CostoTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PrecioClienteTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CostoTI = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PrecioTI = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IdNaviera = table.Column<int>(nullable: false),
                    Buque = table.Column<string>(nullable: true),
                    CostoN = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PrecioN = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IdAgenteAduanal = table.Column<int>(nullable: false),
                    IdContactoAA = table.Column<int>(nullable: false),
                    CostoAA = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PrecioAA = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IdAerolinea = table.Column<int>(nullable: false),
                    IdContactoA = table.Column<int>(nullable: false),
                    CostoA = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PrecioA = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IdCoLoader = table.Column<int>(nullable: false),
                    IdContactoCL = table.Column<int>(nullable: false),
                    CostoCL = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PrecioCL = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TravelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicios_Viajes_TravelId",
                        column: x => x.TravelId,
                        principalTable: "Viajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEquipo = table.Column<int>(nullable: false),
                    ServicesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unidades_Servicios_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_TravelId",
                table: "Servicios",
                column: "TravelId");

            migrationBuilder.CreateIndex(
                name: "IX_Unidades_ServicesId",
                table: "Unidades",
                column: "ServicesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Unidades");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Viajes");
        }
    }
}
