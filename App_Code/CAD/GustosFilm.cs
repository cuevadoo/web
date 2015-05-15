﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Manejo de los gustos filmográficos de un usuario en la base de datos
/// </summary>
namespace CAD
{
    public class GustosFilm
    {
        private static Conexion conexion = new Conexion();
        public void create(EN.GustosFilm gfilm)
        {
            try
            {
                String s = "Inster into GustosFilm(Genero,Director,Decada,Actor,Pelicula,SGenero,SDirector,Serie,Usuario) values ('"
                    + gfilm.Genero + "','" + gfilm.Director + "'," + gfilm.Decada + ",'" + gfilm.Actor + "'," + gfilm.Pelicula + ",'" + gfilm.S_genero1 + "','" + gfilm.S_director1 + "','" + gfilm.Serie + "','" + gfilm.Email + "')";
                conexion.ejecutarS(s);
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al crear el gusto filmografico");
            }
        }
        public void delete(EN.GustosFilm gfilm)
        {
            try
            {
                conexion.ejecutarS("Delete from GustosFilm where Usuario='" + gfilm.Email + "'");
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al borrar gusto film");
            }   
        }
        public EN.GustosFilm read(String email)
        {
            EN.GustosFilm pelis;
            try
            {
                string aux = null, aux1 = null,aux3 = null, aux4 = null, aux5 = null, aux6 = null, aux7 = null, aux8 = null;
                byte aux2 = 0;
                DataRowCollection data = conexion.ejecutarR("Select * from GustosFilm where Email='" + email + "'").Rows;
                if (!System.DBNull.Value.Equals(data[0][0]))
                {
                    aux = (String)data[0][0];
                }
                if (!System.DBNull.Value.Equals(data[0][1]))
                {
                    aux1 = (String)data[0][1];
                }
                if ((Byte)data[0][2]!=0)
                {
                    aux2 = (Byte)data[0][2];
                }
                if (!System.DBNull.Value.Equals(data[0][3]))
                {
                    aux3 = (String)data[0][3];
                }
                if (!System.DBNull.Value.Equals(data[0][4]))
                {
                    aux4 = (String)data[0][4];
                }
                if (!System.DBNull.Value.Equals(data[0][5]))
                {
                    aux5 = (String)data[0][5];
                }
                if (!System.DBNull.Value.Equals(data[0][6]))
                {
                    aux6 = (String)data[0][6];
                }
                if (!System.DBNull.Value.Equals(data[0][7]))
                {
                    aux7 = (String)data[0][7];
                }
                pelis = new EN.GustosFilm(aux, aux1, aux2, aux3, aux4, aux5, aux6, aux7,(String)data[0][9]);
            }
            catch(System.Exception ex) {
                throw new Exception("Error al leer gusto");
            }
            return pelis;
        }
        public void update(EN.GustosFilm deleted, EN.GustosFilm added)
        {
            //Genero,Director,Decada,Actor,Pelicula,SGenero,SDirector,Serie,Usuario
            try
            {
                String s = "Update Gustosgmusic set Genero='" + added.Genero + "',set Director='" + added.Director + "',set Decada=" + added.Decada +
                    ", set Actor='" + added.Actor + "', set Pelicula='" + added.Pelicula + "', SGenero='" + added.S_genero1 + "', SDirector='" + added.S_director1 + "', Serie='" + added.Serie + "', Usuario='" + added.Email
                    + "' WHERE Email='" + deleted.Email + "'";
                conexion.ejecutarS(s);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar el gusto filmografico");
            }

        }

    }
}