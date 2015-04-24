using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de MensajeDifusion
/// </summary>
namespace EN
{
    public class MensajeDifusion
    {
        private String mensaje;
        private String asunto;
        private GrupoAmigos grupo;
        
        public MensajeDifusion(String mensaje, String asunto, GrupoAmigos grupo)
        {
            this.mensaje = mensaje;
            this.asunto = asunto;
            this.grupo = grupo;
        }

        public String Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public String Asunto
        {
            get { return asunto; }
            set { asunto = value; }
        }

        public GrupoAmigos Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

    }
}