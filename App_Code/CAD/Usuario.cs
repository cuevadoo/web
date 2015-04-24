using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
namespace CAD
{
    public class Usuario
    {
        private static Conexion conexion=new Conexion();
        public void create(EN.Usuario user){
            try{
                String s = "Insert into Usuarios values(" + user.Email+","+user.Pass+","+user.Nombre+","+user.Apellido1+
                    ","+user.Apellido2+","+user.Edad+","+user.Sexo+")";
                conexion.ejecutarS(s);
            }catch(System.Exception ex){
                throw new Exception("Error al crear usuario");
            }
        }
        public void delete(EN.Usuario user){
            try{
                conexion.ejecutarS("Delete from Usuarios where Email="+user.Email);
            }catch(System.Exception ex){
                throw new Exception("Error al borrar usuario");
            }
        }
        public EN.Usuario read(String email){
            EN.Usuario user;
            try{
                DataRowCollection data=conexion.ejecutarR("Select * from Usuarios where Email="+email).Rows;
                user = new EN.Usuario((String)data[0][0], (String)data[0][1], (String)data[0][2],
                    (String)data[0][3], (String)data[0][4], (byte)data[0][5],(bool)data[0][6]);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return user;
        }
        public void update(EN.Usuario deleted, EN.Usuario added){
            try{
                String s = "Update Usuarios set Email=" + added.Email+",Pass="+added.Pass+
                    ",Nombre="+added.Nombre+",Apellido1="+added.Apellido1+",Apellido2"+added.Apellido2+
                    ",Edad="+added.Edad+",Sexo="+added.Sexo+" where Email="+deleted.Email;
                conexion.ejecutarS(s);
            }catch(System.Exception ex){
                throw new Exception("Error al modificar usuario");
            }
        }
    }
}