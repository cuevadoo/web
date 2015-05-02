using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SinIdentificar_Registrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){

    }
    protected void Button1_Click(object sender, EventArgs e){
        CompareValidator1.ValueToCompare=TextBox7.Text;
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
                    TextBox3.Text,aux1,aux2);
                CAD.Usuario cadUser = new CAD.Usuario();
                cadUser.create(user);
            }catch(CAD.Exception){
                Label10.Text = "Ya existe una cuenta con este email ";
            }
        }else{
            Label10.Text = "Faltan los campos con asteriscos";
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e){
        Button1.Enabled = CheckBox1.Checked;
    }
}