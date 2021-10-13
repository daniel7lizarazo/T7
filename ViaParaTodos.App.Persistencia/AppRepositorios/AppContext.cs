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
        public DbSet<TablaVA> TablaVA {set;get;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Localizacion>()
                .HasOne(a=>a.Accidente)
                .WithOne(l=>l.Localizacion)
                .HasForeignKey<Accidente>(a=>a.AccidenteLocalizacionId);
            modelBuilder.Entity<Vehiculos>()
                .HasOne(t=>t.TablaVC)
                .WithOne(v=>v.Vehiculos)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<TablaVC>(t=>t.VehiculosTablaVCId);
            modelBuilder.Entity<Conductores>()
                .HasMany(t=>t.TablaVC)
                .WithOne(c=>c.Conductores)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<TablaVC>(t=>t.ConductoresTablaVCId);
            modelBuilder.Entity<Vinculados>()
                .HasMany(t=>t.TablaVA)
                .WithOne(v=>v.Vinculados)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<TablaVA>(t=>t.VinculadosId);*/
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