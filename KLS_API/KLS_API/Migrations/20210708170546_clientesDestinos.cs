using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class clientesDestinos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cl_Has_Destinos",
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
                    table.PrimaryKey("PK_Cl_Has_Destinos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cl_Has_Destinos");
        }
    }
}
