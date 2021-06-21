using KLS_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KLS_API.Context
{
    public class AppDbContext: IdentityDbContext
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
        public DbSet<Region_Has_Estado> Region_Has_Estado { get; set; }

    }
}
