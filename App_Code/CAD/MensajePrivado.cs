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
            try
            {
           //     String s = "Inster into MensajePrivado(Usuario, Texto) values ('"
             //       + mPrivado.Usuario + "','" + mPrivado.Texto + "')";
              //  conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear el mensaje privado");
            }
        }
        public void delete(EN.MensajePrivado mPrivado)
        {
            try
            {
           //     conexion.ejecutarS("Delete from MensajePrivado where Email='" + mPrivado.Email + "'");
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al borrar gusto");
            }
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