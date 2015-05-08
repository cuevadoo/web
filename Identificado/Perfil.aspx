<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Perfil.aspx.cs" Inherits="Identificado_Perfil" %>

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
        <h3 class="titulo">CONFIGURACIÓN DE PERFIL</h3>
        <br />
        <p style="text-decoration: underline">Imagen de perfil</p>
        <asp:Image CssClass="Manita" onclick = "aparecer()" ID="ImageButton1" runat="server" Height="198px" Width="250px" />
        <p>Esta imagen será visible por todos los usuarios de Cuevadoo</p>
        <p>Haz click en ella para cambiar tu foto de perfil</p>
        <asp:Label ID="Label2" runat="server" Text="mierda"></asp:Label>
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
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Tu desarrolladora de juegos favorito.Por ejemplo: Blizzard" Width="55%"></asp:TextBox></asp:TableCell>
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

