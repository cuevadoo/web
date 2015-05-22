<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="PerfilOtros.aspx.cs" Inherits="Identificado_PerfilOtros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <div>
        <h3 class="titulo"><asp:Label ID="LabelNombreUsuario" runat="server" Text="Nombre de usuario"></asp:Label></h3>
        <br />
        <asp:Image ID="UserImage1" runat="server" Height="198px" Width="250px" />
        <br />

        <asp:Table ID="Table4" runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Button ID="Button1" runat="server" Text="Añadir amigo" CssClass="boton" OnClick="Button1_Click"></asp:Button>
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:Button ID="Button2" runat="server" Text="Enviar mensaje" CssClass="boton"></asp:Button>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <!--enviar mensaje-->
            <div>
                <center>
                    <asp:Table ID="TableEstatica" runat="server" Width="100%" HorizontalAlign="Center">
                        <asp:TableRow HorizontalAlign="Center">
                            <asp:TableCell>
                                <asp:TextBox ID="TextBox1" style="max-width:600px;max-height:60px" Wrap="true" runat="server" Width="600px" Height="60px" CssClass="box" placeholder="Escribe el mensaje" TextMode="MultiLine" EnableViewState="True" EnableTheming="True"></asp:TextBox>
                            
</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow HorizontalAlign="Center">
                            <asp:TableCell>
                                <asp:Button ID="Button3" runat="server" Text="Enviar" cssclass="boton" OnClick="Button2_Click"></asp:Button>
                            
</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </center>
            </div>
        <!--enviar mensaje-->

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
    </asp:Table><br />
    <asp:Table runat="server" ID="Table3" Width="734px" Style="text-align:center">
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><p>Gustos Informáticos</p></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><asp:Label runat="server" Text="SO: "></asp:Label><asp:Label ID="LabelSO" runat="server" Text="No especificado" Backcolor="white" width="160px"></asp:Label>
</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
        <asp:TableCell runat="server">
            <asp:Label runat="server" Text="Marcas de hardware: "></asp:Label><asp:Label ID="LabelMHardware" runat="server" Text="No especificado" Backcolor="white" width="500px"></asp:Label>
</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
        <asp:TableCell runat="server">
            <asp:Label runat="server" Text="Lenguajes de programación: "></asp:Label><asp:Label ID="LabelLProgramacion" runat="server" Text="No especificado" Backcolor="white" width="440px"></asp:Label>
</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><p>Videojuegos</p></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><asp:Label runat="server" Text="Género de videojuegos: "></asp:Label><asp:Label ID="LabelGVideojuegos" runat="server" Text="No especificado" Backcolor="white" width="160px"></asp:Label>
</asp:TableCell>
</asp:TableRow>
<asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Videojuego favorito: "></asp:Label><asp:Label ID="LabelVideojuego" runat="server" Text="No especificado" Backcolor="white" width="510px"></asp:Label></asp:TableCell>
</asp:TableRow>
<asp:TableRow runat="server" HorizontalAlign="Center">
    <asp:TableCell runat="server">
        <asp:Label runat="server" Text="Consolas favoritas: "></asp:Label><asp:Label ID="LabelConsolas" runat="server" Text="No especificado" Backcolor="white" width="160px"></asp:Label>
    </asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label  runat="server" Text="Desarrolladora favorita: "></asp:Label><asp:Label ID="LabelDesarrolladora" runat="server" Text="No especificado" Backcolor="white" width="480px"></asp:Label></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center">
    <asp:TableCell runat="server"><p>Películas y Series</p></asp:TableCell>
</asp:TableRow>
        <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label  runat="server" Text="Género cinematográfico: "></asp:Label><asp:Label ID="LabelGCine" runat="server" Text="No especificado" Backcolor="white" width="470px"></asp:Label></asp:TableCell>
</asp:TableRow>
        <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Director de cine: "></asp:Label><asp:Label ID="LabelDirector" runat="server" Text="No especificado" Backcolor="white" width="536px"></asp:Label></asp:TableCell>
</asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"><asp:Label runat="server" Text="Década cinematográfica favorita: "></asp:Label><asp:Label ID="LabelDecadaC" runat="server" Text="No especificado" Backcolor="white" width="160px"></asp:Label></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Actor favorito: "></asp:Label><asp:Label ID="LabelActor" runat="server" Text="No especificado" Backcolor="white" width="555px"></asp:Label></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Pelicula favorita: "></asp:Label><asp:Label ID="LabelPelicula" runat="server" Text="No especificado" Backcolor="white" width="533px"></asp:Label></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Género de serie: "></asp:Label><asp:Label ID="LabelGSerie" runat="server" Text="No especificado" Backcolor="white" width="531px"></asp:Label></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Productor de series: "></asp:Label><asp:Label ID="LabelProductor" runat="server" Text="No especificado" Backcolor="white" width="504px"></asp:Label></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Serie favorita: "></asp:Label><asp:Label ID="LabelSerie" runat="server" Text="No especificado" Backcolor="white" width="554px"></asp:Label></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server">
    <asp:TableCell runat="server"><p>Música</p></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" Horizontal Align="Center">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Estilo de música: "></asp:Label><asp:Label ID="LabelEstilo" runat="server" Text="No especificado" Backcolor="white" width="160px"></asp:Label></asp:TextBox></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Grupo favorito: "></asp:Label><asp:Label ID="LabelGrupo" runat="server" Text="No especificado" Backcolor="white" width="546px"></asp:Label></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Artista favorito: "></asp:Label><asp:Label ID="LabelArtista" runat="server" Text="No especificado" Backcolor="white" width="545px"></asp:Label></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Década musical favorita: "></asp:Label><asp:Label ID="LabelDecadaM" runat="server" Text="No especificado" Backcolor="white" width="160px"></asp:Label></asp:TableCell>
</asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Justify">
    <asp:TableCell runat="server"><asp:Label runat="server" Text="Ultimos conciertos: "></asp:Label><asp:Label ID="LabelConciertos" runat="server" Text="No especificado" Backcolor="white" width="513px"></asp:Label></asp:TableCell>
</asp:TableRow>
</asp:Table></center>
<div>

   
    
     <!--publicaciones-->

</div>

            
            
            
    </div>
</asp:Content>
