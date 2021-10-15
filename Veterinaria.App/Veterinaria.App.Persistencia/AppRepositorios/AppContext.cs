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
               
//  optionsBuilder.UseSqlServer("Server=tcp:servermintic2021.database.windows.net,1433;Initial Catalog=AgendamientoVeterinaria;Persist Security Info=False;User ID=sesionmintic2021;Password=servermintic2021#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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