<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ayuda.aspx.cs" Inherits="SinIdentificar_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <center>
        <p>SECCIÓN DE AYUDA</p></center>
        <p>Para cualquier reclamación o consulta sobre la página web de Cuevadoo y sus políticas asociadas, puede utilizar el siguiente formulario o puede ponerse en contacto mediante las otras opciones que abajo se muestran</p>
        <asp:Table ID="Table1" runat="server" Width="548px">
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell ID="TableCell1" runat="server">
                    <asp:TextBox ID="TextBox1" runat="server" Width="50%" CssClass="box" placeholder="Tu Email"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow2" runat="server">
                <asp:TableCell ID="TableCell2" runat="server">
                    <asp:TextBox ID="TextBox2" runat="server" Width="100%" Height="150px" CssClass="box" placeholder="Escribe aquí tu consulta"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow3" runat="server">
                <asp:TableCell ID="TableCell3" runat="server"><asp:Button ID="Button1" runat="server" Text="Enviar" cssclass="boton" OnClick="Button1_Click"></asp:Button>
                    </asp:TableCell>   
            </asp:TableRow>
        </asp:Table>

        <p>Direcciones de contacto</p>
        <p>Correo electrónico: cuevadoo@help.org</p>
        <p>Teléfono de atención al cliente: 902 253 651</p>
        <p>	Carretera de San Vicente del Raspeig, s/n, Politécnica 1, "La Cueva", 03690 Alicante</p>

    </div>
    
</asp:Content>

