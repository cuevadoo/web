using System;
using System.Collections.Generic;
using System.Collections;
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
                String s = "Insert into Usuarios values('" + user.Email+"','"+user.Pass+"','"+user.Nombre+"','"+user.Apellido1+
                    "','"+user.Apellido2+"','"+user.Edad.imprimirSql()+"','"+user.Sexo+"')";
                conexion.ejecutarS(s);
            }catch(System.Exception ex){
                throw new Exception("Error al crear usuario");
            }
        }
        public void delete(EN.Usuario user){
            try{
                conexion.ejecutarS("Delete from Usuarios where Email='"+user.Email+"'");
            }catch(System.Exception ex){
                throw new Exception("Error al borrar usuario");
            }
        }
        public EN.Usuario read(String email){
            EN.Usuario user;
            try{
                DataRowCollection data=conexion.ejecutarR("Select * from Usuarios where Email='"+email+"'").Rows;
                Fecha f = new Fecha();
                f.traducirSql((String)data[0][5]);
                user = new EN.Usuario((String)data[0][0], (String)data[0][1], (String)data[0][2],
                    (String)data[0][3], (String)data[0][4], f,(bool)data[0][6]);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return user;
        }
        public void update(EN.Usuario deleted, EN.Usuario added){
            try{
                String s = "Update Usuarios set Email='" + added.Email+"',Pass='"+added.Pass+
                    "',Nombre='"+added.Nombre+"',Apellido1='"+added.Apellido1+"',Apellido2='"+added.Apellido2+
                    "',Edad='"+added.Edad.imprimirSql()+"',Sexo='"+added.Sexo+"' where Email='"+deleted.Email+"'";
                conexion.ejecutarS(s);
            }catch(System.Exception ex){
                throw new Exception("Error al modificar usuario");
            }
        }
        public object[] buscar(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Nombre,Apellido1,Apellido2 From Usuarios Where Nombre Like '"+
                    nombre+"%' OR Apellido1 Like '"+nombre+"%' OR Apellido2 Like '"+nombre+"%'";
                DataRowCollection data=conexion.ejecutarR(s).Rows;
                ArrayList l = new ArrayList();
                try {
                    int i=0;
                    while(true){
                        String aux = data[i][0]+" "+data[i][1]+" "+data[i][2];
                        l.Add(aux);
                        i++;
                    }
                }catch(System.Exception ex){
                    obj[1] = l;
                }
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }
    }
}