﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SinIdentificar_Buscador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        actualizarTabla();
    }
    
    protected void Redirect(object sender, EventArgs e){
        Button b = (Button)sender;
        HttpContext.Current.Session["PerfilOtroPublic"] = new CAD.Usuario().read(b.Style["email"]);
        HttpContext.Current.Response.Redirect("~/SinIdentificar/PerfilOtros.aspx");
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e){
        CAD.Usuario user=new CAD.Usuario();
        Session["BuscadorSin"] = new EN.Buscador(new CAD.Buscador().buscarSin, TextBox1.Text);
        actualizarTabla();
    }

    protected void Button_Paginas(object sender, EventArgs e){
        Button but=(Button) sender;
        if (Session["BuscadorSin"]==null){
            actualizarTabla();
        }else{
            EN.Buscador busca = (EN.Buscador)Session["BuscadorSin"];
            switch(but.ID){
                case "<": busca--; busca.actualizaSin(Table1.Rows, Redirect); break;
                case ">": busca++; busca.actualizaSin(Table1.Rows, Redirect); break;
                default:
                    busca.Pagina=Int32.Parse(but.ID)-1;
                    busca.actualizaSin(Table1.Rows, Redirect);
                    break;
            }
            actualizarTabla();
        }
    }

    private void actualizarTabla(){
        Table1.Rows.Clear();
        if (Session["BuscadorSin"]==null){
            TableRow row1 = new TableRow();
            TableCell t1 = new TableCell();
            Label label1 = new Label();
            label1.Text = "No se han realizado busquedas recientemente";
            t1.Controls.Add(label1);
            row1.Cells.Add(t1);
            Table2.Rows.Add(row1);
        }else{
            EN.Buscador b =(EN.Buscador)Session["BuscadorSin"];
            b.actualizaSin(Table2.Rows, Redirect);
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
                Table1.Rows[0].Cells.Add(aux2);
                for (int i=1;i<=cant;i++){
                    aux1 = new Button();
                    aux1.ID = ""+i;
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
}