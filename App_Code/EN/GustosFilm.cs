using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar los gustos filmográficos que tienen los usuarios de nuestra red social. Donde podrán indicar cual
/// es su genero favorito, su pelicula, su actor. Incluso también podrán indicar cual es su serie favorita.
/// </summary>
namespace EN
{
    public class GustosFilm:Usuario
    {
        private String genero;
        private String director;
        private byte decada;
        private String actor;
        private String pelicula;
        private String Sgenero;
        private String Sdirector;
        private String serie;

        public GustosFilm(String email,String genero,String director,byte decada,String actor,String pelicula,String Sgenero,String Sdirector,String serie):base(email){
            this.genero = genero;
            this.director = director;
            this.decada = decada;
            this.actor = actor;
            this.pelicula = pelicula;
            this.Sgenero = Sgenero;
            this.Sdirector = Sdirector;
            this.serie = serie;
        } 
        
        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public String Director
        {
            get { return director; }
            set { director = value; }
        }
        public byte Decada
        {
            get { return decada; }
            set { decada = value; }
        }
        public String Actor
        {
            get { return actor; }
            set { actor = value; }
        }
        public String Pelicula
        {
            get { return pelicula; }
            set { pelicula = value; }
        }
        public String S_genero1
        {
            get { return Sgenero; }
            set { Sgenero = value; }
        }

        public String S_director1
        {
            get { return Sdirector; }
            set { Sdirector = value; }
        }
        public String Serie
        {
            get { return serie; }
            set { serie = value; }
        }

    }
}