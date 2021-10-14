using System;
using Veterinaria.App.Dominio;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
// using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioCuidador: ICrudRepositorio
    {

        private readonly AppContext appContext;

        public RepositorioCuidador(AppContext appContext){
            this.appContext = appContext;
        }

       
          Object ICrudRepositorio.Agregar(Object objeto){
             EntidadCuidador cuidador = (EntidadCuidador) objeto;
             cuidador.FechaRegistro = DateTime.Now;
             var objetoAgregado = this.appContext.Cuidadores.Add(cuidador); 
             this.appContext.SaveChanges();
             return objetoAgregado.Entity;   
         }

         Object ICrudRepositorio.Editar(Object objeto){
          
            EntidadCuidador cuidador = (EntidadCuidador) objeto;
    
            var cuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault(p => p.Id == cuidador.Id);
	            if (cuidadorEncontrado != null)
	            {}
	            return cuidadorEncontrado;
        }


          Object ICrudRepositorio.EditarCampo(Object objeto){
          
            EntidadCuidador cuidador = (EntidadCuidador) objeto;

            var cuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault(p => p.Id == cuidador.Id);
	            if (cuidadorEncontrado != null)
	            {
	               cuidadorEncontrado.Nombre = cuidador.Nombre != null ? cuidador.Nombre : cuidadorEncontrado.Nombre;
	                cuidadorEncontrado.Edad = cuidador.Edad != null ? cuidador.Edad : cuidadorEncontrado.Edad;
	                cuidadorEncontrado.Telefono = cuidador.Telefono != null ? cuidador.Telefono : cuidadorEncontrado.Telefono;
	                cuidadorEncontrado.Direccion = cuidador.Direccion != null ? cuidador.Direccion : cuidadorEncontrado.Direccion;
	                cuidadorEncontrado.Correo = cuidador.Correo != null ? cuidador.Correo : cuidadorEncontrado.Correo;
	                cuidadorEncontrado.Contrasenia = cuidador.Contrasenia != null ? cuidador.Contrasenia : cuidadorEncontrado.Contrasenia;	                
	                cuidadorEncontrado.FechaRegistro = cuidador.FechaRegistro != null ? cuidador.FechaRegistro : cuidadorEncontrado.FechaRegistro;
	                this.appContext.SaveChanges();
	            }
	            return cuidadorEncontrado;
        }


         Object ICrudRepositorio.Eliminar(int idObjeto){
            var objetoEncontrado = this.appContext.Cuidadores.FirstOrDefault(p => p.Id == idObjeto);

            if(objetoEncontrado == null) {
                return null;
            } else{
                this.appContext.Cuidadores.Remove(objetoEncontrado);
                this.appContext.SaveChanges();
                    // return null;
                return new  {response = true}; 
            }            
        }

         Object ICrudRepositorio.ObtenerObjeto(int idObjeto){
            var objetoEncontrado = this.appContext.Cuidadores.FirstOrDefault(p => p.Id == idObjeto);
            return objetoEncontrado;
        }

        public Object ObtenerConMascotas(int idObjeto){
            var objetoEncontrado = this.appContext.Cuidadores.Include("Mascotas").FirstOrDefault(p => p.Id == idObjeto);
            return objetoEncontrado;
        }


        IEnumerable <Object> ICrudRepositorio.ObtenerListadoObjetos(){
           return appContext.Cuidadores;
        }



    }
}