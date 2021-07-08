using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class clientsConactos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cl_Has_Contactos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Transportista = table.Column<int>(nullable: false),
                    TipoContacto = table.Column<string>(type: "varchar(55)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(55)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(35)", nullable: true),
                    Correo = table.Column<string>(type: "varchar(55)", nullable: true),
                    Estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Contactos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cl_Has_Contactos");
        }
    }
}
