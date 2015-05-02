<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ingresar.aspx.cs" Inherits="Ingresar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
        <div>
            <asp:Table runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell ID="TableCell1" runat="server"><asp:Label ID="Label1" runat="server" Text="Email"></asp:Label></asp:TableCell>
                    <asp:TableCell runat="server"><asp:TextBox ID="TextBox1" runat="server" Width="100%"></asp:TextBox></asp:TableCell>
                    <asp:TableCell runat="server"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="&nbsp;*" ControlToValidate="TextBox1"></asp:RequiredFieldValidator></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell ID="TableCell2" runat="server"><asp:Label ID="Label2" runat="server" text="Contraseña"></asp:Label></asp:TableCell>
                    <asp:TableCell runat="server"><asp:TextBox ID="TextBox2" runat="server" Width="100%" style="margin-bottom: 0px" TextMode="Password"></asp:TextBox></asp:TableCell>
                    <asp:TableCell runat="server"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="&nbsp;*" ControlToValidate="TextBox2"></asp:RequiredFieldValidator></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="TableRow1" runat="server">
                    <asp:TableCell runat="server"><asp:Button class="boton" ID="Button1" runat="server" Text="Ingresar" OnClick="Button1_Click" /></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
    </center>
</asp:Content>

