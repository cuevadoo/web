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
                String s = "Insert into MensajePrivado(Usuario1, Usuario2, Texto, Fecha) values ('"
                 + mPrivado.Usuario1 + "','" + mPrivado.Usuario2 + "'";
                      
                 if (mPrivado.Texto != null)
                {
                    s += ",'" + mPrivado.Texto + "' ";
                }else{
                    s += ", NULL ";
                }
                s += ",'" + mPrivado.Date.imprimirSql() + "')";
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
                throw new Exception("Error al borrar mensaje privado");
            }
        }
        //método para leer un mensaje de la BDs
        public ArrayList read(String email)
        {
            ArrayList array = new ArrayList();
            try{
                DataRowCollection data = conexion.ejecutarR("Select * from MensajePrivado where Usuario2= '" + email + "' ").Rows;
                 foreach (DataRow row in data){
                     Fecha date = new Fecha();
                     String s=null;
                     if(!System.DBNull.Value.Equals(row[2])){
                         s = (String)row[2];
                     }
                     date.traducirSql((DateTime)row[3]);
                     array.Add(new EN.MensajePrivado((String)row[0], (String)row[1], s,date));
                 }
             }catch(System.Exception e){
                 throw new Exception("Error al leer el mensajes privados");
             }
            return array;
        }
    }
}