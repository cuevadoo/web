using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class SinIdentificar_Registrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){

    }
    protected void Button1_Click(object sender, EventArgs e){
        RequiredFieldValidator1.Validate();
        if (RequiredFieldValidator1.IsValid){
            try {
                Fecha aux1 = new Fecha(byte.Parse(TextBox6.Text),byte.Parse(TextBox8.Text),Int32.Parse(TextBox9.Text));
                bool aux2;
                if(RadioButtonList1.SelectedIndex == 0){
                    aux2 = true;
                }else{
                    aux2 = false;
                }
                String aux3 = Hash.getHash(TextBox5.Text + TextBox7.Text);
                EN.Usuario user = new EN.Usuario(TextBox5.Text,aux3,TextBox1.Text,TextBox2.Text,
                    TextBox3.Text,aux1,aux2,null);
                new CAD.Usuario().create(user);
                String path = Server.MapPath("~/Imagenes/Usuarios/" + user.Email + "/");
                Directory.CreateDirectory(path);
                Session["User"] = user;
                Response.Redirect("~/Identificado/Indice.aspx");
            }catch(CAD.Exception ex){
                Label1.Visible = true;
            }
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e){
        Button1.Enabled = CheckBox1.Checked;
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args){
        EN.Usuario user=new CAD.Usuario().read(args.Value.ToLower());
        if(user!=null){
            args.IsValid = false;
        }
    }
    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args){
        //Cuando no sea correcta pones args.IsValid = false; y si es correcta nada
    }
}