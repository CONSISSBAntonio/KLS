using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class relRutas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tr_Has_Rutas",
                table: "Tr_Has_Rutas");

            migrationBuilder.RenameTable(
                name: "Tr_Has_Rutas",
                newName: "Tr_Has_Ruta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tr_Has_Ruta",
                table: "Tr_Has_Ruta",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ruta_has_inventario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idRuta = table.Column<int>(nullable: false),
                    idInventario = table.Column<int>(nullable: false),
                    Tr_Has_RutaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ruta_has_inventario", x => x.id);
                    table.ForeignKey(
                        name: "FK_ruta_has_inventario_Tr_Has_Ruta_Tr_Has_RutaId",
                        column: x => x.Tr_Has_RutaId,
                        principalTable: "Tr_Has_Ruta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ruta_has_inventario_Tr_Has_RutaId",
                table: "ruta_has_inventario",
                column: "Tr_Has_RutaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ruta_has_inventario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tr_Has_Ruta",
                table: "Tr_Has_Ruta");

            migrationBuilder.RenameTable(
                name: "Tr_Has_Ruta",
                newName: "Tr_Has_Rutas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tr_Has_Rutas",
                table: "Tr_Has_Rutas",
                column: "Id");
        }
    }
}
