using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


/// <summary>
/// Clase que contiene los gustos musicales de un usuario y donde podremos agregar,modificar, eliminar o leer datos de la BD 
/// </summary>
namespace CAD
{
    public class GustosMusicales
    {
        private static Conexion conexion = new Conexion();
        //metodo para crear un nuevo Gusto en la tabla 
        public void create(EN.GustosMusicales gmusic)
        {
            try
            {
                String s = "Insert into GustosMusicales(Estilo,Grupo,Artista,Concierto,Decada,Usuario) values (";

                if (gmusic.Estilo != null)
                {
                    s += " '" + gmusic.Estilo + "' ";
                }
                else
                {
                    s += " NULL ";
                }
                s += ",";
                if (gmusic.Grupo != null)
                {
                    s += " '" + gmusic.Grupo + "' ";
                }
                else
                {
                    s += " NULL ";
                }
                s += ",";
                if (gmusic.Artista != null)
                {
                    s += " '" + gmusic.Artista + "' ";
                }
                else
                {
                    s += " NULL ";
                }
                s += ",";
                if (gmusic.Concierto != null)
                {
                    s += " '" + gmusic.Concierto + "' ";
                }
                else
                {
                    s += " NULL ";
                }
                s += ",";
                if (gmusic.Decada != 0)
                {
                    s += " '" + gmusic.Decada + "' ";
                }
                else
                {
                    s += " NULL ";
                }

                s += ",'" + gmusic.Email + "')";
                conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear el gusto Musical");
            }
        }
        //metodo para eliminar un Gusto ya existente en la tabla 
        public void delete(EN.GustosMusicales gmusic)
        {
            try
            {
                conexion.ejecutarS("Delete from GustosMusicales where Usuario='" + gmusic.Email + "'");
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al borrar gusto Musical");
            }
        }
        //metodo para leer y devolver un gusto de la tabla
        public EN.GustosMusicales read(String email)
        {
            EN.GustosMusicales gmusic;
           
            try{
                String aux = null, aux1 = null, aux2 = null, aux3 = null;
                byte aux4 = 0;

                DataRowCollection data = conexion.ejecutarR("Select * from GustosMusicales where Usuario='" + email + "'").Rows;
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
                if (!System.DBNull.Value.Equals(data[0][3]))
                {
                    aux3 = (String)data[0][3];
                }
                if ((Byte)data[0][4]!=0)
                {
                    aux4 = (Byte)data[0][4];
                }
                gmusic = new EN.GustosMusicales(aux, aux1, aux2, aux3, aux4, (String)data[0][5]);

                }catch(System.Exception e){

                    throw new Exception("Error al leer el gusto Musical");
                }
                return gmusic;
        }
        //metodo para actualizar cualquier elemento de la tabla
        public void update(EN.GustosMusicales deleted, EN.GustosMusicales added)
        {

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
   
           /* try
            {
                String s = "Update Gustosgmusic set Estilo='" + added.Estilo +"',set Grupo='"+added.Grupo+"',set Artista='"+added.Artista+
                    "', set Concierto='"+added.Concierto+"', set Decada="+added.Decada+", Usuario='" + added.Email
                    + "' WHERE Email='" + deleted.Email + "'";
                conexion.ejecutarS(s);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar el gusto Musical");
            }*/
        }
    }
}