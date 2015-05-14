using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar el chat de nuestra red social, el cual nos servirá para que dos o más usuarios interactuen de una
/// forma más cercana, pudiendose conocer mucho mejor.
/// </summary>
namespace EN
{
    public class Chat{
        private static ArrayList usuarios = new ArrayList();
        private Usuario user1;
        private Usuario user2;
        private ArrayList mensajesU1 = new ArrayList();
        private ArrayList mensajesU2 = new ArrayList();
        private bool admitida = false;
        public Chat(Usuario user){
            user1 = user;
        }
        public static void conect(Usuario user){
            usuarios.Add(user);
        }
        public static void disconect(Usuario user){
            usuarios.Remove(user);
        }
        public static bool conected(Usuario user){
            if(usuarios.Contains(user)){
                return true;
            }
            return false;
        }
        public void conectarChat(Usuario user){
            user2 = user;
        }
        public void escribir(Usuario user,String s){
            if (user1 == user){
                mensajesU1.Add(s);
            }
            else {
                mensajesU2.Add(s);
            }
        }
        public ArrayList[] actualizar(Usuario user) {
            ArrayList[] aux = new ArrayList[2];
            if (user1 == user){
                aux[0] = mensajesU1;
                aux[1] = mensajesU2;
            }
            else{
                aux[0] = mensajesU2;
                aux[1] = mensajesU1;

            }
            return aux;
        }
    }
}