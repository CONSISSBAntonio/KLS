using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class rmcatunidadtravel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travels_Cat_Tipos_Unidades_Cat_Tipos_UnidadesId",
                table: "Travels");

            migrationBuilder.DropIndex(
                name: "IX_Travels_Cat_Tipos_UnidadesId",
                table: "Travels");

            migrationBuilder.DropColumn(
                name: "Cat_Tipos_UnidadesId",
                table: "Travels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cat_Tipos_UnidadesId",
                table: "Travels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Travels_Cat_Tipos_UnidadesId",
                table: "Travels",
                column: "Cat_Tipos_UnidadesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Travels_Cat_Tipos_Unidades_Cat_Tipos_UnidadesId",
                table: "Travels",
                column: "Cat_Tipos_UnidadesId",
                principalTable: "Cat_Tipos_Unidades",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
