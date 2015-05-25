using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar con el elemento principal de nuestra web, el cual es la clase Usuario, donde añadiremos todos 
/// nuestros datos personales que aparecen a continuación.
/// </summary>
namespace EN
{
    public class Usuario
    {
        private String nombre;
        private String pass;
        private String apellido1;
        private String apellido2;
        private String email;
        private Fecha edad;
        private bool sexo;
        private String foto;
        public Usuario(String email, String pass, String nombre, String apellido1, String apellido2, Fecha edad, bool sexo,String foto)
        {
            this.email = email;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.edad = edad;
            this.sexo = sexo;
            this.foto = foto;
        }

        protected Usuario(String email) 
        {
            this.email = email;
        }

        public String Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }
        public String Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public Fecha Edad
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
        public String Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }
    }
}