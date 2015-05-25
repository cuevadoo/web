using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Identificado_Mensajes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){

    }
    protected void Table1_Load(object sender, EventArgs e){       
        EN.Usuario user = (EN.Usuario)Session["User"];
        ArrayList list = new CAD.MensajePrivado().read(user.Email);
        Table t = (Table)sender;
        
        foreach(EN.MensajePrivado m in list){
            Table1.CssClass = "center";
            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            Label texto = new Label();
            //Llamar al CAD de usuario para sacar nombre
            EN.Usuario user2 = new CAD.Usuario().read(m.Usuario1);
            texto.Text = user2.Nombre + " " + user2.Apellido1 + " " + user2.Apellido2;
            cell.Controls.Add(texto);
            row.Cells.Add(cell);
            cell = new TableCell();
            texto = new Label();
            texto.Text = m.Texto;
            cell.Controls.Add(texto);
            row.Cells.Add(cell);
            t.Rows.Add(row);
        }
    }
}