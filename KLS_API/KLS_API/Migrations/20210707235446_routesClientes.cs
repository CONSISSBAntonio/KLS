using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class routesClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "Estatus",
            //    table: "Viajes",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Folio",
            //    table: "Viajes",
            //    nullable: true);

            migrationBuilder.CreateTable(
                name: "Cl_Has_Routes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    Monitoreable = table.Column<bool>(nullable: false),
                    Estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Routes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cl_Has_Routes");

            migrationBuilder.DropColumn(
                name: "Estatus",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "Folio",
                table: "Viajes");
        }
    }
}
