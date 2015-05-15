using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// En la siguiente EN vamos a tratar nuestro buscador de la red social
/// </summary>
namespace EN
{
    public class Buscador{
        private int pagina;
        private int max;
        private ArrayList lista;
        private String imageRute;

        public Buscador(object[] obj){
            pagina=0;
            if (obj.Length == 2){
                imageRute = (String)obj[0];
                lista = (ArrayList)obj[1];
                max = ((lista.Count-1)/10);
            }else{

            }
        }
        public TableRowCollection actualizaSin(TableRowCollection rows){
            rows.Clear();
            TableRow row1 = new TableRow();
            TableCell t1 = new TableCell();
            Label label1 = new Label();
            label1.Text = "No se han encontrado Usuarios con ese nombre";
            t1.Controls.Add(label1);
            row1.Cells.Add(t1);
            rows.Add(row1);
            bool aux = false;
            int cont = lista.Count-pagina*10;
            if(cont>10){
                cont = 10;
            }
            IEnumerator num = lista.GetEnumerator(pagina*10,cont);
            while (num.MoveNext()){
                String s =(String) num.Current;
                aux = true;
                TableRow row = new TableRow();
                row.Cells.Add(new TableCell());
                TableCell t = new TableCell();
                Button label = new Button();
                label.CssClass = "BotonChat";
                label.Text = s;
                t.Controls.Add(label);
                row.Cells.Add(t);
                rows.Add(row);
            }
            if (aux){
                rows.Remove(row1);
            }
            return rows;
        }
        public TableRowCollection actualizaCon(TableRowCollection rows) {
            rows.Clear();
            TableRow row1 = new TableRow();
            TableCell t1 = new TableCell();
            Label label1 = new Label();
            label1.Text = "No se han encontrado Usuarios con ese nombre";
            t1.Controls.Add(label1);
            row1.Cells.Add(t1);
            rows.Add(row1);
            bool aux = false;
            int cont = lista.Count-pagina*10;
            if(cont>10){
                cont = 10;
            }
            IEnumerator num = lista.GetEnumerator(pagina*10,cont);
            while (num.MoveNext()){
                String s =(String) num.Current;
                aux = true;
                TableRow row = new TableRow();
                row.Cells.Add(new TableCell());
                TableCell t = new TableCell();
                ImageButton image = new ImageButton();
                image.ImageUrl = "~/Imagenes/Usuarios/daloalga2@gmail.com" + "/prev.png";
                image.Height = 25;
                image.Width = 25;
                t.Controls.Add(image);
                row.Cells.Add(t);
                Button label = new Button();
                label.CssClass = "BotonChat";
                label.Text = s;
                t.Controls.Add(label);
                row.Cells.Add(t);
                rows.Add(row);
            }
            if (aux){
                rows.Remove(row1);
            }
            return rows;
        }
        public static Buscador operator++(Buscador b){
            if(b.pagina<b.max){
                b.pagina++;
            }
            return b;
        }public static Buscador operator--(Buscador b){
            if(b.pagina>0){
                b.pagina--;
            }
            return b;
        }
        public int Pagina{
            get { return pagina; }
            set {if(value<=max&&value>=0){pagina = value;}}
        }
        public int Max{
            get { return max+1; }
        }
    }
}