﻿using KLS_API.Models;
using KLS_API.Models.Carriers;
using KLS_API.Models.Travel;
using KLS_API.Models.Clients;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KLS_API.Controllers.Clients;
using KLS_API.Models.Demands;
using KLS_API.Models.Oferta;

namespace KLS_API.Context
{
    public class AppDbContext : IdentityDbContext<AddUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Cat_Aerolinea> Cat_Aerolinea { get; set; }
        public DbSet<Cat_Agentes_Aduanales> Cat_Agentes_Aduanales { get; set; }
        public DbSet<Cat_Coloaders> Cat_Coloaders { get; set; }
        public DbSet<Cat_Navieras> Cat_Navieras { get; set; }
        public DbSet<Cat_Subservicios> Cat_Subservicios { get; set; }
        public DbSet<Cat_Terrestres_Internacionales> Cat_Terrestres_Internacionales { get; set; }
        public DbSet<Cat_Tipos_Unidades> Cat_Tipos_Unidades { get; set; }
        public DbSet<Cat_Pais> Cat_Pais { get; set; }
        public DbSet<Cat_Estado> Cat_Estado { get; set; }
        public DbSet<Cat_Ciudad> Cat_Ciudad { get; set; }
        public DbSet<Cat_Colonia> Cat_Colonia { get; set; }
        public DbSet<Cat_Region> Cat_Region { get; set; }
        public DbSet<Ruta> Ruta { get; set; }
        public DbSet<Ruta_Has_Checkpoint> Ruta_Has_Checkpoint { get; set; }
        public DbSet<Region_Has_Estado> Region_Has_Estado { get; set; }

        //Transportistas
        public DbSet<Transportista> Transportista { get; set; }
        public DbSet<Tr_Has_Certificacion> Tr_Has_Certificacion { get; set; }
        public DbSet<Tr_Has_Box> Tr_Has_Box { get; set; }
        public DbSet<Tr_Has_Biblioteca> Tr_Has_Biblioteca { get; set; }
        public DbSet<Tr_Has_Contactos> Tr_Has_Contactos { get; set; }
        public DbSet<Tr_Has_Ruta> Tr_Has_Rutas { get; set; }
        public DbSet<Tr_Has_Inventario> Tr_Has_Inventario { get; set; }
        public DbSet<Tr_Has_Operadores> Tr_Has_Operadores { get; set; }
        public DbSet<Tr_Has_Ruta> Tr_Has_Ruta { get; set; }
        public DbSet<ruta_has_inventario> ruta_has_inventario { get; set; }

        //Clientes
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Cl_Has_Routes> Cl_Has_Routes { get; set; }
        public DbSet<Cl_Has_Checkpoint> Cl_Has_Checkpoint { get; set; }
        public DbSet<Cl_Has_Certificacion> Cl_Has_Certificacion { get; set; }
        public DbSet<Cl_Has_Box> Cl_Has_Box { get; set; }
        public DbSet<Cl_Has_Biblioteca> Cl_Has_Biblioteca { get; set; }
        public DbSet<Cl_Has_Contactos> Cl_Has_Contactos { get; set; }
        public DbSet<Cl_Has_Origen> Cl_Has_Origen { get; set; }
        public DbSet<Cl_Has_Destinos> Cl_Has_Destinos { get; set; }
        public DbSet<Cl_Has_Evidencia> Cl_Has_Evidencia { get; set; }
        public DbSet<Cl_Has_Otros> Cl_Has_Otros { get; set; }
        public DbSet<Cl_Has_Requisitos> Cl_Has_Requisitos { get; set; }

        //Viajes
        public DbSet<Travel> Travels { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Substatus> Substatuses { get; set; }
        public DbSet<SectionType> SectionTypes { get; set; }
        public DbSet<SectionLog> SectionLogs { get; set; }
        public DbSet<SectionComment> SectionComments { get; set; }
        public DbSet<Evidence> Evidences { get; set; }
        public DbSet<Facturacion> Facturacion { get; set; }

        // Demandas
        public DbSet<Demand> Demands { get; set; }
        public DbSet<Oferta> Oferta { get; set; }

        //Ofertas
        public DbSet<Separar> Separar { get; set; }
    }
}
