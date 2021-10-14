using System;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
    public class AppContext : DbContext
    {

        public DbSet<EntidadPersona> Personas { get; set; }
        public DbSet<EntidadVeterinario> Veterinarios { get; set; }
        public DbSet<EntidadCuidador> Cuidadores { get; set; }
        public DbSet<EntidadMascota> Mascotas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if(!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = AgendamientoVeterinaria");
               
            }
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder){
            modelBuilder.Entity<EntidadMascota>().HasOne(x => x.Cuidador).WithMany(b => b.Mascotas).IsRequired();

            //   modelBuilder.Entity<EntidadMascota>()
            //                 .HasOne(p => p.cuidador)
            //                 .WithMany(b => b.mascotas)
            //                 .OnDelete(DeleteBehavior.Cascade);
        }

        
    }
}