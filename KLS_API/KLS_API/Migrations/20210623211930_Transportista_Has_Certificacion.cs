using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class Transportista_Has_Certificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tr_Has_Certificacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Transportista = table.Column<int>(nullable: false),
                    Ctpat = table.Column<bool>(nullable: false),
                    Otro = table.Column<bool>(nullable: false),
                    C_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    O_Opcional = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Certificacion", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tr_Has_Certificacion");
        }
    }
}
