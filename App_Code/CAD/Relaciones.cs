﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Clase para manejar las relaciones entre usuarios
/// </summary>
namespace CAD
{
    public class Relaciones
    {
        private static Conexion conexion = new Conexion();

        public void create(EN.Relaciones relaciones)
        {
 
        }
        public void delete(EN.Relaciones relaciones)
        { 
        
        }
        public EN.Relaciones read(String email)
        {
            return null;
        }
        public void update(EN.Relaciones deleted, EN.Relaciones added)
        {

        }
    }
}