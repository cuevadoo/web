using System;
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
    protected void TextBox1_TextChanged(object sender, EventArgs e){
        if(TextBox1.Text.Length>=3){
            CAD.Usuario user=new CAD.Usuario();
            Session["BuscadorSin"] = user.buscar(TextBox1.Text);
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
            Table1.Rows.Add(row1);
        }else{
            object[] obj = (object[])Session["BuscadorSin"];
            ArrayList l = (ArrayList)obj[1];
            TableRow row1 = new TableRow();
            TableCell t1 = new TableCell();
            Label label1 = new Label();
            label1.Text = "No se han encontrado Usuarios con ese nombre";
            t1.Controls.Add(label1);
            row1.Cells.Add(t1);
            Table1.Rows.Add(row1);
            bool aux = false;
            foreach (String s in l)
            {
                aux = true;
                TableRow row = new TableRow();
                row.Cells.Add(new TableCell());
                TableCell t = new TableCell();
                Label label = new Label();
                label.Text = s;
                t.Controls.Add(label);
                row.Cells.Add(t);
                Table1.Rows.Add(row);
            }
            if (aux)
            {
                Table1.Rows.Remove(row1);
            }
        }
    }
}