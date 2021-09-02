using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class sectionlogfkupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionLogs_Travels_TravelId",
                table: "SectionLogs");

            migrationBuilder.DropIndex(
                name: "IX_SectionLogs_TravelId",
                table: "SectionLogs");

            migrationBuilder.DropColumn(
                name: "TravelId",
                table: "SectionLogs");

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "SectionLogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SectionLogs_SectionId",
                table: "SectionLogs",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionLogs_Sections_SectionId",
                table: "SectionLogs",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionLogs_Sections_SectionId",
                table: "SectionLogs");

            migrationBuilder.DropIndex(
                name: "IX_SectionLogs_SectionId",
                table: "SectionLogs");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "SectionLogs");

            migrationBuilder.AddColumn<int>(
                name: "TravelId",
                table: "SectionLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SectionLogs_TravelId",
                table: "SectionLogs",
                column: "TravelId");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionLogs_Travels_TravelId",
                table: "SectionLogs",
                column: "TravelId",
                principalTable: "Travels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
