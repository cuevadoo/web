using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;

public partial class Identificado_Indice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        actualizarTabla();
    }
    
    protected void Redirect(object sender, EventArgs e){
        Button b = (Button)sender;
        HttpContext.Current.Session["PerfilOtro"] = new CAD.Usuario().read(b.Style["email"]);
        HttpContext.Current.Response.Redirect("~/Identificado/PerfilOtros.aspx");
    }

    protected void TableAmigos_Load(object sender, EventArgs e) {
        EN.Relaciones rel = (EN.Relaciones)Session["Relaciones"];
        Table t = (Table)sender;
        t.Rows.Clear();
        TableRow row = new TableRow();
        row.Height = 30;
        TableCell cell = new TableCell();
        cell.Text = "<p class='titulo' style='text-align:center;margin:10px'>Amigos</p>";
        row.Cells.Add(cell);
        t.Rows.Add(row);
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
                label.Click += new EventHandler(this.Redirect);
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

    protected void TextBox1_TextChanged(object sender, EventArgs e){
        CAD.Usuario user=new CAD.Usuario();
        Session["BuscadorIS"] = new EN.Buscador(new CAD.Buscador().buscarSin, TextBox1.Text);
        actualizarTabla();
    }

    protected void Button_Paginas(object sender, EventArgs e){
        Button but=(Button) sender;
        if (Session["BuscadorIS"]==null){
            actualizarTabla();
        }else{
            EN.Buscador busca = (EN.Buscador)Session["BuscadorIS"];
            switch(but.ID){
                case "<": busca--; busca.actualizaCon(Table1.Rows, Redirect); break;
                case ">": busca++; busca.actualizaCon(Table1.Rows, Redirect); break;
                default:
                    busca.Pagina=Int32.Parse(but.ID)-1;
                    busca.actualizaCon(Table1.Rows, Redirect);
                    break;
            }
            actualizarTabla();
        }
    }
    private void actualizarTabla(){
        Table1.Rows.Clear();
        ArrayList lButton = new ArrayList();
        if (Session["BuscadorIS"]==null){
            TableRow row1 = new TableRow();
            TableCell t1 = new TableCell();
            Label label1 = new Label();
            label1.Text = "No se han realizado busquedas recientemente";
            t1.Controls.Add(label1);
            row1.Cells.Add(t1);
            Table2.Rows.Add(row1);
        }else{
            EN.Buscador b =(EN.Buscador)Session["BuscadorIS"];
            b.actualizaCon(Table2.Rows, Redirect);
            int cant=b.Max;
            if(cant!=1){
                Table1.Rows.Add(new TableRow());
                Button aux1= new Button();
                aux1.ID = "<";
                aux1.Text = "<";
                aux1.CssClass = "botonBuscador";
                aux1.Click+=new EventHandler(this.Button_Paginas);
                TableCell aux2 = new TableCell();
                aux2.Controls.Add(aux1);
                lButton.Add(aux1);
                Table1.Rows[0].Cells.Add(aux2);
                for (int i=1;i<=cant;i++){
                    aux1 = new Button();
                    aux1.ID = ""+i;
                    aux1.Text = "" + i;
                    aux1.CssClass = "botonBuscador";
                    aux1.Click += new EventHandler(this.Button_Paginas);
                    aux2 = new TableCell();
                    aux2.Controls.Add(aux1);
                    lButton.Add(aux1);
                    Table1.Rows[0].Cells.Add(aux2);
                }
                aux1 = new Button();
                aux1.ID = ">";
                aux1.Text = ">";
                aux1.CssClass = "botonBuscador";
                aux1.Click += new EventHandler(this.Button_Paginas);
                aux2 = new TableCell();
                aux2.Controls.Add(aux1);
                lButton.Add(aux1);
                Table1.Rows[0].Cells.Add(aux2);
            }
        }
        Control c=GetControl();
        if(TextBox1==c){
            fade.Style["display"] = "block";
            light.Style["display"] = "block";
        }else{
            bool comp = true;
            foreach(Button b in lButton){
                if(b==c){
                    fade.Style["display"] = "block";
                    light.Style["display"] = "block";
                    comp = false;
                    break;
                }
            }
            if(comp){
                fade.Style["display"] = "none";
                light.Style["display"] = "none";
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e){
        Usuario Usuario = (Usuario)Session["User"];
        try
        {

            if (TextBoxPublicacion.Text != "")
            {
                String texto = TextBoxPublicacion.Text;
                Fecha fecha = new Fecha(DateTime.Now);
                new CAD.Publicacion().create(new EN.Publicacion(fecha,texto,Usuario.Email));
            }
        }
        catch (CAD.Exception ex)
        {
            LabelError.Text = "  No se pudo enviar la publicación";
        }

    }
    private Control GetControl(){
        string id = Page.Request.Params["__EVENTTARGET"];
        if (!string.IsNullOrEmpty(id)){
            return Page.FindControl(id) as Control;
        }
        foreach (var ctlID in Page.Request.Form.AllKeys){
            Control c = Page.FindControl(ctlID) as Control;
            if (c is Button){
                return c;
            }
        }
        return null;
    }
    protected void TablePublicaciones_Load(object sender, EventArgs e){
        EN.Usuario user = (EN.Usuario)Session["User"];
        ArrayList list = new CAD.Publicacion().read(user.Email);
        Table t = (Table)sender;
        TableRow row;
        TableCell cell;
        foreach (EN.Publicacion p in list){
            t.CssClass = "center";
            row = new TableRow();
            cell = new TableCell();
            Label texto = new Label();
            EN.Usuario user2 = new CAD.Usuario().read(p.Email);
            texto.Text = user2.Nombre + " " + user2.Apellido1 + " " + user2.Apellido2;
            cell.Controls.Add(texto);
            row.Cells.Add(cell);
            cell = new TableCell();
            texto = new Label();
            texto.Text = p.Mensaje;
            cell.Controls.Add(texto);
            row.Cells.Add(cell);
            t.Rows.Add(row);
        }
    }
}