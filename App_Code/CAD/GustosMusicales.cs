using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Clase que contiene los gustos musicales de un usuario y donde podremos agregar,modificar, eliminar o leer datos de la BD 
/// </summary>
namespace CAD
{
    public class GustosMusicales
    {
        private static Conexion conexion = new Conexion();
        public void create(EN.GustosMusicales gmusic)
        {

        }
        public void delete(EN.GustosMusicales gmusic)
        {
             
        }
        public EN.GustosMusicales read(String email)
        {
            return null;
        }
        public void update(EN.GustosMusicales deleted, EN.GustosMusicales added)
        {



        }
    }
}