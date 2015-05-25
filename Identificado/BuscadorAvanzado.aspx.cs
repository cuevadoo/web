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
    //text box para la búsqueda avanzada
    protected void TextBox1_TextChanged(object sender, EventArgs e){
        //búsqueda por nombre 
        if(DropDownNombre.Enabled){
            if (DropDownNombre.SelectedIndex == 0){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarNombre, TextBox1.Text);
            }
            if (DropDownNombre.SelectedIndex == 1){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarApellido1, TextBox1.Text);
            }
            if (DropDownNombre.SelectedIndex == 2){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarApellido2, TextBox1.Text);
            }
        }
        //búsqueda por residencia 
        if(DropDownResidencia.Enabled){
            if(DropDownResidencia.SelectedIndex == 0){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarPais, TextBox1.Text);
            }
            if(DropDownResidencia.SelectedIndex == 1){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarCAutonoma, TextBox1.Text);
            }
            if(DropDownResidencia.SelectedIndex == 2){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarLocalidad, TextBox1.Text);
            }
        }
        //búsqueda por gustos informáticos
        if(DropDownGInf.Enabled){
            if (DropDownGInf.SelectedIndex == 0){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarSO, TextBox1.Text);
            }
            if (DropDownGInf.SelectedIndex == 1){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarMarcashw, TextBox1.Text);
            }
            if (DropDownGInf.SelectedIndex == 2){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarLprogramacion, TextBox1.Text);
            }
        }
        //búsqueda por gustos videojuegos
        if(DropDownVideojuegos.Enabled){
            if (DropDownVideojuegos.SelectedIndex == 0){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarGeneroV, TextBox1.Text);
            }
            if (DropDownVideojuegos.SelectedIndex == 1){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarJuegofav, TextBox1.Text);
            }
            if (DropDownVideojuegos.SelectedIndex == 2){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarConsolafav, TextBox1.Text);
            }
            if (DropDownVideojuegos.SelectedIndex == 3){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarDesarrolladorfav, TextBox1.Text);
            }
        }
        //búsqueda por gustos filmográficos
        if(DropDownPelisSeries.Enabled){
            if (DropDownPelisSeries.SelectedIndex == 0){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarGeneroF, TextBox1.Text);
            }
            if (DropDownPelisSeries.SelectedIndex == 1){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarDirector, TextBox1.Text);
            }
            if (DropDownPelisSeries.SelectedIndex == 2){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarDecadaF, TextBox1.Text);
            }
            if (DropDownPelisSeries.SelectedIndex == 3){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarPelicula, TextBox1.Text);
            }
            if (DropDownPelisSeries.SelectedIndex == 4){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarSGenero, TextBox1.Text);
            }
            if (DropDownPelisSeries.SelectedIndex == 5){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarActor, TextBox1.Text);
            }
            if (DropDownPelisSeries.SelectedIndex == 6){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarSDirector, TextBox1.Text);
            }
            if (DropDownPelisSeries.SelectedIndex == 7){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarSerie, TextBox1.Text);
            }
        }
        //búsqueda por gustos musicales
        if(DropDownMusica.Enabled){
            if (DropDownMusica.SelectedIndex == 0){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarEstilo, TextBox1.Text);
            }
            if (DropDownMusica.SelectedIndex == 1){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarGrupo, TextBox1.Text);
            }
            if (DropDownMusica.SelectedIndex == 2){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarArtista, TextBox1.Text);
            }
            if (DropDownMusica.SelectedIndex == 3){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarDecadaM, TextBox1.Text);
            }
            if (DropDownMusica.SelectedIndex == 4){
                Session["BuscadorCon"] = new EN.Buscador(new CAD.Buscador().buscarConcierto, TextBox1.Text);
            }
        }
        actualizarTabla();
    }
    //datos mostrados de búsqueda 
    protected void Redirect(object sender, EventArgs e){
        Button b = (Button)sender;
        HttpContext.Current.Session["PerfilOtro"] = new CAD.Usuario().read(b.Style["email"]);
        HttpContext.Current.Response.Redirect("~/Identificado/PerfilOtros.aspx");
    }
    //botones para pasar las págines en caso de muchos resultados
    protected void Button_Paginas(object sender, EventArgs e){
        Button but = (Button)sender;
        if (Session["BuscadorSin"] == null){
            actualizarTabla();
        }else{
            EN.Buscador busca = (EN.Buscador)Session["BuscadorCon"];
            switch (but.ID){
                case "<": busca--; busca.actualizaCon(Table1.Rows,Redirect); break;
                case ">": busca++; busca.actualizaCon(Table1.Rows, Redirect); break;
                default:
                    busca.Pagina = Int32.Parse(but.ID) - 1;
                    busca.actualizaCon(Table1.Rows, Redirect);
                    break;
            }
            actualizarTabla();
        }
    }
    //actualización de la tabla depues de la busqueda
    private void actualizarTabla(){
        Table1.Rows.Clear();
        if (Session["BuscadorCon"] == null){
            TableRow row1 = new TableRow();
            TableCell t1 = new TableCell();
            Label label1 = new Label();
            label1.Text = "No se han realizado busquedas recientemente";
            t1.Controls.Add(label1);
            row1.Cells.Add(t1);
            Table2.Rows.Add(row1);
        }else{
            EN.Buscador b = (EN.Buscador)Session["BuscadorCon"];
            b.actualizaCon(Table2.Rows, Redirect);
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
    //activación de los subcampos de búsqueda a partir del campo superior que elijamos
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e){
        DropDownNombre.Enabled = false;
        DropDownResidencia.Enabled = false;
        DropDownGInf.Enabled = false;
        DropDownVideojuegos.Enabled = false;
        DropDownPelisSeries.Enabled = false;
        DropDownMusica.Enabled = false;
        if(DropDownList1.SelectedValue=="Nombre"){
            DropDownNombre.Enabled = true;
        }
        if(DropDownList1.SelectedValue=="Residencia"){
            DropDownResidencia.Enabled = true;
        }
        if(DropDownList1.SelectedValue=="Gustos Informáticos"){
            DropDownGInf.Enabled = true;
        }
        if(DropDownList1.SelectedValue=="Videojuegos"){
            DropDownVideojuegos.Enabled = true;
        }
        if(DropDownList1.SelectedValue=="Pelis y Series"){
            DropDownPelisSeries.Enabled = true;
        }
        if(DropDownList1.SelectedValue=="Música"){
            DropDownMusica.Enabled = true;
        }
    }
}