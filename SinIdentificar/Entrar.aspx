<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Entrar.aspx.cs" Inherits="Ingresar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
        <div>
            <asp:Table runat="server" Border="0">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"><asp:TextBox ID="TextBox1" runat="server" Width="250px" CssClass="box" placeholder="Email"></asp:TextBox></asp:TableCell>
                    <asp:TableCell runat="server"><asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1"></asp:RequiredFieldValidator></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"><asp:TextBox ID="TextBox2" runat="server" Width="250px" style="margin-bottom: 0px" TextMode="Password" CssClass="box" placeholder="Contraseña"></asp:TextBox></asp:TableCell>
                    <asp:TableCell runat="server"><asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox2"></asp:RequiredFieldValidator></asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow ID="TableRow1" runat="server">
                
                    <asp:TableCell COLSPAN="4" runat="server"><center><br /><asp:Button class="boton" ID="Button1" runat="server" Text="Ingresar" OnClick="Button1_Click" /></center></asp:TableCell>
                    
                </asp:TableRow>
            </asp:Table>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
    </center>
</asp:Content>

