using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class facturacionfkupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturacion_Travels_TravelId",
                table: "Facturacion");

            migrationBuilder.DropIndex(
                name: "IX_Facturacion_TravelId",
                table: "Facturacion");

            migrationBuilder.DropColumn(
                name: "TravelId",
                table: "Facturacion");

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "Facturacion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Facturacion_SectionId",
                table: "Facturacion",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturacion_Sections_SectionId",
                table: "Facturacion",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturacion_Sections_SectionId",
                table: "Facturacion");

            migrationBuilder.DropIndex(
                name: "IX_Facturacion_SectionId",
                table: "Facturacion");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "Facturacion");

            migrationBuilder.AddColumn<int>(
                name: "TravelId",
                table: "Facturacion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Facturacion_TravelId",
                table: "Facturacion",
                column: "TravelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturacion_Travels_TravelId",
                table: "Facturacion",
                column: "TravelId",
                principalTable: "Travels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
