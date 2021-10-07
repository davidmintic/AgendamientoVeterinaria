using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;


namespace Veterinaria.App.Presentacion.Pages
{
    public class AdminVeterinarioModel : PageModel
    {

        private  ICrudRepositorio repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        // public List <EntidadVeterinario>  veterinarios = new List<EntidadVeterinario>();
        public IEnumerable <EntidadVeterinario>  veterinarios;

        public void OnGet(int id)
        {
            // var vs = repositorioVeterinario.ObtenerListadoObjetos();
            if(id != null) {
                Console.WriteLine("entro con el id "+ id);
                this.RefreshData();
            } else {
                this.RefreshData();
                 Console.WriteLine("NO ENTRÓ con el id ");
            }
    
        }


        // asp-page-handler=""
        public  void OnPostAdd(EntidadVeterinario veterinario)
        {
            var emailAddress = Request.Form["nombre"];

            Console.WriteLine(emailAddress);
            repositorioVeterinario.Agregar(veterinario);
            this.RefreshData();
        }


        

        // asp-page-handler=""
        public  void OnPostDel(int id)
        {
            if(id != null) {
                // Console.WriteLine("entro con el id "+ id);
                // this.RefreshData();
                repositorioVeterinario.Eliminar(id);
                this.RefreshData();
            } else {
                this.RefreshData();
                 Console.WriteLine("NO ENTRÓ con el id ");
            }
        }

        
        // asp-page-handler=""
        public  IActionResult  OnPostEdit(int id)
        {
            if(id != null) {
                // Console.WriteLine("entro con el id "+ id);
                // this.RefreshData();
                // repositorioVeterinario.Eliminar(id);
                // this.RefreshData();

        //          string url = "/.auth/login/aad?post_login_redirect_url=" 
        //   + Request.Query["redirect_url"];

                return Redirect("/index?id="+id);
            } else {
                this.RefreshData();
                 Console.WriteLine("NO ENTRÓ con el id ");

                 return Redirect("/index");
            }
        }



        public void RefreshData() {

             var listaEnumerable = repositorioVeterinario.ObtenerListadoObjetos();
             this.veterinarios =  (IEnumerable<EntidadVeterinario>)repositorioVeterinario.ObtenerListadoObjetos();

            // foreach(Object v in listaEnumerable) {
            //     this.veterinarios.Add((EntidadVeterinario)v);
            // }
        }
    }
}
