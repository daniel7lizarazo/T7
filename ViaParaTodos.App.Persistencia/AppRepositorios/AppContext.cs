using System.Linq;
using Microsoft.EntityFrameworkCore;
using ViaParaTodos.App.Dominio.Entidades;

namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public class AppContext:DbContext
    {
        public DbSet<Ciudadanos> Ciudadanos {set;get;}
        public DbSet<Accidente> Accidente {set;get;}
        public DbSet<AgentesTransito> AgentesTransito {set;get;}
        public DbSet<Conductores> Conductores {set;get;}
        public DbSet<Localizacion> Localizacion {set;get;}
        public DbSet<Vehiculos> Vehiculos {set;get;}
        public DbSet<Vinculados> Vinculados {set;get;}
        public DbSet<TablaVC> TablaVC {set;get;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accidente>()
                .HasOne(l=>l.Localizacion)
                .WithOne(a=>a.Accidente)
                .HasForeignKey<Localizacion>(l=>l.LocalizacionAccidenteId);
            modelBuilder.Entity<Vehiculos>()
                .HasOne(t=>t.TablaVC)
                .WithOne(v=>v.Vehiculos)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<TablaVC>(t=>t.VehiculosTablaVCId);
            modelBuilder.Entity<Conductores>()
                .HasOne(t=>t.TablaVC)
                .WithOne(c=>c.Conductores)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<TablaVC>(t=>t.ConductoresTablaVCId);
            /*
            modelBuilder.Entity<Propietarios>()
                .HasOne(t=>t.TablaVCP)
                .WithOne(p=>p.Propietarios)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<TablaVCP>(t=>t.PropietariosTablaVCPId);
            */
        }
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