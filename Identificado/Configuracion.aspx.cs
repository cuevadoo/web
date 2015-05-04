using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Identificado_Configuracion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
<<<<<<< HEAD
        EN.Usuario user=(EN.Usuario)Session["User"];
=======
        ImageButton ImageButton1 = new ImageButton();
        EN.Usuario user = (EN.Usuario) Session["User"];
        if(user!=null){
            if(user.Foto==null){
                ImageButton1.ImageUrl = "~/Imagenes/ImagenPerfil.jpg";
            }else{
                ImageButton1.ImageUrl = user.Foto;
            }
        }
    }
    private static System.Drawing.Image cropImage(System.Drawing.Image img, RectangleF cropArea){
        Bitmap bmpImage = new Bitmap(img);
        Bitmap bmpCrop = bmpImage.Clone(cropArea,bmpImage.PixelFormat);
        return (System.Drawing.Image)(bmpCrop);
>>>>>>> web/master
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}