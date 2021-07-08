using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class clientsCertifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cl_Has_Certificacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    Ctpat = table.Column<bool>(nullable: false),
                    Otro = table.Column<bool>(nullable: false),
                    C_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    O_Opcional = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Certificacion", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cl_Has_Certificacion");
        }
    }
}
