using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Clase para interactuar con la tabla de GustosVideojuegos en la BDs 
/// </summary>
namespace CAD
{
    public class GustosVideojuegos
    {
        private static Conexion conexion = new Conexion();
        //metodo para crear un nuevo Gusto en la tabla 
        public void create(EN.GustosVideojuegos videojuegos)
        {
            try
            {
                String s = "Insert into GustosVideojuegos(Genero,Juegofav,Consolafav,Desarrolladorfav,Usuario) values (";
                if (videojuegos.Genero != null)
                {
                    s += " '" + videojuegos.Genero + "' ";
                }else
                {
                    s += " NULL ";
                }
                s += ",";
                if (videojuegos.JuegoFav != null)
                {
                    s += " '" + videojuegos.JuegoFav + "' ";
                }else
                {
                    s += " NULL ";
                }
                s += ",";
                if (videojuegos.ConsolaFav != null)
                {
                    s += " '" + videojuegos.ConsolaFav + "' ";
                }
                else
                {
                    s += " NULL ";
                }
                s += ",";
                if (videojuegos.DesarrolladorFav != null)
                {
                    s += " '" + videojuegos.DesarrolladorFav + "' ";
                }
                else
                {
                    s += " NULL ";
                }

                s += ",'" + videojuegos.Email + "')";
                conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear el gusto Videojuegos");
            }
        }
        //metodo para eliminar un Gusto ya existente en la tabla 
        public void delete(EN.GustosVideojuegos videojuegos)
        {
            try
            {
                conexion.ejecutarS("Delete from GustosVideojuegos where Email='" + videojuegos.Email + "'");
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al borrar gusto Videojuego");
            }
        }
        //metodo para leer y devolver un gusto de la tabla
        public EN.GustosVideojuegos read(String email)
        {
            EN.GustosVideojuegos videojuegos;

            try{
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
                videojuegos = new EN.GustosVideojuegos((String)data[0][0], aux, aux1, aux2, aux3);

            }
            catch (System.Exception e)
            {

                throw new Exception("Error al leer el gusto");
            }
            return videojuegos;
        }
        //metodo para actualizar cualquier elemento de la tabla
        public void update(EN.GustosVideojuegos deleted, EN.GustosVideojuegos added)
        {
            try
            {
                bool entra = false;
                String s = "Update GustosVideojuegos set ";
                if (added.Genero != null)
                {
                    s += "Genero='" + added.Genero + "'";
                    entra = true;
                }
                if (added.JuegoFav != null)
                {
                    if (entra)
                    {
                        s += ", ";
                    }
                    s += "JuegoFav='" + added.JuegoFav + "'";
                    entra = true;
                }
                if (added.ConsolaFav != null)
                {
                    if (entra)
                    {
                        s += ", ";
                    }
                    s += "ConsolaFav='" + added.ConsolaFav + "'";
                    entra = true;
                }
                if (added.DesarrolladorFav != null)
                {
                    if (entra)
                    {
                        s += ", ";
                    }
                    s += "DesarrolladorFav='" + added.DesarrolladorFav + "'";
                    entra = true;
                }

                s += " WHERE Usuario='" + deleted.Email + "'";
                if (entra)
                { conexion.ejecutarS(s); }
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar el gusto Videojuego");
            }
        }
    }
}