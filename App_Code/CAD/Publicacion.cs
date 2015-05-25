using System;
using System.Collections.Generic;
using System.Collections;
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
                throw new Exception("Error al borrar una publicacion");
            }    
        }
        //metodo para leer y devolver todas las publicaciones para un usuario
        public ArrayList read(String email){

            ArrayList list = new ArrayList();
            EN.Publicacion publi;
            Fecha date = new Fecha();
            EN.Relaciones aux = new Relaciones().read(email);
            try{
                foreach(String s in aux.Usuarios){
                    if(aux.isAceptada(s)){
                        DataRowCollection data = conexion.ejecutarR("Select * from Publicacion where Usuario='" + s + "'").Rows;
                        foreach(DataRow row in data){
                            date.traducirSql((DateTime)row[0]);
                            publi = new EN.Publicacion(date, (String)row[1], (String)row[2]);
                            list.Add(publi);
                        }
                    }
                }
            }
            catch (System.Exception e){
                throw new Exception("Error al leer las publicaciones");
            }
            return list;
        }
    }
}