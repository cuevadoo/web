<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ingresar.aspx.cs" Inherits="Ingresar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        <asp:label runat="server" text="Contraseña"></asp:label>

        <br />
        <asp:Button class="boton" ID="Button1" runat="server" Text="Ingresar" OnClick="Button1_Click" />
    </div>
</asp:Content>

