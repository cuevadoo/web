﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Clase para manejar las publicaciones de los usuarios
/// </summary>
namespace CAD
{
    public class Publicacion
    {
        private static Conexion conexion = new Conexion();
        //metodo para crear una publicación en la tabla 
        public void create(EN.Publicacion Publi)
        {
            try
            {
                String s = "Insert into Publicacion(Fecha,Mensaje,Usuario) values ('"+Publi.Date.imprimirSql()+"','"+Publi.Mensaje+"','"+Publi.Email+"')";
                conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear una publicacion");
            }
        }
        //metodo para eliminar una publicación ya existente en la tabla 
        public void delete(EN.Publicacion Publi)
        {
            try
            {
                conexion.ejecutarS("Delete from Publicacion where Usuario='" + Publi.Email + "'");
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear una publicacion");
            }    
        }
        //metodo para leer y devolver una publicación de la tabla
        public EN.Publicacion read(String email)
        {
            EN.Publicacion Publi;
            Fecha date = new Fecha();
            
            try
            {
                DataRowCollection data = conexion.ejecutarR("Select * from Publicacion where Usuario='" + email + "'").Rows;
                date.traducirSql((DateTime)data[0][0]);
                Publi = new EN.Publicacion(date, (String)data[0][1], (String)data[0][2]);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al leer la publicacion");
            }
            return Publi;
        }
    }
}