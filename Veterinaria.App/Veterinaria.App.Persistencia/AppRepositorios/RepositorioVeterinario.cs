using System;
using Veterinaria.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioVeterinario: ICrudRepositorio
    {

        private readonly AppContext appContext;

        public RepositorioVeterinario(AppContext appContext){
            this.appContext = appContext;
        }

          Object ICrudRepositorio.Agregar(Object objeto){
             EntidadVeterinario veterinario = (EntidadVeterinario) objeto;
             veterinario.FechaRegistro = DateTime.Now;
             var objetoAgregado = this.appContext.Veterinarios.Add(veterinario); 
             this.appContext.SaveChanges();
             return objetoAgregado.Entity;   
         }


         Object ICrudRepositorio.Editar(Object objeto){
          
            EntidadVeterinario veterinario = (EntidadVeterinario) objeto;
    
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(p => p.Id == veterinario.Id);
	            if (veterinarioEncontrado != null)
	            {
	                veterinarioEncontrado.Nombre = veterinario.Nombre;
	                veterinarioEncontrado.Telefono = veterinario.Telefono;
	                veterinarioEncontrado.Edad = veterinario.Edad;
	                veterinarioEncontrado.Direccion = veterinario.Direccion;
	                veterinarioEncontrado.Correo = veterinario.Correo;
	                veterinarioEncontrado.Contrasenia = veterinario.Contrasenia;
	                veterinarioEncontrado.FechaRegistro = DateTime.Now;;
	                this.appContext.SaveChanges();

	            }
	            return veterinarioEncontrado;
        }


          Object ICrudRepositorio.EditarCampo(Object objeto){
          
            EntidadVeterinario veterinario = (EntidadVeterinario) objeto;

            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(p => p.Id == veterinario.Id);
	            if (veterinarioEncontrado != null)
	            {
	                veterinarioEncontrado.Nombre = veterinario.Nombre != null ? veterinario.Nombre : veterinarioEncontrado.Nombre;
	                veterinarioEncontrado.Edad = veterinario.Edad != null ? veterinario.Edad : veterinarioEncontrado.Edad;
	                veterinarioEncontrado.Telefono = veterinario.Telefono != null ? veterinario.Telefono : veterinarioEncontrado.Telefono;
	                veterinarioEncontrado.Direccion = veterinario.Direccion != null ? veterinario.Direccion : veterinarioEncontrado.Direccion;
	                veterinarioEncontrado.Correo = veterinario.Correo != null ? veterinario.Correo : veterinarioEncontrado.Correo;
	                veterinarioEncontrado.Contrasenia = veterinario.Contrasenia != null ? veterinario.Contrasenia : veterinarioEncontrado.Contrasenia;
	                veterinarioEncontrado.Especializacion = veterinario.Especializacion != null ? veterinario.Especializacion : veterinarioEncontrado.Especializacion;
	                veterinarioEncontrado.TarjetaProfesional = veterinario.TarjetaProfesional != null ? veterinario.TarjetaProfesional : veterinarioEncontrado.TarjetaProfesional;
	                veterinarioEncontrado.FechaRegistro = veterinario.FechaRegistro != null ? veterinario.FechaRegistro : veterinarioEncontrado.FechaRegistro;
	                this.appContext.SaveChanges();

	            }
	            return veterinarioEncontrado;
        }


         Object ICrudRepositorio.Eliminar(int idObjeto){
            var objetoEncontrado = this.appContext.Veterinarios.FirstOrDefault(p => p.Id == idObjeto);

            if(objetoEncontrado == null) {
                return null;
            } else{
                this.appContext.Veterinarios.Remove(objetoEncontrado);
                this.appContext.SaveChanges();
                    // return null;
                return new  {response = true}; 
            }
            
        }


         Object ICrudRepositorio.ObtenerObjeto(int idObjeto){
            var objetoEncontrado = this.appContext.Veterinarios.FirstOrDefault(p => p.Id == idObjeto);
            return objetoEncontrado;
        }


        IEnumerable <Object> ICrudRepositorio.ObtenerListadoObjetos(){
           return appContext.Veterinarios;
        }



    }
}