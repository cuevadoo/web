using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de relaciones
/// </summary>
namespace EN
{
    public class relaciones
    {
        private Usuario usuario1;
        private Usuario usuario2;

        public Usuario Usuario1
        {
            get { return usuario1; }
            set { usuario1 = value; }
        }
        public Usuario Usuario2
        {
            get { return usuario2; }
            set { usuario2 = value; }
        }
    }
}