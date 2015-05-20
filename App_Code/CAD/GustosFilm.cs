using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Manejo de los gustos filmográficos de un usuario en la base de datos
/// </summary>
namespace CAD{
    public class GustosFilm{
        private static Conexion conexion = new Conexion();
        public void create(EN.GustosFilm gfilm){
            try{
                String s = "Insert into GustosFilm(Genero,Director,Decada,Actor,Pelicula,SGenero,SDirector,Serie,Usuario) values (";

                if (gfilm.Genero != null){
                    s += " '" + gfilm.Genero + "' ";
                }else{
                    s += " NULL ";
                }
                s += ",";

                if (gfilm.Director != null){
                    s += " '" + gfilm.Director + "' ";
                }else{
                    s += " NULL ";
                }
                s += ",";

                
                if (gfilm.Decada != 0){
                    s += " '" + gfilm.Decada + "' ";
                }else{
                    s += " NULL ";
                }
                s += ",";


                if (gfilm.Actor != null){
                    s += " '" + gfilm.Actor + "' ";
                }else{
                    s += " NULL ";
                }
                s += ",";

                if (gfilm.Pelicula != null){
                    s += " '" + gfilm.Pelicula + "' ";
                }else{
                    s += " NULL ";
                }
                s += ",";

                if (gfilm.S_genero1 != null){
                    s += " '" + gfilm.S_genero1 + "' ";
                }else{
                    s += " NULL ";
                }
                s += ",";

                if (gfilm.S_director1 != null){
                    s += " '" + gfilm.S_director1 + "' ";
                }else{
                    s += " NULL ";
                }
                s += ",";

                if (gfilm.Serie != null){
                    s += " '" + gfilm.Serie + "' ";
                }else{
                    s += " NULL ";
                }

                s += ",'" + gfilm.Email + "')";
                conexion.ejecutarS(s);
            }catch (System.Exception e){
                throw new Exception("Error al crear el gusto filmografico");
            }
        }

        public void delete(EN.GustosFilm gfilm){
            try{
                conexion.ejecutarS("Delete from GustosFilm where Usuario='" + gfilm.Email + "'");
            }catch (System.Exception e){
                throw new Exception("Error al borrar gusto filmografico");
            }   
        }

        public EN.GustosFilm read(String email){
            EN.GustosFilm pelis;
            try{
                string aux = null, aux1 = null,aux3 = null, aux4 = null, aux5 = null, aux6 = null, aux7 = null;
                byte aux2 = 0;
                DataRowCollection data = conexion.ejecutarR("Select * from GustosFilm where Usuario='" + email + "'").Rows;
                if (!System.DBNull.Value.Equals(data[0][0])){
                    aux = (String)data[0][0];
                }
                if (!System.DBNull.Value.Equals(data[0][1])){
                    aux1 = (String)data[0][1];
                }
                if ((Byte)data[0][2]!=0){
                    aux2 = (Byte)data[0][2];
                }
                if (!System.DBNull.Value.Equals(data[0][3])){
                    aux3 = (String)data[0][3];
                }
                if (!System.DBNull.Value.Equals(data[0][4])){
                    aux4 = (String)data[0][4];
                }
                if (!System.DBNull.Value.Equals(data[0][5])){
                    aux5 = (String)data[0][5];
                }
                if (!System.DBNull.Value.Equals(data[0][6])){
                    aux6 = (String)data[0][6];
                }
                if (!System.DBNull.Value.Equals(data[0][7])){
                    aux7 = (String)data[0][7];
                }

                pelis = new EN.GustosFilm(aux, aux1, aux2, aux3, aux4, aux5, aux6, aux7,(String)data[0][8]);

            }catch(System.Exception ex){
                throw new Exception("Error al leer gusto filmográfico");
            }
            return pelis;
        }

        public void update(EN.GustosFilm deleted, EN.GustosFilm added){
            //Genero,Director,Decada,Actor,Pelicula,SGenero,SDirector,Serie,Usuario
            try{
                bool entra = false;
                String s = "Update GustosFilm set ";
                if (added.Genero != null){
                    s += "Genero='" + added.Genero + "'";
                    entra = true;
                }

                if (added.Director != null){
                    if (entra){
                        s += ", ";
                    }
                    s += "Director='" + added.Director + "'";
                    entra = true;
                }

                if (added.Decada != 0){
                    if(entra){
                       s+=", ";
                    }
                    s += "Decada='" + added.Decada + "'";
                    entra = true;
                }

                if (added.Actor != null){
                    if (entra){
                        s += ", ";
                    }
                    s += "Actor='" + added.Actor + "'";
                    entra = true;
                }

                if (added.Pelicula != null){
                    if (entra){
                        s += ", ";
                    }
                    s += "Pelicula='" + added.Pelicula + "'";
                    entra = true;
                }

                if (added.S_genero1 != null){
                    if (entra){
                        s += ", ";
                    }
                    s += "SGenero='" + added.S_genero1 + "'";
                    entra = true;
                }

                if (added.S_genero1 != null){
                    if (entra){
                        s += ", ";
                    }
                    s += "SGenero='" + added.S_genero1 + "'";
                    entra = true;
                }

                if (added.S_director1 != null){
                    if (entra){
                        s += ", ";
                    }
                    s += "SDirector='" + added.S_director1 + "'";
                    entra = true;
                }

                if (added.Serie != null){
                    if (entra){
                        s += ", ";
                    }
                    s += "Serie='" + added.Serie + "'";
                    entra = true;
                }

                s += " WHERE Usuario='" + deleted.Email + "'";
                if (entra)
                { conexion.ejecutarS(s); }
            }catch (Exception e){
                throw new Exception("Error al modificar el gusto filmográfico");
            }
        }
    }
}