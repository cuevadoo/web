using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar con los gustos informatios que tienen los usuarios, tanto software como hardware. Donde podremos
/// encontrar el sistema favorito del usuario o el lenguaje de programacion favorito.
/// </summary>
namespace EN
{
    public class GustosOrdenadores:Usuario
    {
        private String sistemaoperativo;
        private String marcashw;
        private String lprogramacion;

        public GustosOrdenadores(String so,String marca,String lprog, String email):base(email){
          this.sistemaoperativo = so;
          this.marcashw = marca;
          this.lprogramacion=lprog;
        }

        public String Sistemaoperativo
        {
            get { return sistemaoperativo; }
            set { sistemaoperativo = value; }
        }
        public String Marcashw
        {
            get { return marcashw; }
            set { marcashw = value; }
        }
        public String Lprogramacion
        {
            get { return lprogramacion; }
            set { lprogramacion = value; }
        }

    }
}