using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using EN;

public partial class Identificado_Perfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        EN.Usuario user = (EN.Usuario) Session["User"];
        if(user!=null){
                if(user.Foto==null){
                    ImageButton1.ImageUrl = "~/Imagenes/ImagenPerfil.jpg";
                }else{
                    ImageButton1.ImageUrl = "~/Imagenes/Usuarios/" + user.Email + "/prev.png";
                }
            
            try
            {
                //Declaración de las variables para cada gusto
                EN.Residencia r = new CAD.Residencia().read(user.Email);
        
                //Residencia
                    if (r.Pais != null)
                    {
                        TextBoxPais.Attributes["placeholder"] = r.Pais;
                    }
                    if (r.CAutonoma != null)
                    {
                        TextBoxCAutonoma.Attributes["placeholder"] = r.CAutonoma;
                    }
                    if (r.Localidad != null)
                    {
                        TextBoxLocalidad.Attributes["placeholder"] = r.Localidad;
                    }
            }catch(CAD.Exception ex){}

            /*
            //Gustos Musicales
            EN.GustosMusicales gm = new CAD.GustosMusicales().read(user.Email);

            try
            {
                if (gm.Artista != null)
                {
                    TextBoxArtista.Attributes["placeholder"] = gm.Artista;
                }
                if (gm.Concierto != null)
                {
                    TextBoxConciertos.Attributes["placeholder"] = gm.Concierto;
                }
                if (gm.Decada != null)
                {
                    DropDownListDecadaM.Attributes["placeholder"] = gm.Decada + "";
                }
                if (gm.Estilo != null)
                {
                    TextBoxEstilo.Attributes["placeholder"] = gm.Estilo;
                }
                if (gm.Grupo != null)
                {
                    TextBoxGrupo.Attributes["placeholder"] = gm.Grupo;
                }
            }
            catch (CAD.Exception ex) { }*/

            //Gustos informaticos
            try
            {
                EN.GustosOrdenadores gi = new CAD.GustosOrdenadores().read(user.Email);
                if (gi.Sistemaoperativo != null)
                {
                    TextBoxSO.Attributes["placeholder"] = gi.Sistemaoperativo;
                }
                if (gi.Marcashw != null)
                {
                    TextBoxHardware.Attributes["placeholder"] = gi.Marcashw;
                }
                if (gi.Lprogramacion != null)
                {
                    TextBoxLenguajeP.Attributes["placeholder"] = gi.Lprogramacion;
                }
            }
            catch (CAD.Exception ex) { }

            //Gustos Videojuegos

            try
            {
                EN.GustosVideojuegos gv = new CAD.GustosVideojuegos().read(user.Email);
                if (gv.Genero != null)
                {
                    TextBoxGeneroV.Attributes["placeholder"] = gv.Genero;
                }
                if (gv.ConsolaFav != null)
                {
                    RadioButtonListConsola.Attributes["placeholder"] = gv.ConsolaFav;
                }
                if (gv.JuegoFav != null)
                {
                    TextBoxVideojuego.Attributes["placeholder"] = gv.JuegoFav;
                }
                if (gv.DesarrolladorFav != null)
                {
                    TextBoxDesarrolladora.Attributes["placeholder"] = gv.DesarrolladorFav;
                }
            }
            catch (CAD.Exception ex) { }
        
        }
    }
    private static System.Drawing.Image cropImage(System.Drawing.Image img, System.Drawing.RectangleF cropArea){
        System.Drawing.Bitmap bmpImage = new System.Drawing.Bitmap(img);
        System.Drawing.Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        return (System.Drawing.Image)(bmpCrop);
    }

    protected void Table1_Load(object sender, EventArgs e){
        EN.Usuario user =(EN.Usuario) Session["User"];
        String[] dirs = Directory.GetFiles(Server.MapPath("~/Imagenes/Usuarios/" + user.Email + "/"));
        TableRow row = new TableRow();
        foreach(String s in dirs){
            char[] aux = { '\\' };
            String[] aux2 = s.Split(aux);
            if(aux2[aux2.Length-1]!="Thumbs.db"&&aux2[aux2.Length-1]!="prev.png"){
                TableCell cell = new TableCell();
                ImageButton ima = new ImageButton();
                ima.Click += new ImageClickEventHandler(DarleImagen);
                ima.Height = 100;
                ima.Width = 100;
                ima.ImageUrl = "~/Imagenes/Usuarios/" + user.Email + "/" + aux2[aux2.Length - 1];
                cell.Controls.Add(ima);
                row.Cells.Add(cell);
            }
        }
        Table1.Rows.Add(row);
    }
    protected void DarleImagen(object sender, ImageClickEventArgs e){
        ImageButton ima = (ImageButton)sender;
        Session["FotoParaRecortar"] = Server.MapPath(ima.ImageUrl);
        System.Drawing.Image im = System.Drawing.Image.FromFile(Server.MapPath(ima.ImageUrl));
        fondoFoto.Style["display"] = "block";
        Foto.Style["display"] = "block";
        Image1.Style["display"] = "block";
        botones.Style["display"] = "block";
        int[] aux = { Int32.Parse(AltoVentana.Text), Int32.Parse(AnchoVentana.Text) };
        Session["Tamaño"] = aux;
        int alto = Int32.Parse(AltoVentana.Text);
        int ancho = Int32.Parse(AnchoVentana.Text);
        Image1.ImageUrl = ima.ImageUrl;
        int realHe = im.Height;
        int realWi = im.Width;
        if(realHe>=alto&&realWi>=ancho){
            Image1.Height = alto;
            Image1.Width = ancho;
        }
        if(realHe>=alto&&realWi<ancho){
            Image1.Height = alto;
            Image1.Width = im.Width;
        }
        if(realHe<alto&&realWi<ancho){
            Image1.Height = im.Height;
            Image1.Width = im.Width;
        }
        if(realHe<alto&&realWi>=ancho){
            Image1.Height = im.Height;
            Image1.Width = ancho;
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e){
        try {
            int[] AlAn =(int[]) Session["Tamaño"];
            int alto = AlAn[0];
            int ancho = AlAn[1];
            String aux = Image1.Height.ToString();
            int he = Int32.Parse(aux.Substring(0,aux.Length-2));
            aux = Image1.Width.ToString();
            int wi = Int32.Parse(aux.Substring(0,aux.Length-2));
            System.Drawing.Image i = System.Drawing.Image.FromFile((String)Session["FotoParaRecortar"]);
            float left=0, top=0, width=0, height=0;
            if(he>=alto&&wi>=ancho){
                float relaHe = i.Height/(float)alto;
                float relaWi = i.Width/(float)ancho;
                left = Int32.Parse(Left.Text) * relaWi;
                top=Int32.Parse(Top.Text) * relaHe;
                width = Int32.Parse(Ancho.Text) * relaWi;
                height = Int32.Parse(Alto.Text) * relaHe;
            }
            if(he<alto&&wi<alto){
                int relaHe = (alto - i.Height)/2;
                int relaWi = (ancho - i.Width)/2;
                left = Int32.Parse(Left.Text) - relaWi;
                if(left<0){left = 0;}
                top = Int32.Parse(Top.Text) - relaHe;
                if(top<0){top = 0;}
                width = Int32.Parse(Ancho.Text);
                if (width>(i.Width - left)) { width = i.Width - left; }
                height=Int32.Parse(Alto.Text);
                if (height>(i.Height - top)) { height = i.Height - top; }
            }
            if(he>=alto&&wi<alto){
                float relaHe = i.Height/(float)alto;
                int relaWi = (ancho - i.Width)/2;
                left = Int32.Parse(Left.Text) - relaWi;
                if(left<0){left = 0;}
                top=Int32.Parse(Top.Text) * relaHe;
                width = Int32.Parse(Ancho.Text);
                if (width>(i.Width - left)) { width = i.Width - left; }
                height = Int32.Parse(Alto.Text) * relaHe;
            }
            if(he<alto&&wi>=alto){
                int relaHe = (alto - i.Height)/2;
                float relaWi = i.Width/(float)ancho;
                left = Int32.Parse(Left.Text) * relaWi;
                top = Int32.Parse(Top.Text) - relaHe;
                if(top<0){top = 0;}
                width = Int32.Parse(Ancho.Text) * relaWi;
                height=Int32.Parse(Alto.Text);
                if (height>(i.Height - top)) { height = i.Height - top; }
            }

            System.Drawing.RectangleF f = new System.Drawing.RectangleF(left, top, width, height);
            System.Drawing.Image i2 = cropImage(i, f);
            EN.Usuario user = (EN.Usuario)Session["User"];
            i2.Save(Server.MapPath("~/Imagenes/Usuarios/" + user.Email + "/prev.png"), System.Drawing.Imaging.ImageFormat.Png);
            EN.Usuario user2 = (EN.Usuario)Session["User"];
            user2.Foto = (String)Session["FotoParaRecortar"];
            Session["User"] = user2;
            new CAD.Usuario().update(user2,user2);
        }catch(Exception ex){}
        finally{
            fondoFoto.Style["display"] = "none";
            Foto.Style["display"] = "none";
            Image1.Style["display"] = "none";
            botones.Style["display"] = "none";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try{
            Usuario user = (Usuario)Session["User"];
            Residencia r = new Residencia(null,null,null,user.Email);
            GustosOrdenadores gi = new GustosOrdenadores(null,null,null,user.Email);
            GustosVideojuegos gv = new GustosVideojuegos(null,null,null,null,user.Email);
            GustosFilm gf = new GustosFilm(null,null,(byte) 0,null,null,null,null,null,user.Email);
            GustosMusicales gm = new GustosMusicales(null,null,null,null,(byte)0,user.Email);

            ////////////////
            // Residencia //
            ////////////////

            if (TextBoxPais.Text != "") { r.Pais = TextBoxPais.Text; }
            if (TextBoxCAutonoma.Text != "") { r.CAutonoma = TextBoxCAutonoma.Text; }
            if (TextBoxLocalidad.Text != "") { r.Localidad = TextBoxLocalidad.Text; }

            ////////////////////////
            // Gustos Ordenadores //
            ////////////////////////

            if (TextBoxSO.Text != "") { gi.Sistemaoperativo = TextBoxSO.Text; }
            if (TextBoxHardware.Text != "") { gi.Marcashw = TextBoxHardware.Text; }
            if (TextBoxLenguajeP.Text != "") { gi.Lprogramacion = TextBoxLenguajeP.Text; }

            ////////////////////////
            // Gustos Videojuegos //
            ////////////////////////

            if (TextBoxGeneroV.Text != "") { gv.Genero = TextBoxGeneroV.Text; }
            if (RadioButtonListConsola.SelectedValue != "") { gv.ConsolaFav = RadioButtonListConsola.SelectedValue; }
            if (TextBoxVideojuego.Text != "") { gv.JuegoFav = TextBoxVideojuego.Text; }
            if (TextBoxDesarrolladora.Text != "") { gv.DesarrolladorFav = TextBoxDesarrolladora.Text; }

            //////////////////////////
            // Gustos Filmograficos //
            //////////////////////////

            if (TextBoxGeneroC.Text != "") { gf.Genero = TextBoxGeneroC.Text; }
            if (TextBoxDirector.Text != "") { gf.Director = TextBoxDirector.Text; }
            if (DropDownListDecadaC.SelectedValue != "--") { gf.Decada = Byte.Parse(DropDownListDecadaC.SelectedValue); }
            if (TextBoxActor.Text != "") { gf.Actor = TextBoxActor.Text; }
            if (TextBoxPeli.Text != "") { gf.Pelicula = TextBoxPeli.Text; }
            if (TextBoxGeneroS.Text != "") { gf.S_genero1 = TextBoxGeneroS.Text; }
            if (TextBoxProductor.Text != "") { gf.S_director1 = TextBoxProductor.Text; }
            if (TextBoxSerie.Text != "") { gf.Serie = TextBoxSerie.Text; }

            //////////////////////
            // Gustos Musicales //
            //////////////////////

            if (TextBoxEstilo.Text != "") { gm.Estilo = TextBoxEstilo.Text; }
            if (TextBoxGrupo.Text != "") { gm.Grupo = TextBoxGrupo.Text; }
            if (TextBoxArtista.Text != "") { gm.Artista = TextBoxArtista.Text; }
            if (DropDownListDecadaM.SelectedValue != "--") { gm.Decada = Byte.Parse(DropDownListDecadaM.SelectedValue); }
            if (TextBoxConciertos.Text != "") { gm.Concierto = TextBoxConciertos.Text; }

            
            //Crear o actualizar Residencia segun corresponda

            try{ new CAD.Residencia().create(r); }catch (CAD.Exception){ new CAD.Residencia().update(r, r); }
            /*
            //Crear o actualizar Gustos Ordenadores segun corresponda

            try{ new CAD.GustosOrdenadores().create(gi); }catch (CAD.Exception){ new CAD.GustosOrdenadores().update(gi, gi); }
            
            //Crear o actualizar Gustos Videojuegos segun corresponda
            
            try{ new CAD.GustosVideojuegos().create(gv); }catch (CAD.Exception){ new CAD.GustosVideojuegos().update(gv, gv); }
            
            //Crear o actualizar Gustos Filmograficos segun corresponda

            try{ new CAD.GustosFilm().create(gf); }catch (CAD.Exception){ new CAD.GustosFilm().update(gf, gf); }

            //Crear o actualizar Gustos Musicales segun corresponda

            try{ new CAD.GustosMusicales().create(gm); }catch (CAD.Exception){ new CAD.GustosMusicales().update(gm, gm); }
            */

            LabelAviso.Text = "Los cambios se han guardado correctamente";

        }catch (System.Exception ex){
           LabelAviso.Text = "ERROR. No se han podido guardar los cambios. Inténtelo de nuevo más tarde";
        }
       
    }
   
}