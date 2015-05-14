using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Identificado_Fotos : System.Web.UI.Page
{
     protected void Page_Load(object sender, EventArgs e){
        if(Session["User"]==null){
            Response.Redirect("~/SinIdentificar/Entrar.aspx");
        }
        EN.Usuario aux = (EN.Usuario)Session["User"];
        Menu1.Items[0].Text = aux.Nombre;
    }

    protected void Table3_Load(object sender, EventArgs e){
        Table t = (Table)sender;
        EN.Usuario user =(EN.Usuario) Session["User"];
        String[] dirs = Directory.GetFiles(Server.MapPath("~/Imagenes/Usuarios/" + user.Email + "/"));
        TableRow row = new TableRow();
        int i=0;
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
            if(i<=6){
                i++;
            }else{
                i = 0;
                t.Rows.Add(row);
                row = new TableRow();
            }
        }
        if(i<=6){
            t.Rows.Add(row);
        }
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
}