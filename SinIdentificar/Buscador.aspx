<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Buscador.aspx.cs" Inherits="SinIdentificar_Buscador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:Table ID="Table3" runat="server" Width="100%">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label1" runat="server" Text="Inserte nombre de usuario" Width="220px"></asp:Label>
                </asp:TableCell>
                <asp:TableCell runat="server" Width="100%">
                    <asp:TextBox ID="TextBox1" runat="server" Width="100%" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Table ID="Table2" runat="server" Width="100%">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Table ID="Table1" runat="server" Width="100%"></asp:Table>
    </div>
</asp:Content>

