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
             var objetoAgregado = this.appContext.Veterinarios.Add(veterinario); 
             this.appContext.SaveChanges();
             return objetoAgregado.Entity;   
         }


         Object ICrudRepositorio.Editar(Object objeto){
          
            EntidadVeterinario veterinario = (EntidadVeterinario) objeto;
    
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(p => p.Id == veterinario.Id);
	            if (veterinarioEncontrado != null)
	            {
	                veterinarioEncontrado.nombre = veterinario.nombre;
	                veterinarioEncontrado.telefono = veterinario.telefono;
	                veterinarioEncontrado.edad = veterinario.edad;
	                veterinarioEncontrado.direccion = veterinario.direccion;
	                veterinarioEncontrado.correo = veterinario.correo;
	                veterinarioEncontrado.contrasenia = veterinario.contrasenia;
	                veterinarioEncontrado.fechaRegistro = DateTime.Now;;
	                this.appContext.SaveChanges();

	            }
	            return veterinarioEncontrado;
        }


          Object ICrudRepositorio.EditarCampo(Object objeto){
          
            EntidadVeterinario veterinario = (EntidadVeterinario) objeto;

            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(p => p.Id == veterinario.Id);
	            if (veterinarioEncontrado != null)
	            {
	                veterinarioEncontrado.nombre = veterinario.nombre != null ? veterinario.nombre : veterinarioEncontrado.nombre;
	                veterinarioEncontrado.edad = veterinario.edad != null ? veterinario.edad : veterinarioEncontrado.edad;
	                veterinarioEncontrado.direccion = veterinario.direccion != null ? veterinario.direccion : veterinarioEncontrado.direccion;
	                veterinarioEncontrado.correo = veterinario.correo != null ? veterinario.correo : veterinarioEncontrado.correo;
	                veterinarioEncontrado.contrasenia = veterinario.contrasenia != null ? veterinario.contrasenia : veterinarioEncontrado.contrasenia;
	                veterinarioEncontrado.fechaRegistro = veterinario.fechaRegistro != null ? veterinario.fechaRegistro : veterinarioEncontrado.fechaRegistro;
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