using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class trOperadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tr_Has_Operadores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Transportista = table.Column<int>(nullable: false),
                    Imss = table.Column<string>(type: "varchar(25)", nullable: true),
                    NoLicencia = table.Column<string>(type: "varchar(25)", nullable: true),
                    NoTelefono = table.Column<string>(type: "varchar(15)", nullable: false),
                    SeguroSocial = table.Column<string>(type: "varchar(25)", nullable: true),
                    estatus = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Operadores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tr_Has_Operadores");
        }
    }
}
