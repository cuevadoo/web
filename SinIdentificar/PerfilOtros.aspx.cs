using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SinIdentificar_PerfilOtros : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        EN.Usuario user = (EN.Usuario)Session["PerfilOtroPublic"];
        if(user!=null){
            if (user.Foto == null){
                UserImage1.ImageUrl = "~/Imagenes/ImagenPerfil.jpg";
            }else{
                UserImage1.ImageUrl = "~/Imagenes/Usuarios/" + user.Email + "/prev.png";
            }
            //Residencia
            try {
                EN.Residencia r = new CAD.Residencia().read(user.Email);
                if (r.Pais != null){
                    LabelPais.Text = r.Pais;
                }
                if (r.CAutonoma != null){
                    LabelCAutonoma.Text = r.CAutonoma;
                }
                if (r.Localidad != null){
                    LabelLocalidad.Text = r.Localidad;
                }
            }catch(CAD.Exception ex){}
        }
    }
}