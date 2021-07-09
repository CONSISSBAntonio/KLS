using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class clienteOtros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cl_Has_Otros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<bool>(nullable: false),
                    Mandatario1 = table.Column<bool>(nullable: false),
                    Mandatario2 = table.Column<bool>(nullable: false),
                    Mandatario3 = table.Column<bool>(nullable: false),
                    Referencia1 = table.Column<bool>(nullable: false),
                    Referencia2 = table.Column<bool>(nullable: false),
                    Referencia3 = table.Column<bool>(nullable: false),
                    Treferencia1 = table.Column<string>(type: "varchar(55)", nullable: false),
                    Treferencia2 = table.Column<string>(type: "varchar(55)", nullable: false),
                    Treferencia3 = table.Column<string>(type: "varchar(55)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Otros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cl_Has_Otros");
        }
    }
}
