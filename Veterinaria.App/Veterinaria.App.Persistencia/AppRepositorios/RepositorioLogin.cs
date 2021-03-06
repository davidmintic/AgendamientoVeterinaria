using System;
using Veterinaria.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioLogin
    {

        private readonly AppContext appContext;

        public RepositorioLogin(AppContext appContext)
        {
            this.appContext = appContext;
        }

        /// <summary>
        /// Sirve para realizar la validación de que un usario existant
        /// <Return> 
        // Retorna true si el usuario existe o false si el usuario no existe
        public Boolean ValidarUsuario(string correo, string contrasenia)
        {
            // var objetoEncontrado = this.appContext.Personas.FirstOrDefault(p => p.Correo == correo && p.Contrasenia == contrasenia);
            // var query = this.appContext.Veterinarios.FirstOrDefault( p =>  p.Correo == correo );

           
            // var query = this.appContext.Veterinarios.FirstOrDefault(p => p.Correo == correo);
            
        

            // string query = (from c in this.appContext.Personas
            //                 where c.Correo == correo && c.Contrasenia == contrasenia
            //                 select c.Id).FirstOrDefault();

            var objetoEncontrado = this.appContext.Personas.Where(
                 p => p.Correo.Equals(correo) && p.Contrasenia.Equals(contrasenia)
            ).FirstOrDefault();

             return objetoEncontrado != null ?  true : false;
        

        }

    }
}