using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar con los mensajes privados que podrán tener dos usuarios entre ellos.
/// </summary>
namespace EN
{
    public class MensajePrivado
    {
        private Usuario usuario1, usuario2;

        private String texto;

        private Fecha date;

        public MensajePrivado(Usuario usuario1, Usuario usuario2, String texto, Fecha fecha)
        {
            this.usuario1 = usuario1;
            this.usuario2 = usuario2;
            this.texto = texto;
            this.date = fecha;
        }

        public Usuario Usuario1
        {
            get { return usuario1; }
            set { usuario1 = value; }
        }

        public Usuario Usuario2
        {
            get { return usuario2; }
            set { usuario2 = value; }
        }

        public Fecha Date
        {
            get { return date; }
            set { date = value; }
        }

        public String Texto
        {
            get { return texto; }
            set { texto = value; }
        }

    }
}