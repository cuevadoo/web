using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descripción breve de GustosVideojuegos
/// </summary>
namespace CAD
{
    public class GustosVideojuegos
    {
        private static Conexion conexion = new Conexion();
        public void create(EN.GustosVideojuegos videojuegos)
        {
            try
            {
                String s = "Inster into GustosVideojuegos(Genero,JuegoFav,ConsolaFav,DesarrolladorFav,Email) values ('"
                    + videojuegos.Genero + "','" + videojuegos.JuegoFav + "','" + videojuegos.ConsolaFav +
                    "','" + videojuegos.DesarrolladorFav +  "','" + videojuegos.Email + "')";
                conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear el gusto");
            }
        }
        public void delete(EN.GustosVideojuegos videojuegos)
        {
            try
            {
                conexion.ejecutarS("Delete from GustosVideojuegos where Email='" + videojuegos.Email + "'");
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al borrar gusto");
            }
        }
        public EN.GustosVideojuegos read(String email)
        {
            string aux = null, aux1 = null, aux2 = null, aux3 = null;

            DataRowCollection data = conexion.ejecutarR("Select * from GustosVideojueos where Email='" + email + "'").Rows;
            if (!System.DBNull.Value.Equals(data[0][1]))
            {
                aux = (String)data[0][1];
            }
            if (!System.DBNull.Value.Equals(data[0][2]))
            {
                aux1 = (String)data[0][2];
            }
            if (!System.DBNull.Value.Equals(data[0][3]))
            {
                aux2 = (String)data[0][3];
            }
            if (!System.DBNull.Value.Equals(data[0][4]))
            {
                aux3 = (String)data[0][4];
            }
            //POR HACER
            return null;
        }
        public void update(EN.GustosVideojuegos deleted, EN.GustosVideojuegos added)
        {
            try
            {
                String s = "Update GustosVideojuegos set Genero='" + added.Genero +
                    "', JuegoFav='" + added.JuegoFav + "', ConsolaFav='" + added.ConsolaFav+ "', DesarrolladorFav='" + added.DesarrolladorFav + "', Email='" + added.Email
                    + "' WHERE Email='" + deleted.Email + "'";
                conexion.ejecutarS(s);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar el gusto");
            }
        }
    }
}