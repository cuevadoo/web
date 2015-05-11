﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Identificado_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e){
        if(Session["User"]==null){
            Response.Redirect("~/SinIdentificar/Entrar.aspx");
        }
        EN.Usuario aux = (EN.Usuario)Session["User"];
        Session["User"] = aux;
        Menu1.Items[0].Text = aux.Nombre;
    }
    
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e){
        Response.Redirect("~/Identificado/Indice.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e){
        TextoChat.InnerHtml += "<div class='ChatP'>"+TextBox1.Text+"</div><br />";
    }
}
