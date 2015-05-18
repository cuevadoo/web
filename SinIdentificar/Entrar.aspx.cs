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
        Form.DefaultButton = Button1.UniqueID;
        //Session["User"] = new EN.Usuario("a","","Anonimo","","",new Fecha(),true,null);
        //Response.Redirect("~/Identificado/Indice.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        RequiredFieldValidator1.Validate();
        RequiredFieldValidator2.Validate();
        if (RequiredFieldValidator1.IsValid) {
            try
            {
                EN.Usuario usuario = new CAD.Usuario().read(TextBox1.Text);
                String hash = Hash.getHash(TextBox1.Text + TextBox2.Text);
                if(hash==usuario.Pass){
                    Session["User"] = usuario;
                    Response.Redirect("~/Identificado/Indice.aspx");
                }
                Label3.Text = "Combinación usuario-contraseña incorrecta";              
            }
            catch (CAD.Exception userException) { Label3.Text = "Combinación usuario-contraseña incorrecta"; }
            

        }
    }
}