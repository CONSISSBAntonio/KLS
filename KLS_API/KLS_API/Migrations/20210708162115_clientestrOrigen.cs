using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class clientestrOrigen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Servicios_Viajes_TravelId",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "CostoA",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "CostoAA",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "CostoCL",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "CostoN",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "CostoTI",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "CostoTotal",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "IdTravel",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "PrecioA",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "PrecioAA",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "PrecioCL",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "PrecioClienteTotal",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "PrecioN",
            //    table: "Servicios");

            //migrationBuilder.DropColumn(
            //    name: "PrecioTI",
            //    table: "Servicios");

            //migrationBuilder.AddColumn<decimal>(
            //    name: "CostoTotal",
            //    table: "Viajes",
            //    type: "decimal(18,4)",
            //    nullable: false,
            //    defaultValue: 0m);

            //migrationBuilder.AddColumn<decimal>(
            //    name: "PrecioClienteTotal",
            //    table: "Viajes",
            //    type: "decimal(18,4)",
            //    nullable: false,
            //    defaultValue: 0m);

            //migrationBuilder.AlterColumn<int>(
            //    name: "TravelId",
            //    table: "Servicios",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Cl_Has_Origen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "varchar(55)", nullable: true),
                    Cp = table.Column<int>(nullable: false),
                    Id_Estado = table.Column<int>(nullable: false),
                    Id_Ciudad = table.Column<int>(nullable: false),
                    Id_Colonia = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(type: "varchar(120)", nullable: true),
                    Estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Origen", x => x.Id);
                });

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Servicios_Viajes_TravelId",
            //    table: "Servicios",
            //    column: "TravelId",
            //    principalTable: "Viajes",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Viajes_TravelId",
                table: "Servicios");

            migrationBuilder.DropTable(
                name: "Cl_Has_Origen");

            migrationBuilder.DropColumn(
                name: "CostoTotal",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "PrecioClienteTotal",
                table: "Viajes");

            migrationBuilder.AlterColumn<int>(
                name: "TravelId",
                table: "Servicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<decimal>(
                name: "CostoA",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoAA",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoCL",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoN",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoTI",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostoTotal",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "IdTravel",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioA",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioAA",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioCL",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioClienteTotal",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioN",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioTI",
                table: "Servicios",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Viajes_TravelId",
                table: "Servicios",
                column: "TravelId",
                principalTable: "Viajes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
