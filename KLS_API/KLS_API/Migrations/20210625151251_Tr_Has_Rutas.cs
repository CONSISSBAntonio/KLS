using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class Tr_Has_Rutas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tr_Has_Rutas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Transportista = table.Column<int>(nullable: false),
                    Id_Estado_Origen = table.Column<int>(nullable: false),
                    Id_Ciudad_Origen = table.Column<int>(nullable: false),
                    Id_Estado_Destino = table.Column<int>(nullable: false),
                    Id_Ciudad_Destino = table.Column<int>(nullable: false),
                    Total_Kilometros = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    Eficiencia = table.Column<int>(nullable: false),
                    TotalHoras = table.Column<int>(nullable: false),
                    Seguridad = table.Column<int>(nullable: false),
                    Demanda = table.Column<int>(nullable: false),
                    Restriccion = table.Column<string>(type: "varchar(25)", nullable: true),
                    TipoDeViaje = table.Column<int>(nullable: false),
                    Estatus = table.Column<int>(nullable: false),
                    FrecValidacion = table.Column<string>(type: "varchar(25)", nullable: true),
                    RestriccionCircuito = table.Column<string>(type: "varchar(25)", nullable: true),
                    Observacion = table.Column<string>(type: "varchar(85)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Rutas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tr_Has_Rutas");
        }
    }
}
