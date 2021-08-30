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
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "varchar(25)", nullable: true),
                    Apaterno = table.Column<string>(type: "varchar(25)", nullable: true),
                    Amaterno = table.Column<string>(type: "varchar(25)", nullable: true),
                    activo = table.Column<int>(nullable: false),
                    ResetToken = table.Column<string>(nullable: true)
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
                    mantenimiento = table.Column<decimal>(type: "Decimal(11,4)", nullable: false),
                    llantas = table.Column<decimal>(type: "Decimal(11,4)", nullable: false),
                    litros = table.Column<decimal>(type: "Decimal(11,4)", nullable: false),
                    rendimiento = table.Column<decimal>(type: "Decimal(11,4)", nullable: false),
                    limite_peso = table.Column<decimal>(type: "Decimal(11,4)", nullable: false),
                    limite_volumen = table.Column<string>(type: "Varchar(35)", nullable: true),
                    operador = table.Column<decimal>(type: "Decimal(11,4)", nullable: false),
                    administrativo = table.Column<decimal>(type: "Decimal(11,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Tipos_Unidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Biblioteca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "varchar(55)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    Archivo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ruta = table.Column<string>(type: "varchar(155)", nullable: true),
                    FechaEvento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Biblioteca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Box",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Custodia = table.Column<bool>(nullable: false),
                    D_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    Densidad = table.Column<bool>(nullable: false),
                    Derramable = table.Column<bool>(nullable: false),
                    Id_Cliente = table.Column<int>(nullable: false),
                    M_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    Material = table.Column<bool>(nullable: false),
                    Notas = table.Column<string>(type: "varchar(255)", nullable: true),
                    OlorPenetrante = table.Column<bool>(nullable: false),
                    Peligroso = table.Column<bool>(nullable: false),
                    TipoPresentacion = table.Column<bool>(nullable: false),
                    Tp_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    V_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    Valor = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Box", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Certificacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    Ctpat = table.Column<bool>(nullable: false),
                    Otro = table.Column<bool>(nullable: false),
                    C_Opcional = table.Column<string>(type: "varchar(55)", nullable: true),
                    O_Opcional = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Certificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Checkpoint",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Checkpoint = table.Column<string>(type: "varchar(30)", nullable: true),
                    Id_Ruta = table.Column<int>(nullable: false),
                    Tiempo = table.Column<int>(nullable: false),
                    Estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Checkpoint", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Contactos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    TipoContacto = table.Column<string>(type: "varchar(55)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(55)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(35)", nullable: true),
                    Correo = table.Column<string>(type: "varchar(55)", nullable: true),
                    Estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Contactos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Destinos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "varchar(55)", nullable: true),
                    Cp = table.Column<int>(nullable: false),
                    Id_Estado = table.Column<int>(nullable: false),
                    Id_Ciudad = table.Column<int>(nullable: false),
                    Id_Colonia = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(type: "varchar(120)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    HoraAtencion = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Destinos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Evidencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Estatus = table.Column<int>(nullable: false),
                    Id_Cliente = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "varchar(55)", nullable: true),
                    Tiempo_Entrega = table.Column<int>(nullable: false),
                    Fisica = table.Column<bool>(nullable: false),
                    Mandatario = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Evidencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Origen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "varchar(55)", nullable: true),
                    Cp = table.Column<int>(nullable: false),
                    Id_Estado = table.Column<int>(nullable: false),
                    Id_Ciudad = table.Column<int>(nullable: false),
                    Id_Colonia = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(type: "varchar(120)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    HoraAtencion = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Origen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Otros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    Mandatario1 = table.Column<bool>(nullable: false),
                    Mandatario2 = table.Column<bool>(nullable: false),
                    Mandatario3 = table.Column<bool>(nullable: false),
                    Referencia1 = table.Column<bool>(nullable: false),
                    Referencia2 = table.Column<bool>(nullable: false),
                    Referencia3 = table.Column<bool>(nullable: false),
                    Treferencia1 = table.Column<string>(type: "varchar(55)", nullable: true),
                    Treferencia2 = table.Column<string>(type: "varchar(55)", nullable: true),
                    Treferencia3 = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Otros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Requisitos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Cliente = table.Column<int>(nullable: false),
                    ContarAlarma = table.Column<bool>(nullable: false),
                    ContarAlarma_ = table.Column<bool>(nullable: false),
                    EquipoCovid = table.Column<bool>(nullable: false),
                    EquipoCovid_ = table.Column<bool>(nullable: false),
                    EquipoSeguridad = table.Column<bool>(nullable: false),
                    EquipoSeguridad_ = table.Column<bool>(nullable: false),
                    Instruccion = table.Column<bool>(nullable: false),
                    IntruccionDescarga = table.Column<bool>(nullable: false),
                    LlevarCertificado = table.Column<bool>(nullable: false),
                    LlevarCertificado_ = table.Column<bool>(nullable: false),
                    LlevarGatas = table.Column<bool>(nullable: false),
                    LlevarGatas_ = table.Column<bool>(nullable: false),
                    LlevarIne = table.Column<bool>(nullable: false),
                    LlevarIne_ = table.Column<bool>(nullable: false),
                    LlevarLicencia = table.Column<bool>(nullable: false),
                    LlevarLicencia_ = table.Column<bool>(nullable: false),
                    LlevarPoliza = table.Column<bool>(nullable: false),
                    LlevarPoliza_ = table.Column<bool>(nullable: false),
                    LlevarSua = table.Column<bool>(nullable: false),
                    LlevarSua_ = table.Column<bool>(nullable: false),
                    LlevarTarjeta = table.Column<bool>(nullable: false),
                    LlevarTarjeta_ = table.Column<bool>(nullable: false),
                    LlevarTodos_ = table.Column<bool>(nullable: false),
                    PresentarseMin_ = table.Column<bool>(nullable: false),
                    UnidadCondiciones = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Requisitos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cl_Has_Routes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Ruta = table.Column<int>(nullable: false),
                    Id_Cliente = table.Column<int>(nullable: false),
                    Id_Cliente_Kls = table.Column<int>(nullable: false),
                    Monitoreable = table.Column<bool>(nullable: false),
                    Estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cl_Has_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreComercial = table.Column<string>(type: "varchar(55)", nullable: true),
                    NombreCorto = table.Column<string>(type: "varchar(55)", nullable: true),
                    RazonSocial = table.Column<string>(type: "varchar(55)", nullable: true),
                    Rfc = table.Column<string>(type: "varchar(55)", nullable: true),
                    DireccionFiscal = table.Column<string>(type: "varchar(55)", nullable: true),
                    Sector = table.Column<string>(type: "varchar(55)", nullable: true),
                    InegiDenue = table.Column<string>(type: "varchar(55)", nullable: true),
                    Industria = table.Column<string>(type: "varchar(55)", nullable: true),
                    Tamanio = table.Column<string>(type: "varchar(55)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    PaginaWeb = table.Column<string>(type: "varchar(55)", nullable: true),
                    Facebook = table.Column<string>(type: "varchar(55)", nullable: true),
                    OtraRed = table.Column<string>(type: "varchar(55)", nullable: true),
                    Banco = table.Column<string>(type: "varchar(55)", nullable: true),
                    Cuenta = table.Column<string>(type: "varchar(55)", nullable: true),
                    Ejecutivo = table.Column<string>(type: "varchar(55)", nullable: true),
                    Comentario = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Oferta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Transportista = table.Column<int>(nullable: false),
                    Tipo_De_Unidad = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Fecha_Disponibilidad = table.Column<DateTime>(nullable: false),
                    Rango_De_Espera = table.Column<int>(nullable: false),
                    Nivel_Origen = table.Column<string>(type: "varchar(20)", nullable: true),
                    Region_Origen = table.Column<int>(nullable: false),
                    Estado_Origen = table.Column<int>(nullable: false),
                    ciudad_Origen = table.Column<int>(nullable: false),
                    Tolerancia_Origen = table.Column<int>(nullable: false),
                    Nivel_Destino = table.Column<string>(type: "varchar(20)", nullable: true),
                    Region_Destino = table.Column<int>(nullable: false),
                    estado_Destino = table.Column<int>(nullable: false),
                    ciudad_Destino = table.Column<int>(nullable: false),
                    Tolerancia_Destino = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oferta", x => x.Id);
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
                    Folio = table.Column<string>(nullable: true),
                    totalkilometros = table.Column<int>(nullable: false),
                    eficiencia = table.Column<int>(nullable: false),
                    tiemporuta = table.Column<int>(nullable: false),
                    seguridad = table.Column<string>(type: "varchar(20)", nullable: true),
                    demanda = table.Column<string>(type: "varchar(20)", nullable: true),
                    PrecioMinimo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PrecioMaximo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    estatus = table.Column<int>(nullable: false),
                    frecvalidacion = table.Column<int>(nullable: false),
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
                    nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    tiempo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruta_Has_Checkpoint", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SectionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Acronym = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Separar",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_oferta = table.Column<int>(nullable: false),
                    rutaTentativa = table.Column<string>(type: "varchar(120)", nullable: true),
                    notasCargo = table.Column<string>(type: "varchar(250)", nullable: true),
                    id_User = table.Column<string>(type: "varchar(250)", nullable: true),
                    nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    fecha = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Separar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tr_Has_Biblioteca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Transportista = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "varchar(55)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    Archivo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ruta = table.Column<string>(type: "varchar(155)", nullable: true),
                    FechaEvento = table.Column<DateTime>(nullable: false)
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
                    Notas = table.Column<string>(type: "varchar(255)", nullable: true),
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
                name: "Tr_Has_Inventario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdTransportista = table.Column<int>(nullable: false),
                    Anio = table.Column<string>(type: "varchar(15)", nullable: true),
                    Capacidad = table.Column<string>(type: "varchar(35)", nullable: true),
                    Color = table.Column<string>(type: "varchar(25)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    Marca = table.Column<string>(type: "varchar(55)", nullable: true),
                    Modelo = table.Column<string>(type: "varchar(25)", nullable: true),
                    NoEconomico = table.Column<string>(type: "varchar(25)", nullable: true),
                    NoSerie = table.Column<string>(type: "varchar(25)", nullable: true),
                    Placa = table.Column<string>(type: "varchar(25)", nullable: true),
                    TipoUnidad = table.Column<int>(nullable: false),
                    Volumen = table.Column<string>(type: "varchar(45)", nullable: true),
                    Ruta = table.Column<string>(type: "varchar(250)", nullable: true),
                    FotoUnidad = table.Column<string>(type: "varchar(150)", nullable: true),
                    FotoPoliza = table.Column<string>(type: "varchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Inventario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tr_Has_Operadores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Transportista = table.Column<int>(nullable: false),
                    Imss = table.Column<string>(type: "varchar(25)", nullable: true),
                    NoLicencia = table.Column<string>(type: "varchar(25)", nullable: true),
                    NoIne = table.Column<string>(type: "varchar(25)", nullable: true),
                    FotoLicencia = table.Column<string>(type: "varchar(250)", nullable: true),
                    FotoIne = table.Column<string>(type: "varchar(250)", nullable: true),
                    FotoSeguro = table.Column<string>(type: "varchar(250)", nullable: true),
                    Ruta = table.Column<string>(type: "varchar(150)", nullable: true),
                    NoTelefono = table.Column<string>(type: "varchar(15)", nullable: true),
                    estatus = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(type: "varchar(55)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Operadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tr_Has_Ruta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Ruta = table.Column<int>(nullable: false),
                    Id_Transportista = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(14,2)", nullable: false),
                    Estatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tr_Has_Ruta", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Demands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    OriginId = table.Column<int>(nullable: false),
                    DestinationId = table.Column<int>(nullable: false),
                    RouteId = table.Column<int>(nullable: false),
                    Folio = table.Column<string>(nullable: true),
                    FechaDisponibilidad = table.Column<DateTime>(nullable: false),
                    FechaLlegada = table.Column<DateTime>(nullable: false),
                    Arribo = table.Column<string>(nullable: true),
                    TipoViaje = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Demands_Clientes_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demands_Cl_Has_Destinos_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Cl_Has_Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demands_Cl_Has_Origen_OriginId",
                        column: x => x.OriginId,
                        principalTable: "Cl_Has_Origen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demands_Ruta_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Ruta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demands_Cat_Tipos_Unidades_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Cat_Tipos_Unidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Substatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatusId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Substatuses_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ruta_has_inventario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tr_Has_RutaId = table.Column<int>(nullable: false),
                    Id_Inventario = table.Column<int>(nullable: false),
                    CostoOne = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostoTwo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Circuito = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ruta_has_inventario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ruta_has_inventario_Tr_Has_Ruta_Tr_Has_RutaId",
                        column: x => x.Tr_Has_RutaId,
                        principalTable: "Tr_Has_Ruta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Travels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatusId = table.Column<int>(nullable: false),
                    SubstatusId = table.Column<int>(nullable: false),
                    Folio = table.Column<string>(nullable: true),
                    Cat_Tipos_UnidadesId = table.Column<int>(nullable: false),
                    Ejecutivo = table.Column<string>(nullable: true),
                    GrupoMonitor = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Travels_Cat_Tipos_Unidades_Cat_Tipos_UnidadesId",
                        column: x => x.Cat_Tipos_UnidadesId,
                        principalTable: "Cat_Tipos_Unidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Travels_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Travels_Substatuses_SubstatusId",
                        column: x => x.SubstatusId,
                        principalTable: "Substatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturacion",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TravelId = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(type: "VARCHAR(300)", nullable: true),
                    fullpath = table.Column<string>(nullable: true),
                    fechacarga = table.Column<DateTime>(nullable: false),
                    usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturacion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Facturacion_Travels_TravelId",
                        column: x => x.TravelId,
                        principalTable: "Travels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TravelId = table.Column<int>(nullable: false),
                    Registro = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TimeCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionLogs_Travels_TravelId",
                        column: x => x.TravelId,
                        principalTable: "Travels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TravelId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    SubstatusId = table.Column<int>(nullable: false),
                    Folio = table.Column<string>(nullable: true),
                    ClientesId = table.Column<int>(nullable: false),
                    Cl_Has_OrigenId = table.Column<int>(nullable: false),
                    Cl_Has_DestinosId = table.Column<int>(nullable: false),
                    SectionTypeId = table.Column<int>(nullable: false),
                    Cl_Has_OtrosId = table.Column<int>(nullable: false),
                    RutaId = table.Column<int>(nullable: false),
                    FechaSalida = table.Column<DateTime>(nullable: false),
                    FechaLlegada = table.Column<DateTime>(nullable: false),
                    Anticipacion = table.Column<string>(nullable: true),
                    Espejo = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true),
                    Referencia1 = table.Column<string>(nullable: true),
                    Referencia2 = table.Column<string>(nullable: true),
                    Referencia3 = table.Column<string>(nullable: true),
                    Alto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ancho = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Largo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PesoVolumetrico = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsEmpty = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Cl_Has_Destinos_Cl_Has_DestinosId",
                        column: x => x.Cl_Has_DestinosId,
                        principalTable: "Cl_Has_Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Cl_Has_Origen_Cl_Has_OrigenId",
                        column: x => x.Cl_Has_OrigenId,
                        principalTable: "Cl_Has_Origen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Cl_Has_Otros_Cl_Has_OtrosId",
                        column: x => x.Cl_Has_OtrosId,
                        principalTable: "Cl_Has_Otros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Ruta_RutaId",
                        column: x => x.RutaId,
                        principalTable: "Ruta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_SectionTypes_SectionTypeId",
                        column: x => x.SectionTypeId,
                        principalTable: "SectionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Substatuses_SubstatusId",
                        column: x => x.SubstatusId,
                        principalTable: "Substatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Travels_TravelId",
                        column: x => x.TravelId,
                        principalTable: "Travels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SectionId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    SubstatusId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionComments_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionComments_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionComments_Substatuses_SubstatusId",
                        column: x => x.SubstatusId,
                        principalTable: "Substatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SectionId = table.Column<int>(nullable: false),
                    TransportistaId = table.Column<int>(nullable: false),
                    Tr_Has_OperadoresId = table.Column<int>(nullable: false),
                    Folio = table.Column<string>(nullable: true),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Services_Tr_Has_Operadores_Tr_Has_OperadoresId",
                        column: x => x.Tr_Has_OperadoresId,
                        principalTable: "Tr_Has_Operadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Services_Transportista_TransportistaId",
                        column: x => x.TransportistaId,
                        principalTable: "Transportista",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evidences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SectionCommentId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evidences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evidences_SectionComments_SectionCommentId",
                        column: x => x.SectionCommentId,
                        principalTable: "SectionComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ServiceId = table.Column<int>(nullable: false),
                    Cat_Tipos_UnidadesId = table.Column<int>(nullable: false),
                    Tr_Has_InventarioId = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Units_Cat_Tipos_Unidades_Cat_Tipos_UnidadesId",
                        column: x => x.Cat_Tipos_UnidadesId,
                        principalTable: "Cat_Tipos_Unidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Units_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Units_Tr_Has_Inventario_Tr_Has_InventarioId",
                        column: x => x.Tr_Has_InventarioId,
                        principalTable: "Tr_Has_Inventario",
                        principalColumn: "Id",
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
                name: "IX_Demands_ClientId",
                table: "Demands",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Demands_DestinationId",
                table: "Demands",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Demands_OriginId",
                table: "Demands",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Demands_RouteId",
                table: "Demands",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Demands_UnitId",
                table: "Demands",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Evidences_SectionCommentId",
                table: "Evidences",
                column: "SectionCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturacion_TravelId",
                table: "Facturacion",
                column: "TravelId");

            migrationBuilder.CreateIndex(
                name: "IX_Region_Has_Estado_Cat_RegionId",
                table: "Region_Has_Estado",
                column: "Cat_RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ruta_has_inventario_Tr_Has_RutaId",
                table: "ruta_has_inventario",
                column: "Tr_Has_RutaId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionComments_SectionId",
                table: "SectionComments",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionComments_StatusId",
                table: "SectionComments",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionComments_SubstatusId",
                table: "SectionComments",
                column: "SubstatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLogs_TravelId",
                table: "SectionLogs",
                column: "TravelId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_Cl_Has_DestinosId",
                table: "Sections",
                column: "Cl_Has_DestinosId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_Cl_Has_OrigenId",
                table: "Sections",
                column: "Cl_Has_OrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_Cl_Has_OtrosId",
                table: "Sections",
                column: "Cl_Has_OtrosId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_ClientesId",
                table: "Sections",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_RutaId",
                table: "Sections",
                column: "RutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_SectionTypeId",
                table: "Sections",
                column: "SectionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_StatusId",
                table: "Sections",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_SubstatusId",
                table: "Sections",
                column: "SubstatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_TravelId",
                table: "Sections",
                column: "TravelId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_SectionId",
                table: "Services",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_Tr_Has_OperadoresId",
                table: "Services",
                column: "Tr_Has_OperadoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_TransportistaId",
                table: "Services",
                column: "TransportistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Substatuses_StatusId",
                table: "Substatuses",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Travels_Cat_Tipos_UnidadesId",
                table: "Travels",
                column: "Cat_Tipos_UnidadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Travels_StatusId",
                table: "Travels",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Travels_SubstatusId",
                table: "Travels",
                column: "SubstatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_Cat_Tipos_UnidadesId",
                table: "Units",
                column: "Cat_Tipos_UnidadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_ServiceId",
                table: "Units",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_Tr_Has_InventarioId",
                table: "Units",
                column: "Tr_Has_InventarioId");
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
                name: "Cl_Has_Biblioteca");

            migrationBuilder.DropTable(
                name: "Cl_Has_Box");

            migrationBuilder.DropTable(
                name: "Cl_Has_Certificacion");

            migrationBuilder.DropTable(
                name: "Cl_Has_Checkpoint");

            migrationBuilder.DropTable(
                name: "Cl_Has_Contactos");

            migrationBuilder.DropTable(
                name: "Cl_Has_Evidencia");

            migrationBuilder.DropTable(
                name: "Cl_Has_Requisitos");

            migrationBuilder.DropTable(
                name: "Cl_Has_Routes");

            migrationBuilder.DropTable(
                name: "Demands");

            migrationBuilder.DropTable(
                name: "Evidences");

            migrationBuilder.DropTable(
                name: "Facturacion");

            migrationBuilder.DropTable(
                name: "Oferta");

            migrationBuilder.DropTable(
                name: "Region_Has_Estado");

            migrationBuilder.DropTable(
                name: "Ruta_Has_Checkpoint");

            migrationBuilder.DropTable(
                name: "ruta_has_inventario");

            migrationBuilder.DropTable(
                name: "SectionLogs");

            migrationBuilder.DropTable(
                name: "Separar");

            migrationBuilder.DropTable(
                name: "Tr_Has_Biblioteca");

            migrationBuilder.DropTable(
                name: "Tr_Has_Box");

            migrationBuilder.DropTable(
                name: "Tr_Has_Certificacion");

            migrationBuilder.DropTable(
                name: "Tr_Has_Contactos");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SectionComments");

            migrationBuilder.DropTable(
                name: "Cat_Region");

            migrationBuilder.DropTable(
                name: "Tr_Has_Ruta");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Tr_Has_Inventario");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Tr_Has_Operadores");

            migrationBuilder.DropTable(
                name: "Transportista");

            migrationBuilder.DropTable(
                name: "Cl_Has_Destinos");

            migrationBuilder.DropTable(
                name: "Cl_Has_Origen");

            migrationBuilder.DropTable(
                name: "Cl_Has_Otros");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Ruta");

            migrationBuilder.DropTable(
                name: "SectionTypes");

            migrationBuilder.DropTable(
                name: "Travels");

            migrationBuilder.DropTable(
                name: "Cat_Tipos_Unidades");

            migrationBuilder.DropTable(
                name: "Substatuses");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
