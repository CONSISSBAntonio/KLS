using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class tiposUnidadesDecimales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "rendimiento",
                table: "Cat_Tipos_Unidades",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "mantenimiento",
                table: "Cat_Tipos_Unidades",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "llantas",
                table: "Cat_Tipos_Unidades",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "litros",
                table: "Cat_Tipos_Unidades",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "limite_peso",
                table: "Cat_Tipos_Unidades",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "rendimiento",
                table: "Cat_Tipos_Unidades",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "mantenimiento",
                table: "Cat_Tipos_Unidades",
                type: "decimal(2,2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "llantas",
                table: "Cat_Tipos_Unidades",
                type: "decimal(2,2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "litros",
                table: "Cat_Tipos_Unidades",
                type: "decimal(2,2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "limite_peso",
                table: "Cat_Tipos_Unidades",
                type: "decimal(3,2)",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
