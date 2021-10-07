using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Presentacion
{
    public class LoginModel : PageModel
    {
        
        public String title { get; set;}

        public void OnGet()
        {
            
            this.title = "¡Bienvenido, agenda fácil!";
        }

    
    }
}
