using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "hola";
        Conexion c = new Conexion();
        DataSet data=c.ejecutar("SELECT * FROM USUARIOS");
        DataTable tabla=data.Tables["cosas"];
        GridView1.DataSource = data;
        Label1.Text = tabla.Rows[0].ToString();
    }
}