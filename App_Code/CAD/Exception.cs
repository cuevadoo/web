using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Clase para el manejo de excepciones 
/// </summary>
namespace CAD
{
    public class Exception:System.Exception
    {
        private String mensaje;

        public String Mensaje
        {
            get { return mensaje; }
        }

        public Exception(String mensaje){
            this.mensaje = mensaje;
        }
    }
}