using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {

        private static ICrudRepositorio repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            // AgregarVeterinario();
            EditarVeterinario(1);
        }


        private static void AgregarVeterinario() {

            var veterinario = new EntidadVeterinario 
            {
                // id = "0",
                Nombre = "Juan",
                Telefono =  "10",
                Edad =  20,
                Direccion = "10",
                Correo = "da@gmail.com",
                Contrasenia = "sdjs62",
                FechaRegistro = new DateTime(1985, 03, 12),
                Especializacion = "prueba",
                TarjetaProfesional = "10"
            };

            repositorioVeterinario.Agregar(veterinario);

        }


        private static void EditarVeterinario(int idVeterinario) {

            var veterinario = new EntidadVeterinario 
            {
                Id = idVeterinario,               
                Correo = "david@gmail.com",
                Contrasenia = "1111",
                 // Nombre = "Juan",
                // Telefono =  "10",
                // Edad =  20,
                // Direccion = "10",
                
                // FechaRegistro = new DateTime(1985, 03, 12),
                // Especializacion = "prueba",
                // TarjetaProfesional = "10"
            };

            Object v = repositorioVeterinario.EditarCampo(veterinario);
            if(v != null) {
                Console.WriteLine("Veterinario editado exitosamente");
            }



        }
    }
}
