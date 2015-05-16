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
    public class Publicacion:Usuario
    {
        private String mensaje;
        private DateTime dateTime;
 
        public Publicacion(String mensaje,DateTime date,String email): base(email)
        {
            this.mensaje = mensaje;
            this.date = date;
            
        }

        public String Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }


        public DateTime date {
            get { return date; }
            set { date = value; }
        }
        }
}