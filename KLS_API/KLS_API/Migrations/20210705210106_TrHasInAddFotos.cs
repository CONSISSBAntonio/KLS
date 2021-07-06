using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class TrHasInAddFotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoPoliza",
                table: "Tr_Has_Inventario",
                type: "varchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoUnidad",
                table: "Tr_Has_Inventario",
                type: "varchar(250)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoPoliza",
                table: "Tr_Has_Inventario");

            migrationBuilder.DropColumn(
                name: "FotoUnidad",
                table: "Tr_Has_Inventario");
        }
    }
}
