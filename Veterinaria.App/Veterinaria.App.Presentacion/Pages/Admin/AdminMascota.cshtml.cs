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
    public class AdminMascotaModel : PageModel
    {

        
        private RepositorioCuidador repositorioCuidador = new RepositorioCuidador(new Persistencia.AppContext());
        public EntidadCuidador cuidadorActual;
         public String modoPage = "adicion";

        public void OnGet(int idCuidador)
        {
            if(idCuidador > 0) {
                this.cuidadorActual = (EntidadCuidador) this.repositorioCuidador.ObtenerConMascotas(idCuidador);
            }
          
        }
    }
}
