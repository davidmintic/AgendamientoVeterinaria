using System;

namespace Veterinaria.App.Dominio
{
    public class EntidadPersona
    {
       public int Id {get; set;}
       public String nombre {get; set;}
       public String telefono {get; set;}
       public int edad {get; set;}
       public String direccion {get; set;}
       public String correo {get; set;}
       public String contrasenia {get; set;}  
       public DateTime fechaRegistro {get; set;} 
        
    }
}