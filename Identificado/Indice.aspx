<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Indice.aspx.cs" Inherits="Identificado_Indice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div>
<asp:TextBox CssClass="box" placeholder="Buscar amigo" ID="TextBox2" runat="server" Width="776px" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />
        <br />
        <center>    
            <asp:Table CssClass="tablaBuscador" ID="Table3" runat="server" Width="800px"></asp:Table>
            <asp:Table ID="Table4" runat="server"></asp:Table>
        </center>

</div>


<div>
    <asp:Table ID="Table1" runat="server" Width="678px">
        <asp:TableRow ID="TableRow1" runat="server">
            <asp:TableCell ID="TableCell1" runat="server">
                <asp:TextBox ID="TextBox1" runat="server" Width="100%" Height="60px" CssClass="box" placeholder="Cuéntale a tus amigos qué estás haciendo" TextMode="MultiLine" EnableViewState="True" EnableTheming="True"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow2" runat="server">
            <asp:TableCell ID="TableCell2" runat="server"><asp:Button ID="Button2" runat="server" Text="Enviar" cssclass="boton" OnClick="Button2_Click"></asp:Button>
                </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    
</div>


<div>
    <asp:Label ID="Label1" runat="server" Text="REGISTRO DE ACTIVIDAD"></asp:Label>
    <asp:Table ID="Table2" runat="server"></asp:Table>
</div>

</asp:Content>

