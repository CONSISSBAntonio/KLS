using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class offersectionidfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "Oferta",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Oferta_SectionId",
                table: "Oferta",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oferta_Sections_SectionId",
                table: "Oferta",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oferta_Sections_SectionId",
                table: "Oferta");

            migrationBuilder.DropIndex(
                name: "IX_Oferta_SectionId",
                table: "Oferta");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "Oferta");
        }
    }
}
