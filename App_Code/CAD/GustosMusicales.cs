using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


/// <summary>
/// Clase que contiene los gustos musicales de un usuario y donde podremos agregar,modificar, eliminar o leer datos de la BD 
/// </summary>
namespace CAD
{
    public class GustosMusicales
    {
        private static Conexion conexion = new Conexion();
        //metodo para crear un nuevo Gusto en la tabla 
        public void create(EN.GustosMusicales gmusic)
        {
            try
            {
                String s = "Inster into GustosMusicales(Estilo,Grupo,Artista,Concierto,Decada,Usuario) values ('" 
                    + gmusic.Estilo + "','" + gmusic.Grupo + "','" + gmusic.Artista + "','" + gmusic.Concierto + "'," + gmusic.Decada + ",'" + gmusic.Email + "')";
                conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear el gusto musical");
            }
        }
        //metodo para eliminar un Gusto ya existente en la tabla 
        public void delete(EN.GustosMusicales gmusic)
        {
            try
            {
                conexion.ejecutarS("Delete from GustosMusicales where Usuario='" + gmusic.Email + "'");
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al borrar gusto musical");
            }
        }
        //metodo para leer y devolver un gusto de la tabla
        public EN.GustosMusicales read(String email)
        {
            string aux = null, aux1 = null, aux2 = null, aux3=null;

            DataRowCollection data = conexion.ejecutarR("Select * from GustosMusicales where Usuario='" + email + "'").Rows;
            if (!System.DBNull.Value.Equals(data[0][0]))
            {
                aux = (String)data[0][0];
            }
            if (!System.DBNull.Value.Equals(data[0][1]))
            {
                aux1 = (String)data[0][1];
            }
            if (!System.DBNull.Value.Equals(data[0][2]))
            {
                aux2 = (String)data[0][2];
            }
            if (!System.DBNull.Value.Equals(data[0][3]))
            {
                aux3 = (String)data[0][3];
            }
            return null;
        }
        //metodo para actualizar cualquier elemento de la tabla
        public void update(EN.GustosMusicales deleted, EN.GustosMusicales added)
        {
            try
            {
                String s = "Update Gustosgmusic set Estilo='" + added.Estilo +"',set Grupo='"+added.Grupo+"',set Artista='"+added.Artista+
                    "', set Concierto='"+added.Concierto+"', set Decada="+added.Decada+", Usuario='" + added.Email
                    + "' WHERE Email='" + deleted.Email + "'";
                conexion.ejecutarS(s);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar el gusto musical");
            }
        }
    }
}