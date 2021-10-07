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
                nombre = "Juan",
                telefono =  "10",
                edad =  20,
                direccion = "10",
                correo = "da@gmail.com",
                contrasenia = "sdjs62",
                fechaRegistro = new DateTime(1985, 03, 12),
                especializacion = "prueba",
                tarjetaProfesional = "10"
            };

            repositorioVeterinario.Agregar(veterinario);

        }


        private static void EditarVeterinario(int idVeterinario) {

            var veterinario = new EntidadVeterinario 
            {
                Id = idVeterinario,               
                correo = "david@gmail.com",
                contrasenia = "1111",
                 // nombre = "Juan",
                // telefono =  "10",
                // edad =  20,
                // direccion = "10",
                
                // fechaRegistro = new DateTime(1985, 03, 12),
                // especializacion = "prueba",
                // tarjetaProfesional = "10"
            };

            Object v = repositorioVeterinario.EditarCampo(veterinario);
            if(v != null) {
                Console.WriteLine("Veterinario editado exitosamente");
            }



        }
    }
}
