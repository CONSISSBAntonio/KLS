using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class tr_Rutas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ruta_has_inventario_Tr_Has_Ruta_Tr_Has_RutaId",
                table: "ruta_has_inventario");

            migrationBuilder.DropColumn(
                name: "Id_Tr_Has_Rutas",
                table: "ruta_has_inventario");

            migrationBuilder.AlterColumn<int>(
                name: "Tr_Has_RutaId",
                table: "ruta_has_inventario",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Costo",
                table: "ruta_has_inventario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ruta_has_inventario_Tr_Has_Ruta_Tr_Has_RutaId",
                table: "ruta_has_inventario",
                column: "Tr_Has_RutaId",
                principalTable: "Tr_Has_Ruta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ruta_has_inventario_Tr_Has_Ruta_Tr_Has_RutaId",
                table: "ruta_has_inventario");

            migrationBuilder.DropColumn(
                name: "Costo",
                table: "ruta_has_inventario");

            migrationBuilder.AlterColumn<int>(
                name: "Tr_Has_RutaId",
                table: "ruta_has_inventario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id_Tr_Has_Rutas",
                table: "ruta_has_inventario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ruta_has_inventario_Tr_Has_Ruta_Tr_Has_RutaId",
                table: "ruta_has_inventario",
                column: "Tr_Has_RutaId",
                principalTable: "Tr_Has_Ruta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
