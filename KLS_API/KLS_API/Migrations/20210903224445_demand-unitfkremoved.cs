using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class demandunitfkremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demands_Cat_Tipos_Unidades_UnitId",
                table: "Demands");

            migrationBuilder.DropIndex(
                name: "IX_Demands_UnitId",
                table: "Demands");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Demands");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Demands",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TravelServiceId",
                table: "Demands",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Demands_TravelServiceId",
                table: "Demands",
                column: "TravelServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demands_TravelServices_TravelServiceId",
                table: "Demands",
                column: "TravelServiceId",
                principalTable: "TravelServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demands_TravelServices_TravelServiceId",
                table: "Demands");

            migrationBuilder.DropIndex(
                name: "IX_Demands_TravelServiceId",
                table: "Demands");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Demands");

            migrationBuilder.DropColumn(
                name: "TravelServiceId",
                table: "Demands");

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Demands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Demands_UnitId",
                table: "Demands",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demands_Cat_Tipos_Unidades_UnitId",
                table: "Demands",
                column: "UnitId",
                principalTable: "Cat_Tipos_Unidades",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
