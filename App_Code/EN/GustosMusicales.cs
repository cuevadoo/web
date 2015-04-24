using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Gustosmusicales
/// </summary>
namespace EN
{
    public class GustosMusicales
    {
        private String estilo;
        private String grupo;
        private String artista;
        private String concierto;

        public String Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }
        public String Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        public String Artista
        {
            get { return artista; }
            set { artista = value; }
        }
        public String Concierto
        {
            get { return concierto; }
            set { concierto = value; }
        }

    }
}