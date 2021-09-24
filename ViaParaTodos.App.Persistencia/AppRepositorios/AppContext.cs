using Microsoft.EntityFrameworkCore;
using ViaParaTodos.App.Dominio.Entidades;

namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public class AppContext:DbContext
    {
        public DbSet<Personas> Personas {set;get;}
        public DbSet<Accidente> Accidente {set;get;}
        public DbSet<Administrador> Administrador {set;get;}
        public DbSet<AgenteTransito> AgenteTransito {set;get;}
        public DbSet<Conductores> Conductores {set;get;}
        public DbSet<Documentos> Documentos {set;get;}
        public DbSet<Localizacion> Localizacion {set;get;}
        public DbSet<Propietarios> Propietarios {set;get;}
        public DbSet<Vehiculos> Vehiculos {set;get;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {  
            if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ViaParaTodosData");
                }
        }
    }
}