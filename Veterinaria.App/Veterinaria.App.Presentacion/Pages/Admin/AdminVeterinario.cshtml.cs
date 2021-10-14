using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;
using System.Security.Cryptography;


namespace Veterinaria.App.Presentacion.Pages
{
    public class AdminVeterinarioModel : PageModel
    {

        private ICrudRepositorio repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        // public List <EntidadVeterinario>  veterinarios = new List<EntidadVeterinario>();
        public IEnumerable<EntidadVeterinario> veterinarios;
        public EntidadVeterinario veterinarioActual;
        public String modoPage = "adicion";

        public void OnGet(int idVeterinario)
        {        

            if (idVeterinario > 0)
            {
                this.modoPage = "edicion";
                this.veterinarioActual = (EntidadVeterinario)repositorioVeterinario.ObtenerObjeto(idVeterinario);
            }
            else
            {
                this.modoPage = "adicion";
            }

            this.RefreshData();

        }

        public void OnPostAdd(EntidadVeterinario veterinario)
        {
            veterinario.Contrasenia = GetMD5Hash(veterinario.Contrasenia);
            repositorioVeterinario.Agregar(veterinario);
            this.RefreshData();
        }

        public void OnPostDel(int idVeterinario)
        {

            repositorioVeterinario.Eliminar(idVeterinario);
            this.RefreshData();
        }

        public void OnPostEdit(EntidadVeterinario vetetinario)
        {

            repositorioVeterinario.EditarCampo(vetetinario);
            this.RefreshData();
        }


        public void RefreshData()
        {
            var listaEnumerable = repositorioVeterinario.ObtenerListadoObjetos();
            this.veterinarios = (IEnumerable<EntidadVeterinario>)repositorioVeterinario.ObtenerListadoObjetos();
        }

        public static String GetMD5Hash(String input)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String hash = s.ToString();
            return hash;
        }
    }
}
