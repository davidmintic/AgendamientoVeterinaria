using System;
using System.Collections.Generic;

namespace Veterinaria.App.Persistencia
{
    public interface ICrudRepositorio
    {
        public Object Agregar(Object objeto);
        public Object Editar(Object objeto);
        public Object EditarCampo(Object objeto);
        public Object Eliminar(int idObjeto);
        public Object ObtenerObjeto(int idObjeto);
        public IEnumerable<Object> ObtenerListadoObjetos();

        

    }
}