<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="PerfilOtros.aspx.cs" Inherits="Identificado_PerfilOtros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <script type="text/javascript">
        function TamVentana() {
            var Tamanyo = [0, 0];
            if (typeof window.innerWidth != 'undefined') {
                Tamanyo = [
                    window.innerWidth,
                    window.innerHeight
                ];
            }
            else if (typeof document.documentElement != 'undefined'
                && typeof document.documentElement.clientWidth !=
                'undefined' && document.documentElement.clientWidth != 0) {
                Tamanyo = [
                       document.documentElement.clientWidth,
                       document.documentElement.clientHeight
                ];
            }
            else {
                Tamanyo = [
                    document.getElementsByTagName('body')[0].clientWidth,
                    document.getElementsByTagName('body')[0].clientHeight
                ];
            }
            return Tamanyo;
        }
        window.onload = function () {
            var Tam = TamVentana();
            document.getElementById("ContentPlaceHolder1_AnchoVentana").value = "" + Tam[0];
            document.getElementById("ContentPlaceHolder1_AltoVentana").value = "" + Tam[1];
        }
        window.onresize = function () {
            var Tam = TamVentana();
            document.getElementById("ContentPlaceHolder1_AnchoVentana").value = "" + Tam[0];
            document.getElementById("ContentPlaceHolder1_AltoVentana").value = "" + Tam[1];
        };
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
            document.getElementById('ContentPlaceHolder1_Foto').style.display = 'none';
            document.getElementById('ContentPlaceHolder1_fondoFoto').style.display = 'none';
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
        var aux = false;
        var posX = 0;
        var posY = 0;
        var cuadrado;
        function clickdown(event) {
            if (aux) {
                aux = false;
            } else {
                cuadrado = document.getElementById("ContentPlaceHolder1_recuadro");
                cuadrado.style.display = "block";
                posX = event.clientX;
                posY = event.clientY;
                cuadrado.style.height = "0px";
                cuadrado.style.width = "0px";
                cuadrado.style.top = posY + "px";
                cuadrado.style.left = posX + "px";
                aux = true;
            }
        }
        function mover(event) {
            if (aux) {
                var t1 = document.getElementById("ContentPlaceHolder1_Top");
                var t2 = document.getElementById("ContentPlaceHolder1_Left");
                var t3 = document.getElementById("ContentPlaceHolder1_Alto");
                var t4 = document.getElementById("ContentPlaceHolder1_Ancho");
                var X = event.clientX;
                var Y = event.clientY;
                if (parseInt(X) > parseInt(posX) && parseInt(Y) > parseInt(posY)) {
                    t1.value = "" + posY;
                    t2.value = posX;
                    t3.value = (Y - posY);
                    t4.value = (X - posX);
                    cuadrado.style.top = posY + "px";
                    cuadrado.style.left = posX + "px";
                    cuadrado.style.height = (Y - posY) + "px";
                    cuadrado.style.width = (X - posX) + "px";
                }
                if (parseInt(X) > parseInt(posX) && parseInt(Y) <= parseInt(posY)) {
                    t1.value = Y;
                    t2.value = posX;
                    t3.value = (posY - Y);
                    t4.value = (X - posX);
                    cuadrado.style.top = Y + "px";
                    cuadrado.style.left = posX + "px";
                    cuadrado.style.height = (posY - Y) + "px";
                    cuadrado.style.width = (X - posX) + "px";
                }
                if (parseInt(X) <= parseInt(posX) && parseInt(Y) <= parseInt(posY)) {
                    t1.value = Y;
                    t2.value = X;
                    t3.value = (posY - Y);
                    t4.value = (posX - X);
                    cuadrado.style.top = Y + "px";
                    cuadrado.style.left = X + "px";
                    cuadrado.style.height = (posY - Y) + "px";
                    cuadrado.style.width = (posX - X) + "px";
                }
                if (parseInt(X) <= parseInt(posX) && parseInt(Y) > parseInt(posY)) {
                    t1.value = posY;
                    t2.value = X;
                    t3.value = (Y - posY);
                    t4.value = (posX - X);
                    cuadrado.style.top = posY + "px";
                    cuadrado.style.left = X + "px";
                    cuadrado.style.height = (Y - posY) + "px";
                    cuadrado.style.width = (posX - X) + "px";
                }
            }
        }
        function clickup() {
            aux = false;
        }
    </script>
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
                <asp:TableCell runat="server"><asp:Button ID="Button1" runat="server" Text="Añadir amigo" CssClass="boton"></asp:Button></asp:TableCell>
                <asp:TableCell runat="server"><asp:Button ID="Button2" runat="server" Text="Enviar mensaje" CssClass="boton"></asp:Button></asp:TableCell>
            </asp:TableRow>
        </asp:Table>


        <!--Imagenes en ventana desplegable-->
        <div id="fade" class="FondoFoto" onclick ="desaparecer()"></div>
        <div id="izquierda" onmouseout="vaciar()" onmouseover="desplazarTiempo(-2,5)" class="BotonIzquierda"><</div>
        <div id="derecha" onmouseout="vaciar()" onmouseover="desplazarTiempo(2,5)" class="BotonDerecha">></div>
        <div id="light1" class="ContenidoFotoScroll">
            <div id="light2" class="ContenidoFoto">
                <asp:Table OnLoad="Table1_Load" ID="Table1" runat="server"></asp:Table>
            </div>
        </div>
        <!--Imagenes en ventana desplegable-->
        <!--Editor de imagen-->
    <div runat="server" id="fondoFoto" class="ContenidoFoto2"></div>
    <div runat="server" id="Foto" class="Foto" onmousedown="clickdown(event)" onmouseup="clickup()" onmousemove="mover(event)">
        <div style="display:none">
            <asp:TextBox ID="AnchoVentana" runat="server"></asp:TextBox>
            <asp:TextBox ID="AltoVentana" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="Top" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="Left" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="Alto" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="Ancho" runat="server"></asp:TextBox><br />
        </div>
        <asp:Image class="Foto2" ID="Image1" runat="server"></asp:Image>
        <div runat="server" id="recuadro" style="background: rgba(70,130,180,0.2);display:none;position:fixed;border: 1px solid #a104f8;height:0px;width:0px;z-index:1005;"></div>
            
    </div>
    <div runat="server" id="botones" class="BotonesFoto">
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Imagenes/tuerca.png" OnClick="ImageButton2_Click"></asp:ImageButton>
        <asp:ImageButton ID="ImageButton3" runat="server"></asp:ImageButton>
    </div>
       
        
         <!--Galeria-->


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
