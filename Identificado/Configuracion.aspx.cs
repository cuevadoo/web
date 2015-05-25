using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;

public partial class Identificado_Configuracion : System.Web.UI.Page
{
    //no hace nada aun 
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Usuario user = (Usuario)Session["User"];
            Usuario cambios = new Usuario(user.Email, user.Pass, user.Nombre, user.Apellido1, user.Apellido2, user.Edad, user.Sexo, user.Foto);

            if (TextBoxEmail.Text != "")
            {
                cambios.Email = TextBoxEmail.Text;
                String aux = Hash.getHash(TextBoxEmail.Text + TextBoxNewPass.Text);
                cambios.Pass = aux;
            }
            else { 
                String aux = Hash.getHash(user.Email + TextBoxNewPass.Text);
                cambios.Pass = aux;
            }
            if (TextBoxNombre.Text != "") { cambios.Nombre = TextBoxNombre.Text; }
            if (TextBoxApellido1.Text != "") { cambios.Apellido1 = TextBoxApellido1.Text; }
            if (TextBoxApellido2.Text != "") { cambios.Apellido2 = TextBoxApellido2.Text; }
            if (TextBoxOldPass.Text != "" && TextBoxNewPass.Text != "")
            {
                String hash = Hash.getHash(user.Email + TextBoxOldPass.Text);
                if (hash == user.Pass)
                {
                    new CAD.Usuario().update(user, cambios);
                    //Actualización de gustos
                    try
                    {
                        EN.GustosFilm gf = new CAD.GustosFilm().read(user.Email);
                        gf.Email = cambios.Email;
                        EN.GustosFilm gfv = new GustosFilm(null, null, 0, null, null, null, null, null, user.Email);
                        new CAD.GustosFilm().update(gfv, gf);
                    }
                    catch(CAD.Exception ex) { }

                    try
                    {
                        EN.GustosMusicales gm = new CAD.GustosMusicales().read(user.Email);
                        gm.Email = cambios.Email;
                        EN.GustosMusicales gmv = new GustosMusicales(null, null, null, null, 0, user.Email);
                        new CAD.GustosMusicales().update(gmv, gm);
                    }
                    catch (CAD.Exception ex) { }

                    try
                    {
                        EN.GustosOrdenadores gi = new CAD.GustosOrdenadores().read(user.Email);
                        gi.Email = cambios.Email;
                        EN.GustosOrdenadores giv = new GustosOrdenadores(null, null, null, user.Email);
                        new CAD.GustosOrdenadores().update(giv, gi);
                    }
                    catch (CAD.Exception ex) { }

                    try
                    {
                        EN.GustosVideojuegos gv = new CAD.GustosVideojuegos().read(user.Email);
                        gv.Email = cambios.Email;
                        EN.GustosVideojuegos gvv = new GustosVideojuegos(null, null, null, null, user.Email);
                        new CAD.GustosVideojuegos().update(gvv, gv);
                    }
                    catch (CAD.Exception ex) { }
                    try
                    {
                        EN.Relaciones re = new CAD.Relaciones().read(user.Email);
                        EN.Relaciones rev = new CAD.Relaciones().read(user.Email);
                        re.Usuario1 = cambios.Email;
                        new CAD.Relaciones().update(rev, re);
                    }
                    catch (CAD.Exception ex) { }
                    try
                    {
                        EN.Residencia res = new CAD.Residencia().read(user.Email);
                        res.Email = cambios.Email;
                        EN.Residencia resv = new Residencia(null, null, null, user.Email);
                        new CAD.Residencia().update(resv, res);
                    }
                    catch (CAD.Exception ex) { }

                    LabelError.Text = "Cambios guardados correctamente";
                    Session["User"] = cambios;
                }
                else { LabelError.Text = "Contraseña incorrecta"; }
            }
            else { LabelError.Text = "Contraseña requerida"; }
            
        }
        catch (CAD.Exception ex) { LabelError.Text = "No se han podido guardar los cambios"; }
    }
}