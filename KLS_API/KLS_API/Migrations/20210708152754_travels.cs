using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class travels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Viajes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Folio = table.Column<string>(nullable: true),
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
                    CostoTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PrecioClienteTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Estatus = table.Column<string>(nullable: true),
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
                name: "Facturacion",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TravelId = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(type: "VARCHAR(300)", nullable: true),
                    fullpath = table.Column<string>(nullable: true),
                    fechacarga = table.Column<DateTime>(nullable: false),
                    usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturacion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Facturacion_Viajes_TravelId",
                        column: x => x.TravelId,
                        principalTable: "Viajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TravelId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    IdTransportista = table.Column<int>(nullable: false),
                    IdChofer = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IdNaviera = table.Column<int>(nullable: false),
                    Buque = table.Column<string>(nullable: true),
                    IdAgenteAduanal = table.Column<int>(nullable: false),
                    IdContactoAA = table.Column<int>(nullable: false),
                    IdAerolinea = table.Column<int>(nullable: false),
                    IdContactoA = table.Column<int>(nullable: false),
                    IdCoLoader = table.Column<int>(nullable: false),
                    IdContactoCL = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicios_Viajes_TravelId",
                        column: x => x.TravelId,
                        principalTable: "Viajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Facturacion_TravelId",
                table: "Facturacion",
                column: "TravelId");

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
                name: "Facturacion");

            migrationBuilder.DropTable(
                name: "Unidades");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Viajes");
        }
    }
}
