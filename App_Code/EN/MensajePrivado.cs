using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de MensajesPrivados
/// </summary>
namespace EN
{
    public class MensajePrivado
    {
        private Usuario usuario;

        private String texto;

        public MensajePrivado(Usuario usuario, String texto)
        {
            this.usuario = usuario;
            this.texto = texto;
        }
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Texto
        {
            get { return texto; }
            set { texto = value; }
        }

    }
}