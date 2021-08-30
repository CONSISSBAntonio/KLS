using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class maintravel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainTravelId",
                table: "Viajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MainTravels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ServiceId = table.Column<string>(nullable: true),
                    Ejecutivo = table.Column<string>(nullable: true),
                    GrupoMonitor = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainTravels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Viajes_MainTravelId",
                table: "Viajes",
                column: "MainTravelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Viajes_MainTravels_MainTravelId",
                table: "Viajes",
                column: "MainTravelId",
                principalTable: "MainTravels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Viajes_MainTravels_MainTravelId",
                table: "Viajes");

            migrationBuilder.DropTable(
                name: "MainTravels");

            migrationBuilder.DropIndex(
                name: "IX_Viajes_MainTravelId",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "MainTravelId",
                table: "Viajes");
        }
    }
}
