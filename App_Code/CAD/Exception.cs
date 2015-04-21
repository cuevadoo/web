using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Exception
/// </summary>
namespace CAD
{
    public class Exception:System.Exception
    {
        String mensaje;
        public Exception(String mensaje){
            this.mensaje = mensaje;
        }
    }
}