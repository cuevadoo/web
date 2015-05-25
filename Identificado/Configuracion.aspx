<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Configuracion.aspx.cs" Inherits="Identificado_Configuracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--Aqui nos encargaremos de configurar y poder reemplazar la información de nuestro usuario. Ya sea el nombre de usuario, apellidos, 
        email y la contraseña -->
    <center>
        <div>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">
                        <h3 class="titulo">CONFIGURACIÓN DE CUENTA</h3><br />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBoxNombre" runat="server" CssClass="box" placeholder="Cambia tu nombre de usuario" Width="100%"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBoxApellido1" runat="server" CssClass="box" placeholder="Cambia tu primer apellido" Width="100%"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBoxApellido2" runat="server" CssClass="box" placeholder="Cambia tu segundo apellido" Width="100%"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="box" placeholder="Cambia tu Email" Width="100%"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow  runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">
                        <br />
                        <p>Cambio de contraseña</p>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell  runat="server">
                        <asp:TextBox ID="TextBoxOldPass" runat="server" CssClass="box" placeholder="Contraseña anterior" Width="100%"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell  runat="server">
                        <asp:TextBox ID="TextBoxNewPass" runat="server" CssClass="box" placeholder="Nueva contraseña" Width="100%"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow  runat="server">
                    <asp:TableCell runat="server">
                        <br />
                        <center>
                            <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" cssclass="boton" OnClick="ButtonGuardar_Click" /><asp:Button>
                        </center>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </center>



</asp:Content>

