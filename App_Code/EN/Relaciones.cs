﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de relaciones
/// </summary>
namespace EN
{
    public class Relaciones
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

        public Relaciones(Usuario usuario1, Usuario usuario2){
            this.usuario1 = usuario1;
            this.usuario2 = usuario2;
        }

    }
}