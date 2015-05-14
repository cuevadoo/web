using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

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
                //ima.Click += new ImageClickEventHandler(DarleImagen);
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
}