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

        private RepositorioLogin repositorioLogin = new RepositorioLogin(new Persistencia.AppContext());
        public String title { get; set; }

        public Boolean errorLogin = false;

        public void OnGet()
        {

            this.title = "¡Bienvenido, agenda fácil!";
            var errorLogin = TempData["errorLogin"] as string;

            if(errorLogin != null) {
                this.errorLogin = true;
            }
        }

        public IActionResult OnPostLogin(UserLogin user)
        {
            Boolean isValid = this.repositorioLogin.ValidarUsuario(user.Correo, user.Contrasenia);

            if (isValid)
            {
                Console.WriteLine("login " + user.Correo + "contraseña " + user.Contrasenia);
                // return View("AdminVeterinario");
                return new RedirectToPageResult("/Admin/AdminVeterinario");
            }
            else
            {
                // Console.WriteLine("no login " + user.Correo);
                TempData["errorLogin"] = "true"; 
                return new RedirectToPageResult("/Login/Login"); 
                return null;
            }
        }
    }


    public class UserLogin
    {
        public String Correo { get; set; }
        public String Contrasenia { get; set; }
    }
}
