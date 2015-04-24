using System;
using System.Collections.Generic;
using System.Collections;
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
        private String pass;
        private String apellido1;
        private String apellido2;
        private String email;
        private byte edad;
        private bool sexo;

        public Usuario(String email, String pass, String nombre, String apellido1, String apellido2, byte edad, bool sexo)
        {
            this.email = email;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.edad = edad;
            this.sexo = sexo;
        }
        protected Usuario(String email) 
        {
            this.email = email;
        }

        public Chat abrirChat(Usuario user){
            Chat c = new Chat(this);
            return c;
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
        public String Pass
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}