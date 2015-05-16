using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Identificado_BuscadorAvanzado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        actualizarTabla();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e){
        if (TextBox1.Text.Length >= 3){
            Session["BuscadorSin"] = new EN.Buscador(new CAD.Buscador().buscarSin,TextBox1.Text);
            actualizarTabla();
        }
    }
    protected void Button_Paginas(object sender, EventArgs e){
        Button but = (Button)sender;
        if (Session["BuscadorSin"] == null){
            actualizarTabla();
        }else{
            EN.Buscador busca = (EN.Buscador)Session["BuscadorSin"];
            switch (but.ID){
                case "<": busca--; busca.actualizaCon(Table1.Rows); break;
                case ">": busca++; busca.actualizaCon(Table1.Rows); break;
                default:
                    busca.Pagina = Int32.Parse(but.ID) - 1;
                    busca.actualizaCon(Table1.Rows);
                    break;
            }
            actualizarTabla();
        }
    }
    private void actualizarTabla(){
        Table1.Rows.Clear();
        if (Session["BuscadorSin"] == null){
            TableRow row1 = new TableRow();
            TableCell t1 = new TableCell();
            Label label1 = new Label();
            label1.Text = "No se han realizado busquedas recientemente";
            t1.Controls.Add(label1);
            row1.Cells.Add(t1);
            Table2.Rows.Add(row1);
        }else{
            EN.Buscador b = (EN.Buscador)Session["BuscadorSin"];
            b.actualizaCon(Table2.Rows);
            int cant = b.Max;
            if (cant != 1){
                Table1.Rows.Add(new TableRow());
                Button aux1 = new Button();
                aux1.ID = "<";
                aux1.Text = "<";
                aux1.CssClass = "botonBuscador";
                aux1.Click += new EventHandler(this.Button_Paginas);
                TableCell aux2 = new TableCell();
                aux2.Controls.Add(aux1);
                Table1.Rows[0].Cells.Add(aux2);
                for (int i = 1; i <= cant; i++){
                    aux1 = new Button();
                    aux1.ID = "" + i;
                    aux1.Text = "" + i;
                    aux1.CssClass = "botonBuscador";
                    aux1.Click += new EventHandler(this.Button_Paginas);
                    aux2 = new TableCell();
                    aux2.Controls.Add(aux1);
                    Table1.Rows[0].Cells.Add(aux2);
                }
                aux1 = new Button();
                aux1.ID = ">";
                aux1.Text = ">";
                aux1.CssClass = "botonBuscador";
                aux1.Click += new EventHandler(this.Button_Paginas);
                aux2 = new TableCell();
                aux2.Controls.Add(aux1);
                Table1.Rows[0].Cells.Add(aux2);
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e){

    }
}