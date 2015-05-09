using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Notificaciones
/// </summary>
namespace EN
{
    public class RegistroActividad
    {
        
        private Publicacion publicacion;
        private MensajePrivado menprivado;

        public RegistroActividad(Publicacion publicacion, MensajePrivado menprivado)
        {           
            this.publicacion = publicacion;
            this.menprivado = menprivado;
        }

        public Publicacion Publicacion
        {
            get { return publicacion; }
            set { publicacion = value; }
        }

        public MensajePrivado Menprivado
        {
            get { return menprivado; }
            set { menprivado = value; }
        }

    }
}