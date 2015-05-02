using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ingresar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        RequiredFieldValidator1.Validate();
        RequiredFieldValidator2.Validate();
        if (RequiredFieldValidator1.IsValid) {
            try
            {
                string hash = "";
                CAD.Usuario user = new CAD.Usuario();
                EN.Usuario usuario = user.read(TextBox1.Text);
                hash=Hash.getHash(TextBox1.Text + TextBox2.Text);
                if(hash==usuario.Pass){
                    Session["User"] = user.read(TextBox1.Text);
                    Response.Redirect("~/Identificado/Indice.aspx");
                    
                }
                Label3.Text = "Combinación usuario-contraseña incorrecta";

                
                
            }
            catch (CAD.Exception userException) { Label3.Text = "Combinación usuario-contraseña incorrecta"; }
            

        }
    }
}