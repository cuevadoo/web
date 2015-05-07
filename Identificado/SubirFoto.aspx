<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SubirFoto.aspx.cs" Inherits="Identificado_SubirFoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="~/estilo.css" media="screen" />
    <link href="~/Imagenes/logoRecortado.png" type="image/x-icon" rel="shortcut icon" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cuevadoo</title>
    <script type="text/javascript">
        var aux = false;
        var posX = 0;
        var posY = 0;
        var cuadrado;
        function clickdown(event) {
            if (aux) {
                aux = false;
            } else {
                cuadrado=document.getElementById("recuadro");
                cuadrado.style.display = "block";
                posX = event.clientX;
                posY = event.clientY;
                cuadrado.style.height = "0px";
                cuadrado.style.width = "0px";
                cuadrado.style.top = posY+"px";
                cuadrado.style.left = posX+"px";
                aux = true;
            }
        }
        function mover(event) {
            if (aux) {
                var t1 = document.getElementById("TextBox1");
                var t2 = document.getElementById("TextBox2");
                var t3 = document.getElementById("TextBox3");
                var t4 = document.getElementById("TextBox4");
                var X = event.clientX;
                var Y = event.clientY;
                if (parseInt(X) > parseInt(posX) && parseInt(Y) > parseInt(posY)) {
                    t1.value = posY;
                    t2.value = posX;
                    t3.value = (Y - posY);
                    t4.value = (X - posX);
                    cuadrado.style.top = posY + "px";
                    cuadrado.style.left = posX + "px";
                    cuadrado.style.height = (Y - posY)+"px";
                    cuadrado.style.width = (X - posX)+"px";
                }
                if (parseInt(X) > parseInt(posX) && parseInt(Y) <= parseInt(posY)) {
                    cuadrado.style.top = Y + "px";
                    cuadrado.style.left = posX + "px";
                    cuadrado.style.height = (posY - Y) + "px";
                    cuadrado.style.width = (X - posX) + "px";
                }
                if (parseInt(X) <= parseInt(posX) && parseInt(Y) <= parseInt(posY)) {
                    cuadrado.style.top = Y + "px";
                    cuadrado.style.left = X + "px";
                    cuadrado.style.height = (posY - Y) + "px";
                    cuadrado.style.width = (posX - X) + "px";
                }
                if (parseInt(X) <= parseInt(posX) && parseInt(Y) > parseInt(posY)) {
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
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="Flotante">
            <center>
                <asp:Table ID="Table1" runat="server" style="margin-bottom: 0px">
                    <asp:TableRow ID="TableRow1" runat="server">
                        <asp:TableCell ID="TableCell1" runat="server">
                            <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" ImageUrl="~/Imagenes/logoRecortado.png" Width="50px" OnClick="ImageButton2_Click" CausesValidation="False" TabIndex="99" />
                        </asp:TableCell>
                        <asp:TableCell ID="TableCell2" runat="server">
                            <asp:Menu ID="Menu1" CssClass="Menu" runat="server" StaticSubMenuIndent="16px" Orientation="Horizontal" RenderingMode="Default" DisappearAfter="100">
                                <Items>
                                    <asp:MenuItem Text="[Usuario]" Value="Nuevo elemento" NavigateUrl="~/Identificado/Perfil.aspx"></asp:MenuItem>
                                    <asp:MenuItem Text="SubirFoto" Value="Nuevo Elemento" NavigateUrl="~/Identificado/SubirFoto.aspx"></asp:MenuItem>
                                    <asp:MenuItem Text="Mensajes" Value="Nuevo Elemento" NavigateUrl="~/Identificado/Mensajes.aspx"></asp:MenuItem>
                                    <asp:MenuItem Text="Buscador avanzado" Value="Nuevo Elemento" NavigateUrl="~/Identificado/BuscadorAvanzado.aspx"></asp:MenuItem>                                  
                                </Items>
                            </asp:Menu>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <div class="Herramienta">
                    <asp:Image ID="Image1" CssClass="Manita" runat="server" ImageUrl="~/Imagenes/tuerca.png" onclick="document.getElementById('desplegable').style.display = 'block';document.getElementById('todo').style.display = 'block';"></asp:Image>
                </div>
                <div id="desplegable" class="Menu">
                    <ul>
                        <li><a href="Configuracion.aspx">Configuracion</a></li>
                        <li><a href="CerrarSesion.aspx">CerrarSesion</a></li>
                    </ul>
                </div>
                <div id="todo" class="FondoBuscador" onmouseover="document.getElementById('desplegable').style.display = 'none';document.getElementById('todo').style.display = 'none';"></div>
            </center>
        </div>
        <div id="CuerpoI">
            <div id="ContenidoI">
                <br /><br /><br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="Button1" runat="server" Text="Subir foto" OnClick="Button1_Click" />
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <br />
                <div class="Manita" onmousedown="clickdown(event)" onmouseup="clickup()" onmousemove="mover(event)" style="height:156px;width:627px;position:absolute;">
                    <div runat="server" id="recuadro" style="display:none;position:fixed;border: 1px solid #000;height:0px;width:0px"></div>
                </div>
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Imagenes/logo.png" /><br />
                <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
                <asp:TextBox ID="TextBox1" runat="server" Text="Hola"></asp:TextBox><br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
                <asp:Image ID="Image3" runat="server" ImageUrl="~/Imagenes/logoR.png"/>
                <br />
            </div>
            <div>
                <footer><b>Copyright © 2015 </b><p id="facebook">f</p></footer>
            </div>
        </div>
    </form>
</body>
</html>
