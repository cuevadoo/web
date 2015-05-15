using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class SinIdentificar_Registrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        Form.DefaultButton = Button1.UniqueID;
    }
    protected void Button1_Click(object sender, EventArgs e){
        Page.Validate();
        RequiredFieldValidator1.Validate();
        if (Page.IsValid&&RequiredFieldValidator1.IsValid){
            try {
                Fecha aux1 = new Fecha(byte.Parse(TextBox6.Text),byte.Parse(TextBox8.Text),Int32.Parse(TextBox9.Text));
                bool aux2;
                if(RadioButtonList1.SelectedIndex == 0){
                    aux2 = true;
                }else{
                    aux2 = false;
                }
                String aux3 = Hash.getHash(TextBox5.Text + TextBox7.Text);
                EN.Usuario user = new EN.Usuario(TextBox5.Text,aux3,TextBox1.Text,TextBox2.Text,
                    TextBox3.Text,aux1,aux2,null);
                new CAD.Usuario().create(user);
                String path = Server.MapPath("~/Imagenes/Usuarios/" + user.Email + "/");
                Directory.CreateDirectory(path);
                Session["User"] = user;
                Response.Redirect("~/Identificado/Indice.aspx");
            }catch(CAD.Exception ex){
                Label1.Visible = true;
            }
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e){
        Button1.Enabled = CheckBox1.Checked;
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args){
        try {
            EN.Usuario user=new CAD.Usuario().read(args.Value.ToLower());
            if(user!=null){
                args.IsValid = false;
            }
        }catch(CAD.Exception ex){}
    }
    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args){
        //Cuando no sea correcta pones args.IsValid = false; y si es correcta nada 6 8 9
        try{
            int dia = Int32.Parse(TextBox6.Text);
            int mes = Int32.Parse(TextBox8.Text);
            int anyo = Int32.Parse(TextBox9.Text);

            if (!esCorrecto(dia, mes, anyo)){
                args.IsValid = false;
            }
        }
        catch (Exception excepcion) { args.IsValid = false; }
    }
        
    //Año Bisiesto
    private bool esBisiesto(int anyo) {
        bool bisiesto=false;
        if((anyo%4==0) && (anyo%400==0 || anyo%100!=0)) {
            bisiesto=true;
        }
        return bisiesto; 
    }
    private bool Mes_impar(int mes) {
        if(mes==1||mes==3||mes==5||mes==7||mes==8||mes==10||mes==12) {
            return true;
        }
        return false;
    }
 
    //Meses con 30 Días
    private bool Mes_par(int mes) {
        if(mes==4||mes==6||mes==9||mes==11) {
            return true;
        }
        return false;
    }

    private bool esCorrecto(int dia, int mes, int anyo) {
        if(dia<1 || dia>31 || mes<1 ||mes>12 || anyo<1900) { //Error si se pasa de los límites
            return false;
        }else {
            if(Mes_par(mes) && (dia<=30)) { //Meses con 30 días
                return true;
            }else{
                if(Mes_impar(mes) && (dia<=31)) { //Meses con 31 días
                    return true;
                }else{
                    if(mes==2) { //Febrero
                        if(esBisiesto(anyo) && (dia<=29)) { //Si es febrero y bisiesto, 29 días o menos
                            return true;
                        }else{
                            if(dia<=28) { //Si es febrero y no bisiesto, 28 días o menos
                                return true;
                            }
                        }
                    }
                }
            }
        }
        return false;
    }
}