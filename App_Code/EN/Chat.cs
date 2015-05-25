﻿using System;
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
        private String user1;
        private String user2;
        private ArrayList mensajesU1 = new ArrayList();
        private ArrayList mensajesU2 = new ArrayList();
        private bool admitida = false;
        public Chat(String user){
            user1 = user;
        }

        public void conectarChat(String user){
            user2 = user;
        }

        public void escribir(String user,String chat){
            if (user1 == user){
                mensajesU1.Add(chat);
            }
            else {
                mensajesU2.Add(chat);
            }
        }

        public ArrayList[] actualizar(String user) {
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

        public String User1{
            get { return user1; }
        }
        
        public String User2{
            get { return user2; }
        }
    }
}