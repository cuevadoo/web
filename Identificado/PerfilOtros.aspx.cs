using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Identificado_PerfilOtros : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        EN.Usuario user = (EN.Usuario)Session["PerfilOtro"];
        if(user.Foto==null){
            UserImage1.ImageUrl = "~/Imagenes/ImagenPerfil.jpg";
        }else{
            UserImage1.ImageUrl = "~/Imagenes/Usuarios/" + user.Email + "/prev.png";
        }
        //Declaración de las variables para cada gusto
        EN.Residencia r = new CAD.Residencia().read(user.Email);
        EN.GustosOrdenadores gi = new CAD.GustosOrdenadores().read(user.Email);
        EN.GustosVideojuegos gv = new CAD.GustosVideojuegos().read(user.Email);
        EN.GustosFilm gf = new CAD.GustosFilm().read(user.Email);
        EN.GustosMusicales gm = new CAD.GustosMusicales().read(user.Email);
        
        //Residencia
        if (r.Pais != null)
        {
            LabelPais.Text = r.Pais;
        }
        if (r.Cautonoma != null)
        {
            LabelCAutonoma.Text = r.Cautonoma;
        }
        if (r.Localidad != null)
        {
            LabelLocalidad.Text = r.Localidad;
        }
        
        //Gustos informaticos
        if(gi.Sistemaoperativo!=null){
            LabelSO.Text = gi.Sistemaoperativo;
        }
        if (gi.Marcashw != null)
        {
             LabelMHardware.Text = gi.Marcashw;
        }
        if (gi.Lprogramacion != null)
        {
            LabelLProgramacion.Text = gi.Lprogramacion;
        }
        //Gustos Videojuegos
        if (gv.Genero != null)
        {
            LabelGVideojuegos.Text = gv.Genero;
        }
        if (gv.ConsolaFav != null)
        {
            LabelConsolas.Text = gv.ConsolaFav;
        }
        if (gv.JuegoFav != null)
        {
            LabelVideojuego.Text = gv.JuegoFav;
        }
        if (gv.DesarrolladorFav != null)
        {
            LabelDesarrolladora.Text = gv.DesarrolladorFav;
        }
        //Gustos Pelis y Series
        if (gf.Actor != null)
        {
            LabelActor.Text = gf.Actor;
        }
        if (gf.Decada != null)
        {

            LabelDecadaC.Text = gf.Decada + "";
        }
        if (gf.Director != null)
        {
            LabelDirector.Text = gf.Director;
        }
        if (gf.Genero != null)
        {
            LabelGCine.Text = gf.Genero;
        }
        if (gf.Pelicula != null)
        {
            LabelPelicula.Text = gf.Pelicula;
        }
        if (gf.S_director1 != null)
        {
            LabelProductor.Text = gf.S_director1;
        }
        if (gf.S_genero1 != null)
        {
            LabelGSerie.Text = gf.S_genero1;
        }
        if (gf.Serie != null)
        {
            LabelSerie.Text = gf.Serie;
        }
        //Gustos Musicales
        if (gm.Artista != null)
        {
            LabelArtista.Text = gm.Artista;
        }
        if (gm.Concierto != null)
        {
            LabelConciertos.Text = gm.Concierto;
        }
        if (gm.Decada != null)
        {
            LabelDecadaM.Text = gm.Decada + "";
        }
        if (gm.Estilo != null)
        {
            LabelEstilo.Text = gm.Estilo;
        }
        if (gm.Grupo != null)
        {
            LabelGrupo.Text = gm.Grupo;
        }




    }
}