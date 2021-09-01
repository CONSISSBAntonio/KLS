using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class sectionfknullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Cl_Has_Destinos_Cl_Has_DestinosId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Cl_Has_Origen_Cl_Has_OrigenId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Cl_Has_Otros_Cl_Has_OtrosId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Clientes_ClientesId",
                table: "Sections");

            migrationBuilder.AlterColumn<int>(
                name: "ClientesId",
                table: "Sections",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Cl_Has_OtrosId",
                table: "Sections",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Cl_Has_OrigenId",
                table: "Sections",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Cl_Has_DestinosId",
                table: "Sections",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Cl_Has_Destinos_Cl_Has_DestinosId",
                table: "Sections",
                column: "Cl_Has_DestinosId",
                principalTable: "Cl_Has_Destinos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Cl_Has_Origen_Cl_Has_OrigenId",
                table: "Sections",
                column: "Cl_Has_OrigenId",
                principalTable: "Cl_Has_Origen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Cl_Has_Otros_Cl_Has_OtrosId",
                table: "Sections",
                column: "Cl_Has_OtrosId",
                principalTable: "Cl_Has_Otros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Clientes_ClientesId",
                table: "Sections",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Cl_Has_Destinos_Cl_Has_DestinosId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Cl_Has_Origen_Cl_Has_OrigenId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Cl_Has_Otros_Cl_Has_OtrosId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Clientes_ClientesId",
                table: "Sections");

            migrationBuilder.AlterColumn<int>(
                name: "ClientesId",
                table: "Sections",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cl_Has_OtrosId",
                table: "Sections",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cl_Has_OrigenId",
                table: "Sections",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cl_Has_DestinosId",
                table: "Sections",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Cl_Has_Destinos_Cl_Has_DestinosId",
                table: "Sections",
                column: "Cl_Has_DestinosId",
                principalTable: "Cl_Has_Destinos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Cl_Has_Origen_Cl_Has_OrigenId",
                table: "Sections",
                column: "Cl_Has_OrigenId",
                principalTable: "Cl_Has_Origen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Cl_Has_Otros_Cl_Has_OtrosId",
                table: "Sections",
                column: "Cl_Has_OtrosId",
                principalTable: "Cl_Has_Otros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Clientes_ClientesId",
                table: "Sections",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
