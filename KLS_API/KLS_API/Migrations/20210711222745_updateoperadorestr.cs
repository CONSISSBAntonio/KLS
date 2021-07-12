using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class updateoperadorestr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "usuarioId",
            //    table: "Facturacion");

            migrationBuilder.AlterColumn<string>(
                name: "NoTelefono",
                table: "Tr_Has_Operadores",
                type: "varchar(15)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            //migrationBuilder.AddColumn<int>(
            //    name: "TravelId",
            //    table: "Facturacion",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Facturacion_TravelId",
            //    table: "Facturacion",
            //    column: "TravelId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Facturacion_Viajes_TravelId",
            //    table: "Facturacion",
            //    column: "TravelId",
            //    principalTable: "Viajes",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Facturacion_Viajes_TravelId",
            //    table: "Facturacion");

            //migrationBuilder.DropIndex(
            //    name: "IX_Facturacion_TravelId",
            //    table: "Facturacion");

            //migrationBuilder.DropColumn(
            //    name: "TravelId",
            //    table: "Facturacion");

            migrationBuilder.AlterColumn<int>(
                name: "NoTelefono",
                table: "Tr_Has_Operadores",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldNullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "usuarioId",
            //    table: "Facturacion",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);
        }
    }
}
