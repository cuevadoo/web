using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Clase para manejar los mensajes privados enviados entre usuarios ( parte privada )
/// </summary>
namespace CAD
{
    public class MensajePrivado
    {
        private static Conexion conexion = new Conexion();
        public void create(EN.MensajePrivado mPrivado)
        {

        }
        public void delete(EN.MensajePrivado mPrivado)
        {

        }
        public EN.Usuario read(String email)
        {
            return null;
        }
        public void update(EN.MensajePrivado deleted, EN.MensajePrivado added)
        {

        }
    }
}