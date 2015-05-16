using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// En esta clase implementa un sistema de búsqueda en la base de datos
/// </summary>
namespace CAD{
    public class Buscador{
        private static Conexion conexion = new Conexion();
        
        ///////////////////////////////////////////
        // Modulo para meter los datos, comun al //
        // resto de los modulos de esta clase    //
        ///////////////////////////////////////////

        public object[] meterDatos(DataRowCollection data) {
            object[] obj=new object[2];
            try{
                ArrayList nom = new ArrayList();
                ArrayList email = new ArrayList();
                try {
                    int i=0;
                    while(true){
                        String aux = data[i][2]+" "+data[i][3]+" "+data[i][4];
                        nom.Add(aux);
                        email.Add(data[i][0]);
                        i++;
                    }
                }catch(System.Exception ex){
                    obj[0] = email;
                    obj[1] = nom;
                }
            }catch(System.Exception ex){
                throw ex;
            }
            return obj;
        }

        /////////////////////
        // Busqueda basica //
        /////////////////////

        public object[] buscarSin(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select * From Usuarios Where Nombre Like '"+
                    nombre+"%' OR Apellido1 Like '"+nombre+"%' OR Apellido2 Like '"+nombre+"%'";
                obj=meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        ///////////////////////////
        // Busquedas de Usuarios //
        ///////////////////////////

        public object[] buscarNombre(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select * From Usuarios Where Nombre Like '"+
                    nombre+"%'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarApellido1(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select * From Usuarios Where Apellido1 Like '"+
                    nombre+"%'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarApellido2(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select * From Usuarios Where Apellido2 Like '"+
                    nombre+"%'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        /////////////////////////////////////
        // Busquedas de Gustos Ordenadores //
        /////////////////////////////////////

        public object[] buscarSO(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosOrdenadores Where Sistemaoperativo Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarMarcashw(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosOrdenadores Where Marcashw Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarLprogramacion(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosOrdenadores Where Lprogramacion Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        /////////////////////////////////////
        // Busquedas de Gustos Videojuegos //
        /////////////////////////////////////

        public object[] buscarGeneroV(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosVideojuegos Where Genero Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarJuegofav(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosVideojuegos Where Juegofav Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarConsolafav(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosVideojuegos Where Consolafav Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarDesarrolladorfav(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosVideojuegos Where Desarrolladorfav Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        ///////////////////////////////////////
        // Busquedas de Gustos Filmograficos //
        ///////////////////////////////////////

        public object[] buscarGeneroF(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosFilm Where Genero Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarDirector(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosFilm Where Director Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarDecadaF(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosFilm Where Decada Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarActor(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosFilm Where Actor Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarPelicula(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosFilm Where Pelicula Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarSGenero(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosFilm Where SGenero Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarSDirector(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosFilm Where SDirector Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarSerie(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosFilm Where Serie Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        ///////////////////////////////////
        // Busquedas de Gustos Musicales //
        ///////////////////////////////////

        public object[] buscarEstilo(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosMusicales Where Estilo Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarGrupo(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosMusicales Where Grupo Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarArtista(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosMusicales Where Artista Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarConcierto(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosMusicales Where Concierto Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarDecadaM(String nombre) {
            object[] obj=new object[2];
            try{
                String s = "Select Usuario From GustosMusicales Where Decada Like '%" +
                    nombre+"%'";
                s = "Select * from Usuarios where Email='" + (String)conexion.ejecutarR(s).Rows[0][0] + "'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }
    }
}