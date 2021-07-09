using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class clienteOtrosstring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Treferencia3",
                table: "Cl_Has_Otros",
                type: "varchar(55)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(55)");

            migrationBuilder.AlterColumn<string>(
                name: "Treferencia2",
                table: "Cl_Has_Otros",
                type: "varchar(55)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(55)");

            migrationBuilder.AlterColumn<string>(
                name: "Treferencia1",
                table: "Cl_Has_Otros",
                type: "varchar(55)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(55)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Treferencia3",
                table: "Cl_Has_Otros",
                type: "varchar(55)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(55)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Treferencia2",
                table: "Cl_Has_Otros",
                type: "varchar(55)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(55)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Treferencia1",
                table: "Cl_Has_Otros",
                type: "varchar(55)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(55)",
                oldNullable: true);
        }
    }
}
