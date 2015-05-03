<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Indice.aspx.cs" Inherits="Identificado_Indice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div>


</div>


<div>
    <asp:Table ID="Table1" runat="server" Width="678px">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                <asp:TextBox ID="TextBox1" runat="server" Width="100%" Height="60px" CssClass="box" placeholder="Cuéntale a tus amigos qué estás haciendo" TextMode="MultiLine" EnableViewState="True" EnableTheming="True"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"><asp:Button ID="Button2" runat="server" Text="Enviar" cssclass="boton" OnClick="Button2_Click"></asp:Button>
                </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    
</div>


<div>


</div>

</asp:Content>

