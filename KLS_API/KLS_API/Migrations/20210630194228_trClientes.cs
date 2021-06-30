using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class trClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreComercial = table.Column<string>(type: "varchar(55)", nullable: true),
                    NombreCorto = table.Column<string>(type: "varchar(55)", nullable: true),
                    RazonSocial = table.Column<string>(type: "varchar(55)", nullable: true),
                    Rfc = table.Column<string>(type: "varchar(55)", nullable: true),
                    DireccionFiscal = table.Column<string>(type: "varchar(55)", nullable: true),
                    Sector = table.Column<string>(type: "varchar(55)", nullable: true),
                    InegiDenue = table.Column<string>(type: "varchar(55)", nullable: true),
                    Industria = table.Column<string>(type: "varchar(55)", nullable: true),
                    Tamanio = table.Column<string>(type: "varchar(55)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    PaginaWeb = table.Column<string>(type: "varchar(55)", nullable: true),
                    Facebook = table.Column<string>(type: "varchar(55)", nullable: true),
                    OtraRed = table.Column<string>(type: "varchar(55)", nullable: true),
                    Banco = table.Column<string>(type: "varchar(55)", nullable: true),
                    Cuenta = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
