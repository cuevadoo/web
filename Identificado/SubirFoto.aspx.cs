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
                    //Directory.CreateDirectory(path);
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
}