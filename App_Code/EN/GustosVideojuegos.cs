using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de GustosVideojuegos
/// </summary>
namespace EN
{
    public class GustosVideojuegos:Usuario
    {
        private String genero;
        private String juegoFav;
        private String consolaFav;
        private String desarrolladorFav;

        public GustosVideojuegos(String genero, String juegoFav, String consolaFav, String desarolladorFav)
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