﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    static Conexion c = new Conexion();
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable tabla=c.ejecutarR("SELECT * FROM USUARIOS");
        Label1.Text = (string)tabla.Rows[0][0];
        Label2.Text = (string)tabla.Rows[0][1];
        Label3.Text = (string)tabla.Rows[0][2];
        Label4.Text = (string)tabla.Rows[0][3];
    }

}