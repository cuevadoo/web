using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Identificado_Configuracion : System.Web.UI.Page
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

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e){

    }

    private static System.Drawing.Image cropImage(System.Drawing.Image img, System.Drawing.RectangleF cropArea){
        System.Drawing.Bitmap bmpImage = new System.Drawing.Bitmap(img);
        System.Drawing.Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        return (System.Drawing.Image)(bmpCrop);
    }
    protected void Table2_Load(object sender, EventArgs e){
        EN.Usuario user =(EN.Usuario) Session["User"];
        string[] dirs = Directory.GetFiles(Server.MapPath("~/Imagenes/Usuarios/" + user.Email + "/"));
        TableRow row = new TableRow();
        foreach(String s in dirs){
            char[] aux = { '\\' };
            String[] aux2 = s.Split(aux);
            TableCell cell = new TableCell();
            Image ima = new Image();
            ima.Height = 150;
            ima.Width = 150;
            ima.ImageUrl = "~/Imagenes/Usuarios/" + user.Email + "/"+ aux2[aux2.Length-1];
            cell.Controls.Add(ima);
            row.Cells.Add(cell);
        }
        Table2.Rows.Add(row);
    }
}