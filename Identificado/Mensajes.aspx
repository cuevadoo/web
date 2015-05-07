<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Mensajes.aspx.cs" Inherits="Identificado_Mensajes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div>
         <asp:Table ID="Table1" runat="server" Width="600px">
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell ID="TableCell2" runat="server">
                    <asp:TextBox ID="TextBox2" runat="server" Width="400px" CssClass="box" placeholder="Asunto"></asp:TextBox></asp:TableCell>
                </asp:TableRow> 
            <asp:TableRow ID="TableRow2" runat="server">
                <asp:TableCell ID="TableCell1" runat="server">
                    <asp:TextBox ID="TextBox1" runat="server" Width="100%" Height="60px" CssClass="box" placeholder="Escribe el mensaje que quieres enviar" TextMode="MultiLine" ></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow3" runat="server">
                <asp:TableCell ID="TableCell3" runat="server">
                    <asp:Button ID="Button1" runat="server" Text="Enviar" class="boton" />
                </asp:TableCell>
            </asp:TableRow>
          </asp:Table>

    </div>
</asp:Content>

