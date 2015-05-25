using System;
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
        EN.Relaciones relaciones = new CAD.Relaciones().read(aux.Email);
        Session["Relaciones"] = relaciones;
    }
    
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e){
        Response.Redirect("~/Identificado/Indice.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e){
        TextoChat.InnerHtml += "<div class='ChatP'>" + TextBox1.Text + "</div>";
    }
    protected void TableAmigos_Load(object sender, EventArgs e) {
        EN.Relaciones rel = (EN.Relaciones)Session["Relaciones"];
        Table t = (Table)sender;
        t.Rows.Clear();
        TableRow row;
        TableCell cell;
        System.Collections.ArrayList array = rel.Usuarios;
        foreach(String user in array){
            if(rel.isAceptada(user)){
                row = new TableRow();
                cell = new TableCell();
                Button label = new Button();
                label.CssClass = "BotonChat";
                EN.Usuario en = new CAD.Usuario().read(user);
                label.Text = en.Nombre + " " + en.Apellido1 + " " + en.Apellido2;
                label.Style["email"] = "" + user;
                cell.Controls.Add(label);
                row.Cells.Add(cell);
                row.Height=30;
                t.Rows.Add(row);
            }
        }
        row = new TableRow();
        cell = new TableCell();
        row.Cells.Add(cell);
        t.Rows.Add(row);
    }
}
