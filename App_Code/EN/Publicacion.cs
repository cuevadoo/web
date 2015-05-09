using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Publicación
/// </summary>
namespace EN
{
    public class Publicacion
    {
        private String mensaje;
        
        
        public Publicacion(String mensaje)
        {
            this.mensaje = mensaje;
            
        }

        public String Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

    }
}