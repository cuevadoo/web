using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar la creacion de uno o varios grupos de amigos.
/// </summary>
namespace EN
{
    public class GrupoAmigos
    {
        private String nombreGrupo;
        private short componentes;
        private Relaciones relacion;
        
        public GrupoAmigos(String nombreGrupo, short componentes, Relaciones relacion)
        {
            this.nombreGrupo = nombreGrupo;
            this.componentes = componentes;
            this.relacion = relacion;
        }

        public String NombreGrupo
        {
            get { return nombreGrupo; }
            set { nombreGrupo = value; }
        }

        public short Componentes
        {
            get { return componentes; }
            set { componentes = value; }
        }

        public Relaciones Relacion
        {
            get { return relacion; }
            set { relacion = value; }
        }

       
    }
}