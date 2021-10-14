using System;
using System.Collections.Generic;

namespace Veterinaria.App.Dominio
{
    public class EntidadCuidador: EntidadPersona
    {
        public List<EntidadMascota> Mascotas {get; set;}
    }
}