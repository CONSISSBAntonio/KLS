using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class clientsBox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cl_Has_Box",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Custodia = table.Column<bool>(nullable: false),
                    D_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    Densidad = table.Column<bool>(nullable: false),
                    Derramable = table.Column<bool>(nullable: false),
                    Id_Cliente = table.Column<int>(nullable: false),
                    M_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    Material = table.Column<bool>(nullable: false),
                    Notas = table.Column<string>(type: "varchar(255)", nullable: true),
                    OlorPenetrante = table.Column<bool>(nullable: false),
                    Peligroso = table.Column<bool>(nullable: false),
                    TipoPresentacion = table.Column<bool>(nullable: false),
                    Tp_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    V_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    Valor = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Box", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cl_Has_Box");
        }
    }
}
