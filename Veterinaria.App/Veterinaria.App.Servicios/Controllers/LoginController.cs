using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
// using Microsoft.AspNetCore.Http
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    { 

        private static ICrudRepositorio repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        //👇 new code
        [HttpGet]
        public ActionResult<String> Get()
        {

            EntidadVeterinario veterinario  =  (EntidadVeterinario) repositorioVeterinario.ObtenerObjeto(1);

            return Ok("data: "+ veterinario.nombre);
        }


        //👇 new code
        [HttpPost]
        // public ActionResult<String> Post()
        public ActionResult<String> Post(EntidadVeterinario veterinario)
        {             
            
            // var veterinario = new EntidadVeterinario 
            // {
            //     // id = "0",
            //     nombre = "Juan",
            //     telefono =  "10",
            //     edad =  20,
            //     direccion = "10",
            //     correo = "da@gmail.com",
            //     contrasenia = "sdjs62",
            //     fechaRegistro = new DateTime(1985, 03, 12),
            //     especializacion = "prueba",
            //     tarjetaProfesional = "10"
            // };
          
            return Ok("data: "+  veterinario.nombre);
            // return "" + content;
        }

    }
    
}