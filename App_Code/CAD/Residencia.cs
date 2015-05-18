using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


/// <summary>
/// Descripción breve de Residencia
/// </summary>

namespace CAD
{
    public class Residencia
    {
        private static Conexion conexion = new Conexion();
        public void create(EN.Residencia res)
        {
            try
            {
                String s = "Insert into Residencia(Pais,CAutonoma,Localidad,Usuario) values ('"
                    + res.Pais + "','" + res.CAutonoma + "','" + res.Localidad + "','" + res.Email + "')";
                conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear la residencia");
            }
        }

        public void delete(EN.Residencia res)
        {
            try
            {
                conexion.ejecutarS("Delete from Residencia where Usuario='" + res.Email + "'");
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al borrar residencia");
            }
        }

        public EN.Residencia read(String email)
        {
            EN.Residencia res;

            try
            {
                String aux = null, aux1 = null, aux2 = null;

                DataRowCollection data = conexion.ejecutarR("Select * from Residencia where Usuario='" + email + "'").Rows;

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
                
                res = new EN.Residencia(aux, aux1, aux2, (String)data[0][3]);

            }
            catch (System.Exception e)
            {

                throw new Exception("Error al leer los datos de residencia");
            }
            return res;
        }
        public void update(EN.Residencia deleted, EN.Residencia added)
        {
            try
            {
                bool entra=false;
                String s = "Update Residencia set ";
                     if(added.Pais!=null){
                        s += "Pais='" + added.Pais + "'";
                        entra = true;
                    }

                    if(entra==true)
                    {
                    s+="','";
                    entra = false;
                    }

                    if(added.Localidad!=null){
                        s += "Localidad='" + added.Localidad + "'";
                        entra = true;
                    }
                    if (entra == true)
                    {
                        s += "','";
                        entra = false;
                    }
                    if (added.CAutonoma != null)
                    {
                        s += "CAutonoma='" + added.CAutonoma + "'";
                        entra = true;
                    }
                    if (entra == true)
                    {
                        s += "','";
                        entra = false;
                    }

                    if(added.Email!=null){
                        s += "Email='" + added.Email + "'";
                    }
                
                s+="' WHERE Usuario='" + deleted.Email + "'";
                conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al modificar la residencia");
            }
        }
    }
}