﻿// <auto-generated />
using System;
using KLS_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KLS_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KLS_API.Models.Carriers.Tr_Has_Biblioteca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estatus")
                        .HasColumnType("int");

                    b.Property<int>("Id_Transportista")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(55)");

                    b.HasKey("Id");

                    b.ToTable("Tr_Has_Biblioteca");
                });

            modelBuilder.Entity("KLS_API.Models.Carriers.Tr_Has_Box", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Custodia")
                        .HasColumnType("bit");

                    b.Property<string>("D_Opcional")
                        .HasColumnType("varchar(55)");

                    b.Property<bool>("Densidad")
                        .HasColumnType("bit");

                    b.Property<bool>("Derramable")
                        .HasColumnType("bit");

                    b.Property<int>("Id_Transportista")
                        .HasColumnType("int");

                    b.Property<string>("M_Opcional")
                        .HasColumnType("varchar(55)");

                    b.Property<bool>("Material")
                        .HasColumnType("bit");

                    b.Property<string>("Notas")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("OlorPenetrante")
                        .HasColumnType("bit");

                    b.Property<bool>("Peligroso")
                        .HasColumnType("bit");

                    b.Property<bool>("TipoPresentacion")
                        .HasColumnType("bit");

                    b.Property<string>("Tp_Opcional")
                        .HasColumnType("varchar(55)");

                    b.Property<string>("V_Opcional")
                        .HasColumnType("varchar(55)");

                    b.Property<string>("Valor")
                        .HasColumnType("varchar(55)");

                    b.HasKey("Id");

                    b.ToTable("Tr_Has_Box");
                });

            modelBuilder.Entity("KLS_API.Models.Carriers.Tr_Has_Certificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("C_Opcional")
                        .HasColumnType("varchar(55)");

                    b.Property<bool>("Ctpat")
                        .HasColumnType("bit");

                    b.Property<int>("Id_Transportista")
                        .HasColumnType("int");

                    b.Property<string>("O_Opcional")
                        .HasColumnType("varchar(55)");

                    b.Property<bool>("Otro")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tr_Has_Certificacion");
                });

            modelBuilder.Entity("KLS_API.Models.Carriers.Tr_Has_Contactos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnType("varchar(55)");

                    b.Property<int>("Estatus")
                        .HasColumnType("int");

                    b.Property<int>("Id_Transportista")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(55)");

                    b.Property<string>("Telefono")
                        .HasColumnType("varchar(35)");

                    b.Property<string>("TipoContacto")
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Tr_Has_Contactos");
                });

            modelBuilder.Entity("KLS_API.Models.Carriers.Tr_Has_Rutas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Demanda")
                        .HasColumnType("int");

                    b.Property<int>("Eficiencia")
                        .HasColumnType("int");

                    b.Property<int>("Estatus")
                        .HasColumnType("int");

                    b.Property<string>("FrecValidacion")
                        .HasColumnType("varchar(25)");

                    b.Property<int>("Id_Ciudad_Destino")
                        .HasColumnType("int");

                    b.Property<int>("Id_Ciudad_Origen")
                        .HasColumnType("int");

                    b.Property<int>("Id_Estado_Destino")
                        .HasColumnType("int");

                    b.Property<int>("Id_Estado_Origen")
                        .HasColumnType("int");

                    b.Property<int>("Id_Transportista")
                        .HasColumnType("int");

                    b.Property<string>("Observacion")
                        .HasColumnType("varchar(85)");

                    b.Property<string>("Restriccion")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("RestriccionCircuito")
                        .HasColumnType("varchar(25)");

                    b.Property<int>("Seguridad")
                        .HasColumnType("int");

                    b.Property<int>("TipoDeViaje")
                        .HasColumnType("int");

                    b.Property<int>("TotalHoras")
                        .HasColumnType("int");

                    b.Property<decimal>("Total_Kilometros")
                        .HasColumnType("decimal(2,2)");

                    b.HasKey("Id");

                    b.ToTable("Tr_Has_Rutas");
                });

            modelBuilder.Entity("KLS_API.Models.Carriers.Transportista", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Banco")
                        .HasColumnType("varchar(90)");

                    b.Property<string>("Comentario")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Contrasena")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Cuenta")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("DireccionFiscal")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("DireccionOficinas")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("DireccionPatio")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("Estatus")
                        .HasColumnType("int");

                    b.Property<string>("Facebook")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("FechaUltimoViaje")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("GoogleMaps")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("GradoConfiabilidad")
                        .HasColumnType("varchar(15)");

                    b.Property<int>("NivelServicio")
                        .HasColumnType("int");

                    b.Property<string>("NombreComercial")
                        .HasColumnType("varchar(55)");

                    b.Property<string>("OtraRed")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("PaginaWeb")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rfc")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Servicio")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Tamanio")
                        .HasColumnType("varchar(22)");

                    b.Property<string>("UsuarioMaster")
                        .HasColumnType("varchar(35)");

                    b.HasKey("id");

                    b.ToTable("Transportista");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Aerolinea", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("almacen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cat_Aerolinea");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Agentes_Aduanales", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cat_Agentes_Aduanales");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Ciudad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<int>("id_estado")
                        .HasColumnType("int");

                    b.Property<int>("id_pais")
                        .HasColumnType("int");

                    b.Property<string>("id_sepomex")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("nombre")
                        .HasColumnType("varchar(35)");

                    b.HasKey("id");

                    b.ToTable("Cat_Ciudad");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Coloaders", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contacto")
                        .HasColumnType("varchar(70)");

                    b.Property<string>("correo")
                        .HasColumnType("varchar(55)");

                    b.Property<string>("departamento")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("direccion")
                        .HasColumnType("varchar(80)");

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("notas")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("telefono")
                        .HasColumnType("varchar(40)");

                    b.HasKey("id");

                    b.ToTable("Cat_Coloaders");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Colonia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cp")
                        .HasColumnType("int");

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<int>("id_ciudad")
                        .HasColumnType("int");

                    b.Property<int>("id_estado")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("Cat_Colonia");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Estado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<int>("id_pais")
                        .HasColumnType("int");

                    b.Property<string>("id_sepomex")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("nombre")
                        .HasColumnType("varchar(30)");

                    b.HasKey("id");

                    b.ToTable("Cat_Estado");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Navieras", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cat_Navieras");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Pais", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<string>("pais")
                        .HasColumnType("varchar(28)");

                    b.HasKey("id");

                    b.ToTable("Cat_Pais");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Region", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("varchar(10)");

                    b.HasKey("id");

                    b.ToTable("Cat_Region");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Subservicios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servicio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cat_Subservicios");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Terrestres_Internacionales", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cat_Terrestres_Internacionales");
                });

            modelBuilder.Entity("KLS_API.Models.Cat_Tipos_Unidades", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ejes")
                        .HasColumnType("int");

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<decimal>("limite_peso")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("limite_volumen")
                        .HasColumnType("Varchar(35)");

                    b.Property<decimal>("litros")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("llantas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("mantenimiento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("nombre")
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("rendimiento")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Cat_Tipos_Unidades");
                });

            modelBuilder.Entity("KLS_API.Models.Region_Has_Estado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cat_RegionId")
                        .HasColumnType("int");

                    b.Property<int>("id_estado")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Cat_RegionId");

                    b.ToTable("Region_Has_Estado");
                });

            modelBuilder.Entity("KLS_API.Models.Ruta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("actualizadopor")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("demanda")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("eficiencia")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("estatus")
                        .HasColumnType("int");

                    b.Property<string>("frecvalidacion")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("id_ciudaddestino")
                        .HasColumnType("int");

                    b.Property<int>("id_ciudadorigen")
                        .HasColumnType("int");

                    b.Property<int>("id_estadodestino")
                        .HasColumnType("int");

                    b.Property<int>("id_estadoorigen")
                        .HasColumnType("int");

                    b.Property<string>("observaciones")
                        .HasColumnType("text");

                    b.Property<string>("restriccioncirc")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("seguridad")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("tipodeviaje")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("totalhoras")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("totalkilometros")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ultimocambio")
                        .HasColumnType("DateTime");

                    b.HasKey("id");

                    b.ToTable("Ruta");
                });

            modelBuilder.Entity("KLS_API.Models.Ruta_Has_Checkpoint", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cat_CiudadId")
                        .HasColumnType("int");

                    b.Property<int>("RutaId")
                        .HasColumnType("int");

                    b.Property<string>("tiempo")
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("Ruta_Has_Checkpoint");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("KLS_API.Models.Region_Has_Estado", b =>
                {
                    b.HasOne("KLS_API.Models.Cat_Region", null)
                        .WithMany("Region_Has_Estados")
                        .HasForeignKey("Cat_RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
