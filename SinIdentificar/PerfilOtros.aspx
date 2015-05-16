<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PerfilOtros.aspx.cs" Inherits="SinIdentificar_PerfilOtros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--Esto nos mostrará el perfil basico del usuario que encontraremos si realizamos la busqueda sin estar registrados -->
    <center>
    <div>
        <h3 class="titulo"><asp:Label ID="LabelNombreUsuario" runat="server" Text="Nombre de usuario"></asp:Label></h3>
        <br />
        <asp:Image ID="UserImage1" runat="server" Height="198px" Width="250px" />
        <br />
    </div></center>
    <div>
    <center><p style="text-decoration-line:underline">Datos personales</p></center>
            
    <center>
    <asp:Table ID="Table2" runat="server">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                <asp:Label runat="server" Text="País: "></asp:Label><asp:Label ID="LabelPais" runat="server" Text="No especificado" Backcolor="white" width="160px"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server" >
                <asp:Label runat="server" Text="C.Autónoma/Estado: "></asp:Label><asp:Label ID="LabelCAutonoma" runat="server" Text="No especificado" Backcolor="white" width="160px"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server">
                <asp:Label runat="server" Text="Localidad: "></asp:Label><asp:Label ID="LabelLocalidad" runat="server" Text="No especificado" Backcolor="white" width="160px"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>
<div>
    <center><h3>Publicación más reciente</h3></center>
     <!--publicaciones-->

</div>
<br /><br /> <center>
<div style="width: 800px">
   
<p>Para conseguir más información sobre este usuario; agregarlo a tus amigos; enviarle mensajes y chatear con él, necesitas ser un usuario registrado de Cuevadoo</p>
</div>
</center>


            
            
            

</asp:Content>

