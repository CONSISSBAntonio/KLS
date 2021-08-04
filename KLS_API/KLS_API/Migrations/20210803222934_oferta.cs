using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class oferta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "idInventario",
            //    table: "ruta_has_inventario");

            //migrationBuilder.DropColumn(
            //    name: "idRuta",
            //    table: "ruta_has_inventario");

            //migrationBuilder.RenameColumn(
            //    name: "id",
            //    table: "ruta_has_inventario",
            //    newName: "Id");

            //migrationBuilder.AddColumn<int>(
            //    name: "Id_Inventario",
            //    table: "ruta_has_inventario",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<int>(
            //    name: "Id_Tr_Has_Rutas",
            //    table: "ruta_has_inventario",
            //    nullable: false,
            //    defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Oferta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Transportista = table.Column<int>(nullable: false),
                    Tipo_De_Unidad = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Fecha_Disponibilidad = table.Column<string>(type: "varchar(25)", nullable: true),
                    Rango_De_Espera = table.Column<int>(nullable: false),
                    Nivel_Origen = table.Column<string>(type: "varchar(20)", nullable: false),
                    Region_Origen = table.Column<int>(nullable: false),
                    Estado_Origen = table.Column<int>(nullable: false),
                    ciudad_Origen = table.Column<int>(nullable: false),
                    Tolerancia_Origen = table.Column<int>(nullable: false),
                    Nivel_Destino = table.Column<int>(nullable: false),
                    Region_Destino = table.Column<int>(nullable: false),
                    estado_Destino = table.Column<int>(nullable: false),
                    ciudad_Destino = table.Column<int>(nullable: false),
                    Tolerancia_Destino = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oferta", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oferta");

            //migrationBuilder.DropColumn(
            //    name: "Id_Inventario",
            //    table: "ruta_has_inventario");

            //migrationBuilder.DropColumn(
            //    name: "Id_Tr_Has_Rutas",
            //    table: "ruta_has_inventario");

            //migrationBuilder.RenameColumn(
            //    name: "Id",
            //    table: "ruta_has_inventario",
            //    newName: "id");

            //migrationBuilder.AddColumn<int>(
            //    name: "idInventario",
            //    table: "ruta_has_inventario",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<int>(
            //    name: "idRuta",
            //    table: "ruta_has_inventario",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);
        }
    }
}
