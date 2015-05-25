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
        try
        {
            Usuario user = (Usuario)Session["User"];
            Usuario cambios = new Usuario(user.Email, user.Pass, user.Nombre, user.Apellido1, user.Apellido2, user.Edad, user.Sexo, user.Foto);

            if (TextBoxEmail.Text != "")
            {
                cambios.Email = TextBoxEmail.Text;
                String aux = Hash.getHash(TextBoxEmail.Text + TextBoxNewPass.Text);
                cambios.Pass = aux;
            }
            else { 
                String aux = Hash.getHash(user.Email + TextBoxNewPass.Text);
                cambios.Pass = aux;
            }
            if (TextBoxNombre.Text != "") { cambios.Nombre = TextBoxNombre.Text; }
            if (TextBoxApellido1.Text != "") { cambios.Apellido1 = TextBoxApellido1.Text; }
            if (TextBoxApellido2.Text != "") { cambios.Apellido2 = TextBoxApellido2.Text; }
            if (TextBoxOldPass.Text != "" && TextBoxNewPass.Text != "")
            {
                String hash = Hash.getHash(user.Email + TextBoxOldPass.Text);
                if (hash == user.Pass)
                {
                    new CAD.Usuario().update(user, cambios);
                    LabelError.Text = "Cambios guardados correctamente";
                    Session["User"] = cambios;
                }
                else { LabelError.Text = "Contraseña incorrecta"; }
            }
            else { LabelError.Text = "Contraseña requerida"; }
            
        }
        catch (CAD.Exception ex) { LabelError.Text = "No se han podido guardar los cambios"; }
    }
}