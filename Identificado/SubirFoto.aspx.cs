using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Identificado_SubirFoto : System.Web.UI.Page
{
     protected void Page_Load(object sender, EventArgs e){
        if(Session["User"]==null){
            Response.Redirect("~/SinIdentificar/Entrar.aspx");
        }
        EN.Usuario aux = (EN.Usuario)Session["User"];
        Menu1.Items[0].Text = aux.Nombre;
    }
    
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e){
        Response.Redirect("~/Identificado/Indice.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e){
        if(FileUpload1.HasFile){
            bool comp = false;
            String fileExtension =System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            String[] allowedExtensions = {".png", ".jpeg", ".jpg" };
            for (int i = 0; i < allowedExtensions.Length; i++){
                if (fileExtension == allowedExtensions[i]){
                    comp= true;
                }
            }
            if(comp){
                try{
                    byte[] bytes = FileUpload1.FileBytes;
                    EN.Usuario user = (EN.Usuario)Session["User"];
                    String path = Server.MapPath("~/Imagenes/Usuarios/" + user.Email + "/");
                    File.WriteAllBytes(path + DateTime.Now.ToBinary() + ".jpg", bytes);
                    Label1.Text = "Se ha subido correctamente";
                }catch(Exception ex){
                    Label1.Text = "No se ha podido subir la imagen";
                }
            }else{
                Label1.Text = "El archivo no es una imagen jpg, jpeg o png";
            }
        }else{
            Label1.Text = "No se ha seleccionado un archivo";
        }
    }
    
    private static System.Drawing.Image cropImage(System.Drawing.Image img, System.Drawing.RectangleF cropArea){
        System.Drawing.Bitmap bmpImage = new System.Drawing.Bitmap(img);
        System.Drawing.Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        return (System.Drawing.Image)(bmpCrop);
    }

    protected void Button2_Click(object sender, EventArgs e){
        String s = "T:"+ TextBox1.Text;
        s += "-L:" + TextBox2.Text;
        s += "-H:" + TextBox3.Text;
        s += "-W:" + TextBox4.Text;
        Label2.Text = s;
        System.Drawing.Image i = System.Drawing.Image.FromFile(Server.MapPath("~/Imagenes/logo.png"));
        System.Drawing.RectangleF f = new System.Drawing.RectangleF(Int32.Parse(TextBox2.Text)-78, Int32.Parse(TextBox1.Text)-163, Int32.Parse(TextBox4.Text), Int32.Parse(TextBox3.Text));
        System.Drawing.Image i2 = cropImage(i, f);
        i2.Save(Server.MapPath("~/Imagenes/logoR.png"), System.Drawing.Imaging.ImageFormat.Png);
    }
}