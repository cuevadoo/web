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
        if (Session["User"] == null){
            Label1.Text = "No estas registrado";
        }
        else {
            Label1.Text = (String)Session["User"];
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["User"]=TextBox1.Text;
    }
}