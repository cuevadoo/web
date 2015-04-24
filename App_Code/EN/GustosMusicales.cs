using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Gustosmusicales
/// </summary>
namespace EN
{
    public class GustosMusicales:Usuario
    {
        private String estilo;
        private String grupo;
        private String artista;
        private String concierto;
        private byte decada;

        

        public GustosMusicales(String email,String estilo,String grupo,String artista,String concierto,byte decada):base(email){
            this.estilo = estilo;
            this.grupo = grupo;
            this.artista = artista;
            this.concierto = concierto;
            this.decada = decada;

        }

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
        public byte Decada
        {
            get { return decada; }
            set { decada = value; }
        }
    }
}