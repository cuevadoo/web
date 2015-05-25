using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;

public partial class Identificado_Configuracion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonGuardar_Click(object sender, EventArgs e)
    {
        Usuario user = (Usuario)Session["User"];
        Usuario cambios = new Usuario(user.Email,user.Pass,user.Nombre,user.Apellido1,user.Apellido2,user.Edad,user.Sexo,user.Foto);

        if (TextBoxEmail.Text != "") { cambios.Email = TextBoxEmail.Text; }
        if(TextBoxNombre.Text!=""){ cambios.Nombre=TextBoxNombre.Text; }
        if (TextBoxApellido1.Text != "") { cambios.Apellido1 = TextBoxApellido1.Text; }
        if (TextBoxApellido2.Text != "") { cambios.Apellido2 = TextBoxApellido2.Text; }
        

    }
}