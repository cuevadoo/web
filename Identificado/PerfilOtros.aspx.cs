﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using EN;

public partial class Identificado_PerfilOtros : System.Web.UI.Page
{
    //boton para poder leer los datos de la BBDD del usuario concreto
    protected void Page_Load(object sender, EventArgs e){
        EN.Usuario tuUser = (EN.Usuario)Session["User"];
        EN.Usuario user = (EN.Usuario)Session["PerfilOtro"];
        EN.Relaciones rel = (EN.Relaciones) Session["Relaciones"];
        if(user!=null){
            LabelNombreUsuario.Text = user.Nombre + " " + user.Apellido1 + " " + user.Apellido2;
            if (user.Foto == null){
                UserImage1.ImageUrl = "~/Imagenes/ImagenPerfil.jpg";
            }else{
                UserImage1.ImageUrl = "~/Imagenes/Usuarios/" + user.Email + "/prev.png";
            }

            if(rel.isUsuario(user.Email)){
                if(rel.isAceptada(user.Email)){
                    Button1.Text = "Ya es tu amigo";
                    Button1.Enabled = false;
                }else{
                    if(rel.isTuya(user.Email)){
                        Button1.Text = "Solicitud enviada";
                        Button1.Enabled = false;
                    }else{
                        Button1.Text = "Aceptar solicitud";
                    }
                }
            }else{
                if(tuUser.Email==user.Email){
                    Button1.Text = "Eres tu";
                    Button1.Enabled = false;
                }
            }
            //gustos Residencia
            try{
                EN.Residencia r = new CAD.Residencia().read(user.Email);
                if (r.Pais != null){
                    LabelPais.Text = r.Pais;
                }
                if (r.CAutonoma != null){
                    LabelCAutonoma.Text = r.CAutonoma;
                }
                if (r.Localidad != null){
                    LabelLocalidad.Text = r.Localidad;
                }
            }catch(CAD.Exception ex){}
            
            //gustos Gustos informaticos
            try{
                EN.GustosOrdenadores gi = new CAD.GustosOrdenadores().read(user.Email);
                if (gi.Sistemaoperativo != null){
                    LabelSO.Text = gi.Sistemaoperativo;
                }
                if (gi.Marcashw != null){
                    LabelMHardware.Text = gi.Marcashw;
                }
                if (gi.Lprogramacion != null){
                    LabelLProgramacion.Text = gi.Lprogramacion;
                }
            }catch(CAD.Exception ex){}
            
            //try Gustos Videojuegos
            try{
                EN.GustosVideojuegos gv = new CAD.GustosVideojuegos().read(user.Email);
                if (gv.Genero != null){
                    LabelGVideojuegos.Text = gv.Genero;
                }
                if (gv.ConsolaFav != null){
                    LabelConsolas.Text = gv.ConsolaFav;
                }
                if (gv.JuegoFav != null){
                    LabelVideojuego.Text = gv.JuegoFav;
                }
                if (gv.DesarrolladorFav != null){
                    LabelDesarrolladora.Text = gv.DesarrolladorFav;
                }
            }catch(CAD.Exception ex){}

            //try Gustos Pelis y Series
            try{
                EN.GustosFilm gf = new CAD.GustosFilm().read(user.Email);
                if (gf.Actor != null){
                    LabelActor.Text = gf.Actor;
                }
                if (gf.Decada != null){
                    LabelDecadaC.Text = gf.Decada + "";
                }
                if (gf.Director != null){
                    LabelDirector.Text = gf.Director;
                }
                if (gf.Genero != null){
                    LabelGCine.Text = gf.Genero;
                }
                if (gf.Pelicula != null){
                    LabelPelicula.Text = gf.Pelicula;
                }
                if (gf.S_director1 != null){
                    LabelProductor.Text = gf.S_director1;
                }
                if (gf.S_genero1 != null){
                    LabelGSerie.Text = gf.S_genero1;
                }
                if (gf.Serie != null){
                    LabelSerie.Text = gf.Serie;
                }
            }catch(CAD.Exception ex){}

            //try para Gustos Musicales
            try{
                EN.GustosMusicales gm = new CAD.GustosMusicales().read(user.Email);
                if (gm.Artista != null){
                    LabelArtista.Text = gm.Artista;
                }
                if (gm.Concierto != null){
                    LabelConciertos.Text = gm.Concierto;
                }
                if (gm.Decada != null){
                    LabelDecadaM.Text = gm.Decada + "";
                }
                if (gm.Estilo != null){
                    LabelEstilo.Text = gm.Estilo;
                }
                if (gm.Grupo != null){
                    LabelGrupo.Text = gm.Grupo;
                }
            }catch(CAD.Exception ex){}
        }
    }

    //boton para añadir amigos
    protected void Button1_Click(object sender, EventArgs e){
        EN.Relaciones rel = (EN.Relaciones)Session["Relaciones"];
        EN.Usuario user = (EN.Usuario)Session["PerfilOtro"];
        if(rel.isUsuario(user.Email)&&!rel.isAceptada(user.Email)&&!rel.isTuya(user.Email)){
            EN.Relaciones aux = rel.clonar();
            rel.aceptar(user.Email);
            Button1.Text = "Ya es tu amigo";
            Button1.Enabled = false;
            new CAD.Relaciones().update(rel, aux);
            Session["Relaciones"] = rel;
        }else{
            EN.Relaciones aux = rel.clonar();
            rel.add(user.Email);
            new CAD.Relaciones().update(rel,aux);
            Button b = (Button)sender;
            b.Enabled = false;
            b.Text = "Solicitud enviada";
            Session["Relaciones"] = rel;
        }
    }

    //boton para enviar mensaje
    protected void Button3_Click(object sender, EventArgs e){
        Usuario Usuario1 = (Usuario)Session["User"];
        Usuario Usuario2 = (Usuario)Session["PerfilOtro"];
        try {
            
            if (TextBoxMensaje.Text != "") {
                String texto = TextBoxMensaje.Text;
                Fecha fecha = new Fecha(DateTime.Now);
                new CAD.MensajePrivado().create(new EN.MensajePrivado(Usuario1.Email,Usuario2.Email,texto,fecha));
            }
        }catch(CAD.Exception ex){
            LabelError.Text = "No se pudo enviar el mensaje";
        }
    }

}