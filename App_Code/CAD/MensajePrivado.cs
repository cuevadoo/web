using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Clase para manejar los mensajes privados enviados entre usuarios ( parte privada )
/// </summary>
namespace CAD
{
    public class MensajePrivado
    {
        private static Conexion conexion = new Conexion();
        //metodo para crear un nuevo mensaje privado en la BDs
        public void create(EN.MensajePrivado mPrivado)
        {
            try
            {
               String s = "Inster into MensajePrivado(Usuario, Texto) values ('"
                + mPrivado.Usuario1 + "','" + mPrivado.Usuario2 + "','" + mPrivado.Texto + "')" + mPrivado.Date.imprimirSql() + "')";
               conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear el mensaje privado");
            }
        }
        //método para eliminar un mensaje privado ya existente en la BDs
        public void delete(EN.MensajePrivado mPrivado)
        {
            try
            {
                conexion.ejecutarS("Delete from MensajePrivado where Usuario1='" + mPrivado.Usuario1 + "'and Usuario2='" + mPrivado.Usuario2 
                + "'and Fecha='" + mPrivado.Date.imprimirSql() + "'");
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al borrar gusto");
            }
        }
        //método para leer un mensaje de la BDs
        public EN.Usuario read(String email)
        {
          /*  EN.MensajePrivado mPrivado;

             try{

                 DataRowCollection data=conexion.ejecutarR("Select * from Usuarios where Usuario1='" + mPrivado.Usuario1 + "'and Usuario2='" + mPrivado.Usuario2 
                + "'and Fecha='" + mPrivado.Date.imprimirSql() + "'").Rows;

                 Fecha date = new Fecha();
                 String s=null;

                 if(!System.DBNull.Value.Equals(data[0][2])){
                     s = (String)data[0][2];
                 }

                 date.traducirSql((DateTime)data[0][3]);
                 mPrivado = new EN.MensajePrivado((String)data[0][0], (String)data[0][1], s,
                     date);
             }catch(System.Exception ex){
                 throw new Exception("Error al leer usuario");
             }
             return mPrivado;*/
            return null;
        }
        //método para cambiar un mensaje contenido en la BDs
        public void update(EN.MensajePrivado deleted, EN.MensajePrivado added)
        {

        }
    }
}