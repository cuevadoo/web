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
        //EN.GustosFilm g = new CAD.GustosFilm().read(user.Email);
        //Aqui los if con cada atributo
    }
}