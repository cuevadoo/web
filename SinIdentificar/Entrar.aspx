<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Entrar.aspx.cs" Inherits="Ingresar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--En el siguiente div englobamos todo lo relacionado con la parte de ingresar usuario. Donde creamos una tabla con 3 filas y 5
        columnas. En la primera fila es donde tendremos que introducir nuestro email, y a continuación se observará si el email
        es o no valido, mediante el elemento RequiredFieldValidator. En la segunda fila, será igual, pero en este caso tendrémos que
        introducir la contraseña y el RequiredFieldValidator comparará la contraseña introducida, con la que se introdujo cuando se
        realizó el registro -->
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
                    <asp:TableCell COLSPAN="4" runat="server"><center><br /><asp:Button class="boton" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></center></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
    </center>
</asp:Content>

