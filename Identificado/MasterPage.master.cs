using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Identificado_MasterPage : System.Web.UI.MasterPage{

    protected void Page_Unload(object sender, EventArgs e) {
        Session["ChatAbierto"] = ChatAbierto.Checked;
    }

    protected void Page_Load(object sender, EventArgs e){
        if(Session["ChatAbierto"]!=null){
            if((bool) Session["ChatAbierto"]){
                chat.Style["width"] = "300px";
            }
        }
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

    protected void HacerChat(object sender, EventArgs e){
        Button b = (Button)sender;
        EN.Usuario user = (EN.Usuario)Session["User"];
        ArrayList list;
        if(Application[user.Email] != null){
            list = (ArrayList)Application[user.Email];
            EN.Chat chat = new EN.Chat(user.Email);
            chat.conectarChat(b.Style["email"]);
            list.Add(chat);
            Application[user.Email] = list;
        }else{
            list = new ArrayList();
            EN.Chat chat = new EN.Chat(user.Email);
            chat.conectarChat(b.Style["email"]);
            list.Add(chat);
            Application[user.Email] = list;
        }
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
                label.Click += new EventHandler(this.HacerChat);
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
    protected void TableAbiertas_Load(object sender, EventArgs e){
        EN.Usuario user = (EN.Usuario)Session["User"];
        Table t = (Table)sender;
        TableRow row;
        TableCell cell;
        if(Application[user.Email] != null){
            ArrayList list = (ArrayList)Application[user.Email];
            foreach (EN.Chat chat in list){
                row = new TableRow();
                cell = new TableCell();
                Button label = new Button();
                label.CssClass = "BotonChat";
                EN.Usuario en = new CAD.Usuario().read(chat.User2);
                label.Text = en.Nombre + " " + en.Apellido1 + " " + en.Apellido2;
                label.Style["email"] = "" + chat.User2;
                label.Click += new EventHandler(this.HacerChat);
                cell.Controls.Add(label);
                row.Cells.Add(cell);
                row.Height = 30;
                t.Rows.Add(row);
            }
        }
        row = new TableRow();
        cell = new TableCell();
        row.Cells.Add(cell);
        t.Rows.Add(row);
    }
}
