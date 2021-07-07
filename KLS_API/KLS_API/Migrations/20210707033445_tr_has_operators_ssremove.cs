using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class tr_has_operators_ssremove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeguroSocial",
                table: "Tr_Has_Operadores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SeguroSocial",
                table: "Tr_Has_Operadores",
                type: "varchar(25)",
                nullable: true);
        }
    }
}
