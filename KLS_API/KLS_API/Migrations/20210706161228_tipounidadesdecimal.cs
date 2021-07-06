using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class tipounidadesdecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TipoUnidad",
                table: "Tr_Has_Inventario",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "rendimiento",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(11,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "mantenimiento",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(11,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "llantas",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(11,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "litros",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(11,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "limite_peso",
                table: "Cat_Tipos_Unidades",
                type: "Decimal(11,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TipoUnidad",
                table: "Tr_Has_Inventario",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "rendimiento",
                table: "Cat_Tipos_Unidades",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(11,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "mantenimiento",
                table: "Cat_Tipos_Unidades",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(11,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "llantas",
                table: "Cat_Tipos_Unidades",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(11,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "litros",
                table: "Cat_Tipos_Unidades",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(11,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "limite_peso",
                table: "Cat_Tipos_Unidades",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(11,4)");
        }
    }
}
