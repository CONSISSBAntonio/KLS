using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class clientesParams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "Comentario",
                table: "Clientes",
                type: "varchar(55)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ejecutivo",
                table: "Clientes",
                type: "varchar(55)",
                nullable: true);

            //migrationBuilder.CreateTable(
            //    name: "Mercancias",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        TravelId = table.Column<int>(nullable: false),
            //        Alto = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
            //        Ancho = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
            //        Largo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
            //        Peso = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
            //        PesoVolumetrico = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Mercancias", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Mercancias_Viajes_TravelId",
            //            column: x => x.TravelId,
            //            principalTable: "Viajes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Mercancias_TravelId",
            //    table: "Mercancias",
            //    column: "TravelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mercancias");

            migrationBuilder.DropColumn(
                name: "Comentario",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Ejecutivo",
                table: "Clientes");
        }
    }
}
