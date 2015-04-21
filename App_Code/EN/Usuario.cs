using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
namespace EN
{
    public class Usuario
    {
        private String nombre;
        private String apellidos;
        private String email;
        private byte edad;
        private bool sexo;

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public byte Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}