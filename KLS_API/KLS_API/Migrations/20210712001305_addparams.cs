using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class addparams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Amaterno",
                table: "AspNetUsers",
                type: "varchar(25)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apaterno",
                table: "AspNetUsers",
                type: "varchar(25)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "AspNetUsers",
                type: "varchar(25)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amaterno",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Apaterno",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "AspNetUsers");
        }
    }
}
