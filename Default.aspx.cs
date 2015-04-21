using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    static Contador cont = new Contador(0, 1);
    static Conexion c = new Conexion();
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label6.Text =cont.ToString();
        DataTable tabla=c.ejecutarT("SELECT * FROM USUARIOS");
        Label1.Text = (string)tabla.Rows[cont.ToInt()][0];
        Label2.Text = (string)tabla.Rows[cont.ToInt()][1];
        Label3.Text = (string)tabla.Rows[cont.ToInt()][2];
        Label4.Text = (string)tabla.Rows[cont.ToInt()][3];
        Label5.Text = (string)tabla.Rows[cont.ToInt()][4];
        cont++;
    }
}