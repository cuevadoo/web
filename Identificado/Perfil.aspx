﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Perfil.aspx.cs" Inherits="Identificado_Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        function aparecer() {
            document.body.style.overflow = 'hidden';
            document.getElementById('derecha').style.display = 'block';
            document.getElementById('izquierda').style.display = 'block';
            document.getElementById('light1').style.display = 'block';
            document.getElementById('light2').style.display = 'block';
            document.getElementById('fade').style.display = 'block';
        }
        function desaparecer() {
            document.body.style.overflow = 'auto';
            document.getElementById('ContentPlaceHolder1_fondoFoto').style.display = 'none';
            document.getElementById('ContentPlaceHolder1_foto').style.display = 'none';
            document.getElementById('derecha').style.display = 'none';
            document.getElementById('izquierda').style.display = 'none';
            document.getElementById('light1').style.display = 'none';
            document.getElementById('light2').style.display = 'none';
            document.getElementById('fade').style.display = 'none';
        }
        var ID;
        function desplazar(cantidad) {
            var aux = document.getElementById('light2');
            aux.scrollLeft += cantidad;
        }
        function desplazarTiempo(cantidad, tiempo) {
            ID = setInterval(desplazar, tiempo, cantidad);
        }
        function vaciar() {
            clearInterval(ID);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <div>
        <h3 class="titulo">CONFIGURACIÓN DE PERFIL</h3>
        <br />
        <p style="text-decoration: underline">Imagen de perfil</p>
        <asp:Image CssClass="Manita" onclick = "aparecer()" ID="ImageButton1" runat="server" Height="198px" Width="250px" />
        <p>Esta imagen será visible por todos los usuarios de Cuevadoo</p>
        <p>Haz click en ella para cambiar tu foto de perfil</p>
        <br />
        <!--Imagenes en ventana desplegable-->
        <div id="fade" class="FondoFoto" onclick ="desaparecer()"></div>
        <div id="izquierda" onmouseout="vaciar()" onmouseover="desplazarTiempo(-2,5)" class="BotonIzquierda"><</div>
        <div id="derecha" onmouseout="vaciar()" onmouseover="desplazarTiempo(2,5)" class="BotonDerecha">></div>
        <div id="light1" class="ContenidoFotoScroll">
            <div id="light2" class="ContenidoFoto">
                <asp:Table OnLoad="Table1_Load" ID="Table1" runat="server" Width="200%"></asp:Table>
            </div>
        </div>
        <!--Imagenes en ventana desplegable-->
        <!--Editor de imagen-->
        <div runat="server" id="fondoFoto" class="ContenidoFoto2">
            <asp:ImageMap CssClass="MenosOpaco" ID="ImageMap1" runat="server" OnClick="ImageMap1_Click" ImageUrl="~/Imagenes/logo bajo.png" HotSpotMode="PostBack"></asp:ImageMap>
        </div>
        <!--Editor de imagen-->
    </div></center>

        <div>



<!--Galeria de fotos-->



        </div>

        <div>
            <center><p style="text-decoration-line:underline">Datos personales</p></center>
            <p>La siguiente información no es obligatoria pero permite que tus amigos sepan donde vives y qué es lo que te gusta. Además facilitará la busqueda al resto de usuarios mediante el Buscador Avanzado de Cuevadoo©.</p>
            <center>
            <asp:Table ID="Table2" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="box" placeholder="País de residencia" Width="200px"></asp:TextBox></asp:TableCell>
                    <asp:TableCell runat="server" >
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="box" placeholder="Comunidad autónoma o Estado" Width="200px"  ></asp:TextBox></asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="box" placeholder="Localidad" Width="200px"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
            </asp:Table><br />
    <asp:Table runat="server" ID="Table3" Width="734px" Style="text-align:center">
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><p>Gustos Informáticos</p></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><asp:RadioButtonList ID="RadioButtonList1" RepeatDirection="Horizontal" runat="server">
                <asp:ListItem>MAC</asp:ListItem>
                <asp:ListItem>Windows</asp:ListItem>
                <asp:ListItem>Linux</asp:ListItem>
            </asp:RadioButtonList>
</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Marcas de hardware favoritas. Separadas por comas y en mayúscula.Por ejemplo: HP,INTEL,NVIDIA" Width="100%"></asp:TextBox>
</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Lenguajes de programación favoritos. Separados por comas y en mayúscula.Por ejemplo:JAVA,C++,PYTHON" Width="100%"></asp:TextBox>
</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><p>Videojuegos</p></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Género favorito con una mayúscula.Por ejemplo: Acción" Width="55%"></asp:TextBox>
</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu videojuego favorito.Por ejemplo: The Legend of Zelda" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><asp:RadioButtonList ID="RadioButtonList2" RepeatDirection="Horizontal" runat="server">
                <asp:ListItem>Consolas SONY</asp:ListItem>
                <asp:ListItem>Consolas Microsoft</asp:ListItem>
                <asp:ListItem>Consolas Nintendo</asp:ListItem>
            </asp:RadioButtonList></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu desarrollador de juegos favorito.Por ejemplo: Blizzard" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><p>Películas y Series</p></asp:TableCell>
    </asp:TableRow>
         <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu género cinematográfico favorito.Por ejemplo: Comedia" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
         <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu director favorito.Por ejemplo: Tarantino" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
         <asp:TableRow runat="server">
             <asp:TableCell runat="server"><asp:Label runat="server" Text="Década cinematográfica favorita "></asp:Label><asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="NULL">--</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>60</asp:ListItem>
                <asp:ListItem>70</asp:ListItem>
                <asp:ListItem>80</asp:ListItem>
                <asp:ListItem>90</asp:ListItem>
                <asp:ListItem>00</asp:ListItem>
            </asp:DropDownList></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu actor favorito.Por ejemplo: Johnny Depp" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu película favorita.Por ejemplo: Pupl Fiction" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu género de serie favorito.Por ejemplo: Acción" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu productor de series favorito.Por ejemplo: Frank Darabont" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu serie favorita.Por ejemplo: The Office" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><p>Música</p></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu estilo musical favorito.Por ejemplo: Rock" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu grupo favorito.Por ejemplo: The Queen" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu artista favorito.Por ejemplo: Michael Jackson" Width="55%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:Label runat="server" Text="Década musical favorita "></asp:Label><asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="NULL">--</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>60</asp:ListItem>
                <asp:ListItem>70</asp:ListItem>
                <asp:ListItem>80</asp:ListItem>
                <asp:ListItem>90</asp:ListItem>
                <asp:ListItem>00</asp:ListItem>
            </asp:DropDownList></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Últimos conciertos a los que has asistido. Separados por comas.Por ejemplo: Justin Bieber,Abraham Mateo" Width="100%"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><br /><p>*Los datos que introduzcas aquí serán publicos y visibles por todos los usuarios de Cuevadoo. Pulsando el botón "Guardar" estás de acuerdo con lo anterior citado y aceptas nuestra política.  </p></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server"><br /><asp:Button ID="Button1" runat="server" Text="Guardar" cssclass="boton"></asp:Button></asp:TableCell>
    </asp:TableRow>
        
                </asp:Table></center>

            
            
            
        </div>
    

</asp:Content>

