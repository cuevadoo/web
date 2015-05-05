<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Configuracion.aspx.cs" Inherits="Identificado_Configuracion" %>

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
        <p>CONFIGURACIÓN DE PERFIL</p>
        <br />
        <p>Imagen de perfil</p>
        <asp:Image CssClass="Manita" onclick = "aparecer()" ID="ImageButton1" runat="server" Height="198px" Width="250px" />
        <p>Esta imagen será visible para todos los usuarios de Cuevadoo</p>
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
    </div></center>

        <div>



<!--Galeria de fotos-->



        </div>

        <div>
            <center>Datos personales</center>
            <br />
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
    <asp:Table runat="server" ID="Table3" Width="734px">
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><p>Gustos Informáticos</p></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center">
        <asp:TableCell runat="server"><asp:RadioButtonList ID="RadioButtonList1" RepeatDirection="Horizontal" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
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
        <asp:TableCell runat="server"><asp:TextBox runat="server" CssClass="box" placeholder="Género favorito con una mayúscula.Por ejemplo: Acción" Width="50%"></asp:TextBox>
</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server"></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server"></asp:TableCell>
    </asp:TableRow>
                </asp:Table></center>


            

            
        </div>
    

</asp:Content>

