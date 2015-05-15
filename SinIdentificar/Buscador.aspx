<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Buscador.aspx.cs" Inherits="SinIdentificar_Buscador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--Este seria nuestro buscador basico donde al introducir solamente 3 letras ya nos saldrian todos los uauarios registrados en
        nuestra web. Mediante este buscador solamente podremos ver que usuarios hay registrados y una breve descripción, pero sin poder
        ver su foto de perfil y todos sus gustos-->
    <div id="centrar">
        <asp:TextBox CssClass="box" placeholder="Inserte nombre de usuario" ID="TextBox1" runat="server" Width="776px" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />
        <br />
        <center>    
            <asp:Table CssClass="tablaBuscador" ID="Table2" runat="server" Width="800px"></asp:Table>
            <asp:Table ID="Table1" runat="server"></asp:Table>
        </center>
    </div>
</asp:Content>

