using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class Requisitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cl_Has_Requisitos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    ContarAlarma = table.Column<bool>(nullable: false),
                    ContarAlarma_ = table.Column<bool>(nullable: false),
                    EquipoCovid = table.Column<bool>(nullable: false),
                    EquipoCovid_ = table.Column<bool>(nullable: false),
                    EquipoSeguridad = table.Column<bool>(nullable: false),
                    EquipoSeguridad_ = table.Column<bool>(nullable: false),
                    Instruccion = table.Column<bool>(nullable: false),
                    IntruccionDescarga = table.Column<bool>(nullable: false),
                    LlevarCertificado = table.Column<bool>(nullable: false),
                    LlevarCertificado_ = table.Column<bool>(nullable: false),
                    LlevarGatas = table.Column<bool>(nullable: false),
                    LlevarGatas_ = table.Column<bool>(nullable: false),
                    LlevarIne = table.Column<bool>(nullable: false),
                    LlevarIne_ = table.Column<bool>(nullable: false),
                    LlevarLicencia = table.Column<bool>(nullable: false),
                    LlevarLicencia_ = table.Column<bool>(nullable: false),
                    LlevarPoliza = table.Column<bool>(nullable: false),
                    LlevarPoliza_ = table.Column<bool>(nullable: false),
                    LlevarSua = table.Column<bool>(nullable: false),
                    LlevarSua_ = table.Column<bool>(nullable: false),
                    LlevarTarjeta = table.Column<bool>(nullable: false),
                    LlevarTarjeta_ = table.Column<bool>(nullable: false),
                    LlevarTodos_ = table.Column<bool>(nullable: false),
                    PresentarseMin_ = table.Column<bool>(nullable: false),
                    UnidadCondiciones = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Requisitos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cl_Has_Requisitos");
        }
    }
}
