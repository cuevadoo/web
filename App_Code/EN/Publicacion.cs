using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar con la posibilidad de realizar publicaciones en cualquier momento, para que todos tus amigos
/// puedan verlo, mediante su respectivo registro de actividad.
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