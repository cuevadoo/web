using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SinIdentificar_Registrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "BIENVENIDOS A CUEVADOO";
        Label2.Text = "NOMBRE:";
        Label3.Text = "PRIMER APELLIDO:";
        Label4.Text = "SEGUNDO APELLIDO:";
        Label5.Text = "SEXO:";
        Label6.Text = "EMAIL:";
        Label7.Text = "FECHA DE NACIMIENTO";
        Label8.Text = "CONTRASEÑA:";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        RequiredFieldValidator1.Validate();
        if (RequiredFieldValidator1.IsValid == true)
        {

            //comprobar si es hombre y mujer
            if (RadioButtonList1.SelectedIndex == 0)    //quiere decir que ha marcado hombre
            {
                
            }
            else
            {   //quiere decir que ha marcado mujer
                
            }

        }

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        Button1.Enabled = CheckBox1.Checked;
    }
}