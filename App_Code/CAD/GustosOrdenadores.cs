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
                String s = "Insert into GustosOrdenadores(Sistemaoperativo,Marcashw,Lprogramacion,Usuario) values (";
                if (ordenadores.Sistemaoperativo != null)
                {
                    s += " '" + ordenadores.Sistemaoperativo + "' ";
                }else{
                    s += " NULL ";
                }
                s+=",";
                if (ordenadores.Marcashw != null)
                {
                    s += " '" + ordenadores.Marcashw + "' ";
                }else{
                    s += " NULL ";
                }
                s+=",";
                if (ordenadores.Lprogramacion != null)
                {
                    s += " '" + ordenadores.Lprogramacion + "' ";
                }else{
                    s += " NULL ";
                }
                s += ",'" + ordenadores.Email + "')";
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

            try
            {
                String aux = null, aux1 = null, aux2 = null;

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

            }
            catch (System.Exception e)
            {

                throw new Exception("Error al leer los datos de GustosOrdenadores");
            }
            return ordenadores;
   
        }
        //metodo para actualizar cualquier elemento de la tabla
        public void update(EN.GustosOrdenadores deleted, EN.GustosOrdenadores added)
        {
            try
            {
                bool entra = false;
                String s = "Update GustosOrdenadores set ";
                if (added.Sistemaoperativo != null)
                {
                    s += "Sistemaoperativo='" + added.Sistemaoperativo + "'";
                    entra = true;
                }
                if (added.Marcashw != null)
                {
                    if (entra)
                    {
                        s += ", ";
                    }
                    s += "Marcashw='" + added.Marcashw + "'";
                    entra = true;
                }
                if (added.Lprogramacion != null)
                {
                    if (entra)
                    {
                        s += ", ";
                    }
                    s += "Lprogramacion='" + added.Lprogramacion + "'";
                    entra = true;
                }
                s += " WHERE Usuario='" + deleted.Email + "'";
                if (entra)
                { conexion.ejecutarS(s); }
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar el gusto Ordenadores");
            }
        }

    }
}