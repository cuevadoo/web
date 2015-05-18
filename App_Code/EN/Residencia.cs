using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descripción breve de Residencia
/// </summary>

namespace EN
{
    
    public class Residencia:Usuario
    {
        private String pais;
        private String cautonoma;
        private String localidad;

        

        public Residencia(String pais,String cautonoma, String localidad,String email):base(email)
        {
            this.pais = pais;
            this.cautonoma = cautonoma;
            this.localidad = localidad;
        }
        
        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public String CAutonoma
        {
            get { return cautonoma; }
            set { cautonoma = value; }
        }
        public String Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
    }
}