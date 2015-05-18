using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

/// <summary>
/// En la siguiente EN vamos a tratar con la creacion de relación entre dos usuarios. Donde se basará basicamente en poder agregar a 
/// otros usuarios.
/// </summary>
namespace EN
{
    public class Relaciones
    {
        private String usuario1;
        private ArrayList usuarios;
        private ArrayList aceptada;
        private ArrayList tuya;

        public String Usuario1{
            get { return usuario1; }
            set { usuario1 = value; }
        }

        public ArrayList Usuarios{
            get { return usuarios; }
            set { usuarios = value; }
        }
        
        public ArrayList Aceptada{
            get { return aceptada; }
            set { aceptada = value; }
        }

        public ArrayList Tuya{
            get { return tuya; }
            set { tuya = value; }
        }

        public Relaciones(String usuario1){
            this.usuario1 = usuario1;
            usuarios = new ArrayList();
            aceptada = new ArrayList();
            tuya = new ArrayList();
        }

        public void add(String email){
            usuarios.Add(email);
            this.aceptada.Add(false);
            this.tuya.Add(true);
        }
        
        public void add(String email, bool aceptada, bool tuya){
            usuarios.Add(email);
            this.aceptada.Add(aceptada);
            this.tuya.Add(tuya);
        }

        public void remove(String email) {
            int aux = usuarios.IndexOf(email);
            usuarios.RemoveAt(aux);
            aceptada.RemoveAt(aux);
            tuya.RemoveAt(aux);
        }

        public void aceptar(String email){
            if(!isTuya(email)){
                if(!isAceptada(email)){
                    int aux = usuarios.IndexOf(email);
                    aceptada[aux] = true;
                }
            }
        }

        public bool isUsuario(String email){
            return usuarios.Contains(email);
        }

        public bool isAceptada(String email){
            int aux = usuarios.IndexOf(email);
            return (bool) aceptada[aux];
        }

        public bool isTuya(String email){
            int aux = usuarios.IndexOf(email);
            return (bool)tuya[aux];
        }

        /// <summary>
        /// El primer elemento del vector son los usuarios quitados y el segundo los agregados y el tercero los modificados 
        /// al objeto que llama al metodo
        /// </summary>
        public EN.Relaciones[] diferencias(Relaciones rel) {
            Relaciones[] retu = new Relaciones[3];
            retu[0] = new Relaciones(usuario1);
            retu[1] = new Relaciones(usuario1);
            retu[2] = new Relaciones(usuario1);
            foreach(String aux in rel.usuarios){
                if(!isUsuario(aux)){
                    retu[0].add(aux);
                }
            }
            foreach(String aux in usuarios){
                if(!rel.isUsuario(aux)){
                    retu[1].add(aux);
                }else{
                    if(rel.isAceptada(aux)!=isAceptada(aux)){
                        retu[2].add(aux,isAceptada(aux),rel.isTuya(aux));
                    }
                }
            }
            return retu;
        }
        public Relaciones clonar(){
            EN.Relaciones r = new Relaciones(Usuario1);
            r.Usuarios = new ArrayList(Usuarios);
            r.Aceptada = new ArrayList(Aceptada);
            r.Tuya = new ArrayList(Tuya);
            return r;
        }
    }
}