using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KLS_API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Aerolinea",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    departamento = table.Column<string>(nullable: true),
                    contactos = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    estatus = table.Column<int>(nullable: false),
                    almacen = table.Column<string>(nullable: true),
                    notas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Aerolinea", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Agentes_Aduanales",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    departamento = table.Column<string>(nullable: true),
                    contacto = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    estatus = table.Column<int>(nullable: false),
                    notas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Agentes_Aduanales", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Ciudad",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_pais = table.Column<int>(nullable: false),
                    id_estado = table.Column<int>(nullable: false),
                    id_sepomex = table.Column<string>(type: "varchar(10)", nullable: true),
                    nombre = table.Column<string>(type: "varchar(35)", nullable: true),
                    estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Ciudad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Coloaders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    direccion = table.Column<string>(type: "varchar(80)", nullable: true),
                    telefono = table.Column<string>(type: "varchar(40)", nullable: true),
                    departamento = table.Column<string>(type: "varchar(20)", nullable: true),
                    contacto = table.Column<string>(type: "varchar(70)", nullable: true),
                    correo = table.Column<string>(type: "varchar(55)", nullable: true),
                    estatus = table.Column<int>(nullable: false),
                    notas = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Coloaders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Colonia",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_estado = table.Column<int>(nullable: false),
                    id_ciudad = table.Column<int>(nullable: false),
                    cp = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Colonia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Estado",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_pais = table.Column<int>(nullable: false),
                    id_sepomex = table.Column<string>(type: "varchar(10)", nullable: true),
                    nombre = table.Column<string>(type: "varchar(30)", nullable: true),
                    estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Estado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Navieras",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    departamento = table.Column<string>(nullable: true),
                    contacto = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    estatus = table.Column<int>(nullable: false),
                    notas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Navieras", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Pais",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pais = table.Column<string>(type: "varchar(28)", nullable: true),
                    estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Pais", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Region",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(10)", nullable: true),
                    estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Region", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Subservicios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    servicio = table.Column<string>(nullable: true),
                    estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Subservicios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Terrestres_Internacionales",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    departamento = table.Column<string>(nullable: true),
                    contacto = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    estatus = table.Column<int>(nullable: false),
                    notas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Terrestres_Internacionales", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cat_Tipos_Unidades",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    ejes = table.Column<int>(nullable: false),
                    estatus = table.Column<int>(nullable: false),
                    mantenimiento = table.Column<decimal>(nullable: false),
                    llantas = table.Column<decimal>(nullable: false),
                    litros = table.Column<decimal>(nullable: false),
                    rendimiento = table.Column<decimal>(nullable: false),
                    limite_peso = table.Column<decimal>(nullable: false),
                    limite_volumen = table.Column<string>(type: "Varchar(35)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Tipos_Unidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ruta",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_estadoorigen = table.Column<int>(nullable: false),
                    id_ciudadorigen = table.Column<int>(nullable: false),
                    id_estadodestino = table.Column<int>(nullable: false),
                    id_ciudaddestino = table.Column<int>(nullable: false),
                    totalkilometros = table.Column<int>(nullable: false),
                    eficiencia = table.Column<string>(type: "varchar(20)", nullable: true),
                    totalhoras = table.Column<string>(type: "varchar(20)", nullable: true),
                    seguridad = table.Column<string>(type: "varchar(20)", nullable: true),
                    demanda = table.Column<string>(type: "varchar(20)", nullable: true),
                    tipodeviaje = table.Column<string>(type: "varchar(20)", nullable: true),
                    estatus = table.Column<int>(nullable: false),
                    frecvalidacion = table.Column<string>(type: "varchar(100)", nullable: true),
                    restriccioncirc = table.Column<string>(type: "varchar(100)", nullable: true),
                    observaciones = table.Column<string>(type: "text", nullable: true),
                    actualizadopor = table.Column<string>(type: "varchar(100)", nullable: true),
                    ultimocambio = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ruta_Has_Checkpoint",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RutaId = table.Column<int>(nullable: false),
                    Cat_CiudadId = table.Column<int>(nullable: false),
                    tiempo = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruta_Has_Checkpoint", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tr_Has_Biblioteca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Transportista = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "varchar(55)", nullable: true),
                    Estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Biblioteca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tr_Has_Box",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Custodia = table.Column<bool>(nullable: false),
                    D_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    Densidad = table.Column<bool>(nullable: false),
                    Derramable = table.Column<bool>(nullable: false),
                    Id_Transportista = table.Column<int>(nullable: false),
                    M_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    Material = table.Column<bool>(nullable: false),
                    Notas = table.Column<string>(type: "varchar(255)", nullable: false),
                    OlorPenetrante = table.Column<bool>(nullable: false),
                    Peligroso = table.Column<bool>(nullable: false),
                    TipoPresentacion = table.Column<bool>(nullable: false),
                    Tp_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    V_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    Valor = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Box", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tr_Has_Certificacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Transportista = table.Column<int>(nullable: false),
                    Ctpat = table.Column<bool>(nullable: false),
                    Otro = table.Column<bool>(nullable: false),
                    C_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    O_Opcional = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Certificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tr_Has_Contactos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Transportista = table.Column<int>(nullable: false),
                    TipoContacto = table.Column<string>(type: "varchar(25)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(55)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(35)", nullable: true),
                    Correo = table.Column<string>(type: "varchar(55)", nullable: true),
                    Estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Contactos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tr_Has_Rutas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Ruta = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    Estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Rutas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transportista",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreComercial = table.Column<string>(type: "varchar(55)", nullable: true),
                    Tamanio = table.Column<string>(type: "varchar(22)", nullable: true),
                    Servicio = table.Column<string>(type: "varchar(15)", nullable: true),
                    GradoConfiabilidad = table.Column<string>(type: "varchar(15)", nullable: true),
                    NivelServicio = table.Column<int>(nullable: false),
                    Comentario = table.Column<string>(type: "varchar(100)", nullable: true),
                    FechaUltimoViaje = table.Column<string>(type: "varchar(20)", nullable: true),
                    RazonSocial = table.Column<string>(type: "varchar(100)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    Rfc = table.Column<string>(type: "varchar(25)", nullable: true),
                    DireccionFiscal = table.Column<string>(type: "varchar(250)", nullable: true),
                    DireccionOficinas = table.Column<string>(type: "varchar(250)", nullable: true),
                    DireccionPatio = table.Column<string>(type: "varchar(250)", nullable: true),
                    GoogleMaps = table.Column<string>(type: "varchar(250)", nullable: true),
                    PaginaWeb = table.Column<string>(type: "varchar(250)", nullable: true),
                    Facebook = table.Column<string>(type: "varchar(250)", nullable: true),
                    OtraRed = table.Column<string>(type: "varchar(250)", nullable: true),
                    Banco = table.Column<string>(type: "varchar(90)", nullable: true),
                    Cuenta = table.Column<string>(type: "varchar(25)", nullable: true),
                    UsuarioMaster = table.Column<string>(type: "varchar(35)", nullable: true),
                    Contrasena = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportista", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Region_Has_Estado",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cat_RegionId = table.Column<int>(nullable: false),
                    id_estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region_Has_Estado", x => x.id);
                    table.ForeignKey(
                        name: "FK_Region_Has_Estado_Cat_Region_Cat_RegionId",
                        column: x => x.Cat_RegionId,
                        principalTable: "Cat_Region",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Region_Has_Estado_Cat_RegionId",
                table: "Region_Has_Estado",
                column: "Cat_RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cat_Aerolinea");

            migrationBuilder.DropTable(
                name: "Cat_Agentes_Aduanales");

            migrationBuilder.DropTable(
                name: "Cat_Ciudad");

            migrationBuilder.DropTable(
                name: "Cat_Coloaders");

            migrationBuilder.DropTable(
                name: "Cat_Colonia");

            migrationBuilder.DropTable(
                name: "Cat_Estado");

            migrationBuilder.DropTable(
                name: "Cat_Navieras");

            migrationBuilder.DropTable(
                name: "Cat_Pais");

            migrationBuilder.DropTable(
                name: "Cat_Subservicios");

            migrationBuilder.DropTable(
                name: "Cat_Terrestres_Internacionales");

            migrationBuilder.DropTable(
                name: "Cat_Tipos_Unidades");

            migrationBuilder.DropTable(
                name: "Region_Has_Estado");

            migrationBuilder.DropTable(
                name: "Ruta");

            migrationBuilder.DropTable(
                name: "Ruta_Has_Checkpoint");

            migrationBuilder.DropTable(
                name: "Tr_Has_Biblioteca");

            migrationBuilder.DropTable(
                name: "Tr_Has_Box");

            migrationBuilder.DropTable(
                name: "Tr_Has_Certificacion");

            migrationBuilder.DropTable(
                name: "Tr_Has_Contactos");

            migrationBuilder.DropTable(
                name: "Tr_Has_Rutas");

            migrationBuilder.DropTable(
                name: "Transportista");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cat_Region");
        }
    }
}
