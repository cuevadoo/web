using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Chat
/// </summary>
namespace EN
{
    public class Chat{
        private ArrayList usuarios = new ArrayList();
        public Chat(){}
        public void conect(Usuario user){
            usuarios.Add(user);
        }
        public void disconect(Usuario user){
            usuarios.Remove(user);
        }
    }
}