using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar los gustos musicales de los usuarios de nuestra red social, donde tenemos aspectos como el estilo
/// musical, artista favorito, o incluso conciertos a los cuales hayan asistido.
/// </summary>
namespace EN
{
    public class GustosMusicales:Usuario
    {
        private String estilo;
        private String grupo;
        private String artista;
        private String concierto;
        private Byte decada;
      
        public GustosMusicales(String estilo,String grupo,String artista,String concierto,Byte decada,String email):base(email){
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
        public Byte Decada
        {
            get { return decada; }
            set { decada = value; }
        }
    }
}