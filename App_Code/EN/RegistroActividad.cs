using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar el Registro de Actividad de nuestra red social, donde se mostraran las publicaciones de los usuarios
/// y el aviso de los mensajes privados
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