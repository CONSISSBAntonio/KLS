using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class sectioncommentfkstatusrm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionComments_Statuses_StatusId",
                table: "SectionComments");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionLogs_Sections_SectionId",
                table: "SectionLogs");

            migrationBuilder.DropIndex(
                name: "IX_SectionLogs_SectionId",
                table: "SectionLogs");

            migrationBuilder.DropIndex(
                name: "IX_SectionComments_StatusId",
                table: "SectionComments");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "SectionComments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "SectionComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SectionLogs_SectionId",
                table: "SectionLogs",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionComments_StatusId",
                table: "SectionComments",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionComments_Statuses_StatusId",
                table: "SectionComments",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionLogs_Sections_SectionId",
                table: "SectionLogs",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
