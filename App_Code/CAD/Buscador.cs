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
        // Modulos para meter los datos, comunes //
        // al resto de los modulos de esta clase //
        ///////////////////////////////////////////

        public object[] meterDatos(DataRow data, DataRow busqueda,ref object[] obj) {
            try{
                ArrayList nom,email;
                if(obj[0]==null){
                    nom = new ArrayList();
                    email = new ArrayList();
                    obj[0] = email;
                    obj[1] = nom;
                }else{
                    email = (ArrayList) obj[0];
                    nom = (ArrayList) obj[1];
                }
                try {
                    String aux = data[2] + " " + data[3] + " " + data[4] + " (" + busqueda[1] + ")";
                    nom.Add(aux);
                    email.Add(data[0]);
                }catch(System.Exception ex){
                    obj[0] = email;
                    obj[1] = nom;
                }
            }catch(System.Exception ex){
                throw ex;
            }
            return obj;
        }
        public object[] meterDatos(DataRowCollection data) {
            object[] obj=new object[2];
            try{
                ArrayList nom = new ArrayList();
                ArrayList email = new ArrayList();
                try {
                    int i=0;
                    while(true){
                        String aux = data[i][2] + " " + data[i][3] + " " + data[i][4];
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
            object[] obj;
            try{
                String s = "Select * From Usuarios Where Nombre Like '"+
                    nombre+"%' OR Apellido1 Like '"+nombre+"%' OR Apellido2 Like '"+nombre+"%'";
                obj=meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        ///////////////////////////
        // Busquedas de Usuarios //
        ///////////////////////////

        public object[] buscarNombre(String nombre) {
            object[] obj;
            try{
                String s = "Select * From Usuarios Where Nombre Like '"+
                    nombre+"%'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarApellido1(String nombre) {
            object[] obj;
            try{
                String s = "Select * From Usuarios Where Apellido1 Like '"+
                    nombre+"%'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarApellido2(String nombre) {
            object[] obj;
            try{
                String s = "Select * From Usuarios Where Apellido2 Like '"+
                    nombre+"%'";
                obj = meterDatos(conexion.ejecutarR(s).Rows);
            }catch(System.Exception ex){
                throw new Exception("Error buscar");
            }
            return obj;
        }

        ///////////////////////////
        // Busquedas de Residencia //
        ///////////////////////////

        public object[] buscarPais(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From Residencia Where Pais Like '%" + nombre+"%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarCAutonoma(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From Residencia Where CAutonoma Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarLocalidad(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From Residencia Where Localidad Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        /////////////////////////////////////
        // Busquedas de Gustos Ordenadores //
        /////////////////////////////////////

        public object[] buscarSO(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosOrdenadores Where Sistemaoperativo Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarMarcashw(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosOrdenadores Where Marcashw Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarLprogramacion(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosOrdenadores Where Lprogramacion Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        /////////////////////////////////////
        // Busquedas de Gustos Videojuegos //
        /////////////////////////////////////

        public object[] buscarGeneroV(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosVideojuegos Where Genero Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarJuegofav(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosVideojuegos Where Juegofav Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarConsolafav(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosVideojuegos Where Consolafav Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarDesarrolladorfav(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosVideojuegos Where Desarrolladorfav Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        ///////////////////////////////////////
        // Busquedas de Gustos Filmograficos //
        ///////////////////////////////////////

        public object[] buscarGeneroF(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosFilm Where Genero Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarDirector(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosFilm Where Director Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarDecadaF(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosFilm Where Decada Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarActor(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosFilm Where Actor Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarPelicula(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosFilm Where Pelicula Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarSGenero(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosFilm Where SGenero Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarSDirector(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosFilm Where SDirector Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        public object[] buscarSerie(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosFilm Where Serie Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al buscar");
            }
            return obj;
        }

        ///////////////////////////////////
        // Busquedas de Gustos Musicales //
        ///////////////////////////////////

        public object[] buscarEstilo(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosMusicales Where Estilo Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarGrupo(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosMusicales Where Grupo Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarArtista(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosMusicales Where Artista Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarConcierto(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosMusicales Where Concierto Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }

        public object[] buscarDecadaM(String nombre) {
            object[] obj = new object[2];
            try{
                String s = "Select Usuario,Pais From GustosMusicales Where Decada Like '%" + nombre + "%'";
                DataRowCollection row = conexion.ejecutarR(s).Rows;
                try {
                    int i = 0;
                    while(true){
                        s = "Select * from Usuarios where Email='" + (String)row[i][0] + "'";
                        meterDatos(conexion.ejecutarR(s).Rows[0], row[i] , ref obj);
                        i++;
                    }
                }catch(System.Exception ex){}
            }catch(System.Exception ex){
                throw new Exception("Error al leer usuario");
            }
            return obj;
        }
    }
}