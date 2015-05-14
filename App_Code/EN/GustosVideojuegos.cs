using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar los tipos de videojuegos y consolas que prefieren nuestro usuarios de la red social. Podremos 
/// encontrar el genero de videojuegos que mas nos gusta, nuestro juego favorito y también nuestra consola favorita, incluyendo a una
/// empresa dedicada a desarrollar videojuegos.
/// </summary>
namespace EN
{
    public class GustosVideojuegos:Usuario
    {
        private String genero;
        private String juegoFav;
        private String consolaFav;
        private String desarrolladorFav;

        public GustosVideojuegos(String genero, String juegoFav, String consolaFav, String desarrolladorFav, String email):base(email)
        {
            this.genero = genero;
            this.juegoFav = juegoFav;
            this.consolaFav = consolaFav;
            this.desarrolladorFav = desarrolladorFav;
        }

        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public String ConsolaFav
        {
            get { return consolaFav; }
            set { consolaFav = value; }
        }
        public String JuegoFav
        {
            get { return juegoFav; }
            set { juegoFav = value; }
        }
        public String DesarrolladorFav
        {
            get { return desarrolladorFav; }
            set { consolaFav = value; }
        }
    }
}