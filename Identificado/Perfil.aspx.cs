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
                ImageButton1.ImageUrl = user.Foto;
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
        String thumbs="Thumb.db";
        TableRow row = new TableRow();
        foreach(String s in dirs){
            if(s!=thumbs){
                char[] aux = { '\\' };
                String[] aux2 = s.Split(aux);
                if(aux2[aux2.Length-1]!="Thumbs.db"){
                    TableCell cell = new TableCell();
                    ImageButton ima = new ImageButton();
                    ima.Click += new ImageClickEventHandler(DarleImagen);
                    ima.Height = 150;
                    ima.Width = 150;
                    ima.ImageUrl = "~/Imagenes/Usuarios/" + user.Email + "/" + aux2[aux2.Length - 1];
                    cell.Controls.Add(ima);
                    row.Cells.Add(cell);
                }
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
        int alto = Int32.Parse(AltoVentana.Text);
        int ancho = Int32.Parse(AnchoVentana.Text);
        Image1.ImageUrl = ima.ImageUrl;
        if(im.Height>=alto&&im.Width>=ancho){
            Image1.Height = alto;
            Image1.Width = ancho;
        }
        if(im.Height>=alto&&im.Width<ancho){
            Image1.Height = alto;
            Image1.Width = im.Width;
        }
        if(im.Height<alto&&im.Width<ancho){
            Image1.Height = im.Height;
            Image1.Width = im.Width;
        }
        if(im.Height<alto&&im.Width>=ancho){
            Image1.Height = im.Height;
            Image1.Width = ancho;
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e){
        Label2.Text = "H:"+Image1.Height + "-W:" + Image1.Width;
        System.Drawing.Image i = System.Drawing.Image.FromFile((String)Session["FotoParaRecortar"]);
        System.Drawing.RectangleF f = new System.Drawing.RectangleF(Int32.Parse(Left.Text), Int32.Parse(Top.Text), Int32.Parse(Ancho.Text), Int32.Parse(Alto.Text));
        System.Drawing.Image i2 = cropImage(i, f);
        EN.Usuario user=(EN.Usuario)Session["User"];
        i2.Save(Server.MapPath("~/Imagenes/Usuarios/" + user.Email + "/prev.png"), System.Drawing.Imaging.ImageFormat.Png);
    }
}