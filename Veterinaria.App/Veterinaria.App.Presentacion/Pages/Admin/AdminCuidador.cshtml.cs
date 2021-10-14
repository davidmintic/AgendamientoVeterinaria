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
    public class AdminCuidadorModel : PageModel
    {
       

        private  ICrudRepositorio repositorioCuidador = new RepositorioCuidador(new Persistencia.AppContext());
        public IEnumerable <EntidadCuidador>  cuidadores;
        public EntidadCuidador cuidadorActual;
        public String modoPage = "adicion";

        public void OnGet(int idVeterinario)
        {

            if(idVeterinario > 0) {
                this.modoPage = "edicion";
                this.cuidadorActual = (EntidadCuidador)repositorioCuidador.ObtenerObjeto(idVeterinario);
            } else {
                this.modoPage = "adicion";
            }

           this.RefreshData();

        }

        public void OnPostAdd(EntidadCuidador vetetinario){
            repositorioCuidador.Agregar(vetetinario);
            this.RefreshData();
        }

         public void OnPostDel(int idCuidador){

            // Console.WriteLine("se eliminó");

            repositorioCuidador.Eliminar(idCuidador);
            this.RefreshData();
        }

         public void OnPostEdit(EntidadCuidador vetetinario){

            repositorioCuidador.EditarCampo(vetetinario);
            this.RefreshData();
        }


        public void RefreshData() {
             var listaEnumerable = repositorioCuidador.ObtenerListadoObjetos();
             this.cuidadores =  (IEnumerable<EntidadCuidador>)repositorioCuidador.ObtenerListadoObjetos();
        }
    }
}
