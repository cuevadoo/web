using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Interacción con la tabla Usuario de la base de datos, podremos crear, leer, eliminar y cambiar valores de ésta
/// </summary>
namespace CAD
{
    public class Usuario
    {
        private static Conexion conexion=new Conexion();
        public void create(EN.Usuario user){
            try{
                String s = "Insert into Usuarios (Email,Contraseña,Nombre,Apellido1,Apellido2,Edad,Sexo)values('"
                    + user.Email+"','"+user.Pass+"','"+user.Nombre+"','"+user.Apellido1+
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
            EN.Usuario user=null;
            try{
                DataRowCollection data=conexion.ejecutarR("Select * from Usuarios where Email='"+email+"'").Rows;
                Fecha f = new Fecha();
                String s=null;
                if(!System.DBNull.Value.Equals(data[0][7])){
                    s = (String)data[0][7];
                }
                f.traducirSql((DateTime)data[0][5]);
                user = new EN.Usuario((String)data[0][0], (String)data[0][1], (String)data[0][2],
                    (String)data[0][3], (String)data[0][4], f,(bool)data[0][6],s);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return user;
        }
        public void update(EN.Usuario deleted, EN.Usuario added){
            try{
                String s = "Update Usuarios set Email='" + added.Email+"', Contraseña='"+added.Pass+
                    "', Nombre='"+added.Nombre+"', Apellido1='"+added.Apellido1+"', Apellido2='"+added.Apellido2+
                    "', Edad='"+added.Edad.imprimirSql()+"', Sexo='"+added.Sexo+"', Imagen='"+added.Foto+"' WHERE Email='"+deleted.Email+"'";
                conexion.ejecutarS(s);
            }catch(Exception ex){
                throw new Exception("Error al modificar usuario");
            }
        }
        public object[] buscar(String nombre) {
            object[] obj=new object[2];
            String image = "";
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
                    obj[0] = image;
                    obj[1] = l;
                }
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }
    }
}