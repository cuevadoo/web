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
                if(FileUpload1.FileBytes.Length<4194304){
                    EN.Usuario user = (EN.Usuario) Session["User"];
                    String path= Server.MapPath("~/Imagenes/Usuarios/"+user.Email);
                    try{
                        FileUpload1.PostedFile.SaveAs(path + "");//Falta la codificacion de la imagen
                        Label1.Text = "Subido con exito";
                    }catch (Exception ex){
                        Label1.Text = "No se ha podido subir";
                    }
                }else{
                    Label1.Text = "El archivo supera los 4MB";
                }
            }else{
                Label1.Text = "El archivo no es una imagen jpg, jpeg o png";
            }
        }else{
            Label1.Text = "No se ha seleccionado un archivo";
        }
    }
}