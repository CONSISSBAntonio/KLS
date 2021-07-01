using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class trinventario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tr_Has_Inventario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Anio = table.Column<string>(type: "varchar(15)", nullable: true),
                    Capacidad = table.Column<string>(type: "varchar(35)", nullable: true),
                    Color = table.Column<string>(type: "varchar(25)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    Marca = table.Column<string>(type: "varchar(55)", nullable: true),
                    Modelo = table.Column<string>(type: "varchar(25)", nullable: true),
                    NoEconomico = table.Column<string>(type: "varchar(25)", nullable: true),
                    NoSerie = table.Column<string>(type: "varchar(25)", nullable: true),
                    Placa = table.Column<string>(type: "varchar(25)", nullable: true),
                    TipoUnidad = table.Column<string>(type: "varchar(25)", nullable: true),
                    Volumen = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Inventario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tr_Has_Inventario");
        }
    }
}
