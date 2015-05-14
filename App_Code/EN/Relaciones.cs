using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar con la creacion de relación entre dos usuarios. Donde se basará basicamente en poder agregar a 
/// otros usuarios.
/// </summary>
namespace EN
{
    public class Relaciones
    {
        private Usuario usuario1;
        private String[] usuarios;
        private bool aceptada;

        public Usuario Usuario1{
            get { return usuario1; }
            set { usuario1 = value; }
        }

        public String[] Usuario2{
            get { return usuarios; }
            set { usuarios = value; }
        }

        public Relaciones(Usuario usuario1, String[] usuarios,bool aceptada){
            this.usuario1 = usuario1;
            this.usuarios = usuarios;
            this.aceptada = aceptada;
        }

    }
}