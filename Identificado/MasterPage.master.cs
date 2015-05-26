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
        EN.Usuario user = (EN.Usuario)Session["User"];
        ArrayList list = (ArrayList)Application[user.Email];
        int aux = int.Parse(PosConversacion.Text);
        EN.Chat chat = (EN.Chat)list[aux];
        chat.escribir(user.Email, TextBox1.Text);
        TextoChat_Load();
    }

    protected void HacerChat(object sender, EventArgs e){
        Button b = (Button)sender;
        EN.Usuario user = (EN.Usuario)Session["User"];
        ArrayList list;
        EN.Chat chat = new EN.Chat(user.Email);
        chat.conectarChat(b.Style["email"]);

        if(Application[user.Email] != null){
            list = (ArrayList)Application[user.Email];
            if(!list.Contains(chat)){
                list.Add(chat);
            }
            Application[user.Email] = list;
        }else{
            list = new ArrayList();
            list.Add(chat);
            Application[user.Email] = list;
        }

        if(Application[b.Style["email"]] != null){
            list = (ArrayList)Application[b.Style["email"]];
            if(!list.Contains(chat)){
                list.Add(chat);
            }
            Application[b.Style["email"]] = list;
        }else{
            list = new ArrayList();
            list.Add(chat);
            Application[b.Style["email"]] = list;
        }

        Response.Redirect(Request.RawUrl);
    }

    protected void AbrirChat(object sender, EventArgs e) {
        Button b = (Button)sender;
        EN.Usuario user = new CAD.Usuario().read(b.Style["email"]);
        PosConversacion.Text = b.Style["posicion"];
        ChatUser.Text = user.Nombre;
        NuevosChats.Style["display"] = "none";
        PestañasAbiertas.Style["display"] = "none";
        Conversacion.Style["display"] = "block";
        TextoChat_Load();
    }

    private void TextoChat_Load(){
        TextoChat.InnerHtml = "";
        EN.Usuario user = (EN.Usuario)Session["User"];
        ArrayList list = (ArrayList)Application[user.Email];
        int aux = int.Parse(PosConversacion.Text);
        EN.Chat chat = (EN.Chat)list[aux];
        ArrayList[] listas = chat.actualizar(user.Email);
        foreach(String s in listas[1]){
            TextoChat.InnerHtml += "<div class='ChatO'>" + s + "</div>";
        }
        foreach(String s in listas[0]){
            TextoChat.InnerHtml += "<div class='ChatP'>" + s + "</div>";
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

    protected void TableAbiertas_PreRender(object sender, EventArgs e){
        Table t = (Table)sender;
        EN.Usuario user = (EN.Usuario)Session["User"];
        t.Rows.Clear();
        TableRow row;
        TableCell cell;
        if (Application[user.Email] != null){
            ArrayList list = (ArrayList)Application[user.Email];
            int i = 0;
            foreach (EN.Chat chat in list){
                row = new TableRow();
                cell = new TableCell();
                EN.Usuario en = new CAD.Usuario().read(chat.contrario(user.Email));
                Button label = new Button();
                label.CssClass = "BotonChat";
                label.Style["email"] = "" + en.Email;
                label.Style["posicion"] = "" + i;
                label.Text = en.Nombre + " " + en.Apellido1 + " " + en.Apellido2;
                label.Click += new EventHandler(this.AbrirChat);
                cell.Controls.Add(label);
                row.Cells.Add(cell);
                row.Height = 30;
                t.Rows.Add(row);
                i++;
            }
        }
        row = new TableRow();
        cell = new TableCell();
        row.Cells.Add(cell);
        t.Rows.Add(row);
    }
}
