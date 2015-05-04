using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Identificado_Indice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        actualizarTabla();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e){
        if(TextBox1.Text.Length>=3){
            CAD.Usuario user=new CAD.Usuario();
            Session["BuscadorIS"] = new EN.Buscador(user.buscar(TextBox1.Text));
            actualizarTabla();
        }
    }
    protected void Button_Paginas(object sender, EventArgs e){
        Button but=(Button) sender;
        if (Session["BuscadorIS"]==null){
            actualizarTabla();
        }else{
            EN.Buscador busca = (EN.Buscador)Session["BuscadorSin"];
            switch(but.ID){
                case "<": busca--;busca.actualizaSin(Table1.Rows);break;
                case ">": busca++;busca.actualizaSin(Table1.Rows);break;
                default:
                    busca.Pagina=Int32.Parse(but.ID)-1;
                    busca.actualizaSin(Table1.Rows);
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
            b.actualizaSin(Table2.Rows);
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
            Label1.Text = "Hola2";
        }else{
            Label1.Text = "Hola";
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

    }
    protected void Button2_Click(object sender, EventArgs e){

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
}