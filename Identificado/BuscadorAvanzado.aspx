<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="BuscadorAvanzado.aspx.cs" Inherits="Identificado_BuscadorAvanzado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--En el siguiente buscador ya se mostrará mucha mas información del usuario, incluyendo una foto de perfil. También podrás añadirlo
        a amigos o enviarle un mensaje privado. En este buscador además añadimos la opción de elegir que quieres buscar, ya sea por nombre, 
        residencia o gustos.-->
    <center>
        <div>
            <asp:Table ID="Table3" runat="server">
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server" columnSpan="2">
                        <!--elegiremos el campo a activar desde el desplegable--> 
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" class="box" AutoPostBack="True">
                            <asp:ListItem>Nombre</asp:ListItem>
                            <asp:ListItem>Residencia</asp:ListItem>
                            <asp:ListItem>Gustos Informáticos</asp:ListItem>
                            <asp:ListItem>Videojuegos</asp:ListItem>
                            <asp:ListItem>Pelis y Series</asp:ListItem>
                            <asp:ListItem>Música</asp:ListItem>
                        </asp:DropDownList></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                </asp:TableRow>
                <!--se mostrará como disponible únicamente el subcampo que activemos en el desplegable superior--> 
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">
                        <asp:DropDownList ID="DropDownNombre" runat="server" Enabled="true" class="box">
                            <asp:ListItem>Nombre</asp:ListItem>
                            <asp:ListItem>Primer Apellido</asp:ListItem>
                            <asp:ListItem>Segundo Apellido</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:DropDownList ID="DropDownResidencia" runat="server" Enabled="false" class="box">
                            <asp:ListItem>País</asp:ListItem>
                            <asp:ListItem>C.Autónoma/Estado</asp:ListItem>
                            <asp:ListItem>Localidad</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:DropDownList ID="DropDownGInf" runat="server" Enabled="false" class="box">
                            <asp:ListItem>SO</asp:ListItem>
                            <asp:ListItem>Marca de Hardware</asp:ListItem>
                            <asp:ListItem>L.Programación</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:DropDownList ID="DropDownVideojuegos" runat="server" Enabled="false" class="box">
                            <asp:ListItem>Género</asp:ListItem>
                            <asp:ListItem>Videojuego</asp:ListItem>
                            <asp:ListItem>Consola</asp:ListItem>
                            <asp:ListItem>Desarrolladora</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:DropDownList ID="DropDownPelisSeries" runat="server" Enabled="false" class="box">
                            <asp:ListItem>Género</asp:ListItem>
                            <asp:ListItem>Director</asp:ListItem>
                            <asp:ListItem>Década</asp:ListItem>
                            <asp:ListItem>Pelicula</asp:ListItem>
                            <asp:ListItem>Género de Serie</asp:ListItem>
                            <asp:ListItem>Actor</asp:ListItem>
                            <asp:ListItem>Productor de Series</asp:ListItem>
                            <asp:ListItem>Serie</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:DropDownList ID="DropDownMusica" runat="server" Enabled="false" class="box">
                            <asp:ListItem>Estilo</asp:ListItem>
                            <asp:ListItem>Grupo</asp:ListItem>
                            <asp:ListItem>Artista</asp:ListItem>
                            <asp:ListItem>Década</asp:ListItem>
                            <asp:ListItem>Concierto</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </center>
    <!--cuadro de texto para la búsqeuda avanzada--> 
    <div id="centrar">
        <asp:TextBox CssClass="box" placeholder="Inserte dato de búsqueda" ID="TextBox1" runat="server" Width="776px" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />
        <center>
            <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="500" DynamicLayout="False">
                <ProgressTemplate>
                    Se esta realizando la busqueda
                </ProgressTemplate>
            </asp:UpdateProgress>
            <asp:Table CssClass="tablaBuscador" ID="Table2" runat="server" Width="800px"></asp:Table>
            <asp:Table ID="Table1" runat="server"></asp:Table>
        </center>
    </div>







</asp:Content>
