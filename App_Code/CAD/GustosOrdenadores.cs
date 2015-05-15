using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Clase para interactuar con la tabla de GustosOrdenadores en la BDs 
/// </summary>
namespace CAD
{
    public class GustosOrdenadores
    {
        private static Conexion conexion = new Conexion();
        //metodo para crear un nuevo Gusto en la tabla 
        public void create(EN.GustosOrdenadores ordenadores)
        {
            try
            {
                String s = "Inster into GustosOrdenadores(So,Marca,Lprog,Usuario) values ('"
                    + ordenadores.Sistemaoperativo + "','" + ordenadores.Marcashw + "','" + ordenadores.Lprogramacion +
                    "','" + ordenadores.Email + "')";
                conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear el gusto Ordenadores");
            }
        }
        //metodo para eliminar un Gusto ya existente en la tabla 
        public void delete(EN.GustosOrdenadores ordenadores)
        {
            try
            {
                conexion.ejecutarS("Delete from GustosOrdenadores where Usuario='" + ordenadores.Email + "'");
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al borrar gusto Ordenadores");
            }
        }
        //metodo para leer y devolver un gusto de la tabla
        public EN.GustosOrdenadores read(String email)
        {
            EN.GustosOrdenadores ordenadores;

            try{

            string aux = null, aux1 = null, aux2 = null;

            DataRowCollection data = conexion.ejecutarR("Select * from GustosOrdenadores where Usuario='" + email + "'").Rows;

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
            ordenadores = new EN.GustosOrdenadores(aux, aux1, aux2, (String)data[0][3]);

            }catch(System.Exception e){

                throw new Exception("Error al leer el gusto");
            }
            return ordenadores;
   
        }
        //metodo para actualizar cualquier elemento de la tabla
        public void update(EN.GustosOrdenadores deleted, EN.GustosOrdenadores added)
        {
            try
            {
                String s = "Update GustosOrdenadores set So='" + added.Sistemaoperativo +
                    "', Marca='" + added.Marcashw + "', LProg='" + added.Lprogramacion + "', Usuario='" + added.Email 
                    + "' WHERE Usuario='" + deleted.Email + "'";
                conexion.ejecutarS(s);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar el gusto Ordenadores");
            }
        }

    }
}