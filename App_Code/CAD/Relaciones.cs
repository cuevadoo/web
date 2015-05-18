using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Clase para manejar las relaciones entre usuarios
/// </summary>
namespace CAD
{
    public class Relaciones
    {
        private static Conexion conexion = new Conexion();

        public EN.Relaciones read(String email){
            EN.Relaciones relacion=null;
            try{
                DataRowCollection data=conexion.ejecutarR("Select * from Amigos where Usuario1 ='"+email+"' OR Usuario2 = '"+email+"'").Rows;
                EN.Relaciones rel = new EN.Relaciones(email);
                foreach(DataRow r in data){
                    if((String)r[0]==email){
                        rel.add((String)r[1],(bool)r[2],true);
                    }else{
                        rel.add((String)r[0],(bool)r[2],false);
                    }
                }
                relacion = rel;
            }catch(System.Exception ex){
                throw new Exception("Error al leer las relaciones");
            }
            return relacion;
        }
        /// <summary>
        /// Este funcinoa como el create, el delete y el update
        /// </summary>
        public void update(EN.Relaciones added,EN.Relaciones deleted){
            try {
                if(added.Usuario1!=deleted.Usuario1){
                    //Cambiar el email de todas las entradas
                    String s = "Update Amigos set Usuario1='"+added.Usuario1+"' where Usuario1='"+deleted.Usuario1+"';"+
                        "Update Amigos set Usuario2='"+added.Usuario1+"' where Usuario2='"+deleted.Usuario1+"';";
                    conexion.ejecutarS(s);
                }
                EN.Relaciones aux = read(added.Usuario1);
                EN.Relaciones[] aux2 = added.diferencias(aux);
                foreach(String user in aux2[0].Usuarios){
                    //Borrar una relacion
                    conexion.ejecutarS("Delete from Amigos where Usuario1='" + user + "' OR Usuario2='"+user+"'");
                }
                foreach(String user in aux2[1].Usuarios){
                    //Añadir una relacion
                    conexion.ejecutarS("Insert into Amigos values('"+aux2[1].Usuario1+"','"+user+"','False')");
                }
                foreach (String user in aux2[2].Usuarios){
                    //Modificar si ha sido aceptada
                    conexion.ejecutarS("Update Amigos set Aceptada='" + aux2[2].isAceptada(user) + "' where Usuario1='"+ 
                        user + "' AND Usuario2='" + aux2[2].Usuario1 + "'");
                }
            }catch(System.Exception ex){
                throw new Exception("Error al cambiar alguna relacion");
            }
        }
    }
}