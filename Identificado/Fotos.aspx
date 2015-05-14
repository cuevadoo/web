<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Fotos.aspx.cs" Inherits="Identificado_Fotos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="~/estilo.css" media="screen" />
    <link href="~/Imagenes/logoRecortado.png" type="image/x-icon" rel="shortcut icon" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cuevadoo</title>
</head>
<body>
    <center>
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <div id="Flotante">
                <center>

                    <!--Tabla con el menu basico-->

                    <asp:Table ID="Table1" runat="server" style="margin-bottom: 0px">
                        <asp:TableRow ID="TableRow1" runat="server">
                            <asp:TableCell ID="TableCell1" runat="server">
                                <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" ImageUrl="~/Imagenes/logoRecortado.png" Width="50px" OnClick="ImageButton2_Click" CausesValidation="False" TabIndex="99" />
                            </asp:TableCell>
                            <asp:TableCell ID="TableCell2" runat="server">
                                <asp:Menu ID="Menu1" CssClass="Menu" runat="server" StaticSubMenuIndent="16px" Orientation="Horizontal" RenderingMode="Default" DisappearAfter="100">
                                    <Items>
                                        <asp:MenuItem Text="[Usuario]" Value="Nuevo elemento" NavigateUrl="~/Identificado/Perfil.aspx"></asp:MenuItem>
                                        <asp:MenuItem Text="SubirFoto" Value="Nuevo Elemento" NavigateUrl="~/Identificado/Fotos.aspx"></asp:MenuItem>
                                        <asp:MenuItem Text="Mensajes" Value="Nuevo Elemento" NavigateUrl="~/Identificado/Mensajes.aspx"></asp:MenuItem>
                                        <asp:MenuItem Text="Buscador avanzado" Value="Nuevo Elemento" NavigateUrl="~/Identificado/BuscadorAvanzado.aspx"></asp:MenuItem>                                  
                                    </Items>
                                </asp:Menu>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>

                    <!--Tabla con el menu basico-->
                    <!--Imagen de herramienta y menu desplegable-->

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

                    <!--Imagen de herramienta y menu desplegable-->
                </center>
            </div>
            <div id="CuerpoI">
                <br /><br /><br />
                <div id="ContenidoI">

                    <!--Botones para subir fotos-->

                    <div style="background-color:#d1cdcd;width:450px;height:35px">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:Button ID="Button1" CssClass="botonBuscador" runat="server" Text="Subir foto" OnClick="Button1_Click" />
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </div>

                    <!--Botones para subir fotos-->
                    <!--Galeria de fotos dinamica-->

                    <br /><br />
                    <center>
                        <asp:Label ID="Label2" runat="server" Text="Galeria de fotos"></asp:Label>
                        <asp:Table ID="Table3" runat="server" Width="800px"  OnLoad="Table3_Load"></asp:Table>
                    </center>
                    <!--Galeria de fotos dinamica-->

                </div>
                <div>
                    <!--Pie de pagina-->
                    <asp:Table ID="Table2" runat="server" CssClass="center" Width="900px">
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="3">
                                <hr />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell VALIGN=top>
                                <b class="tfooter">INFORMACIÓN</b><br />
                                <a href="/SinIdentificar/Registrar.aspx" class="footer">Registrate</a><br /><a href="/SinIdentificar/Buscador.aspx" class="footer">Busca gente</a>
                            </asp:TableCell>
                            <asp:TableCell VALIGN=top>
                                <b class="tfooter">SOBRE NOSOTROS</b><br />
                                <a href="/Default.aspx" class="footer">¿Quien somos?</a><br /><a href="/SinIdentificar/Ayuda.aspx" class="footer">Ayuda</a><br />
                                
                                <!--Vetana de terminos y condiciones-->

                                <div id="fade" class="overlay" onclick = "document.getElementById('light').style.display='none';document.getElementById('fade').style.display='none'"></div>
                                <div id="light" class="modal">
                                    <div class="justify" id="lpeque">
                                    <h3><u>Declaración de derechos y responsabilidades</u></h3>
                                        <p>Esta Declaración de derechos y responsabilidades (en lo sucesivo, "Declaración", "Condiciones" o "DDR") tiene su origen en los Principios de Cuevadoo y contiene las condiciones de servicio que rigen nuestra relación con los usuarios y con todos aquellos que interactúan con Cuevadoo, así como con las marcas, los productos y los servicios de Cuevadoo, que se denominan "servicios de Cuevadoo" o "servicios". Al usar los ﻿﻿servicios de Cuevadoo o al acceder a estos, muestras tu conformidad con esta declaración, que se actualiza periódicamente según se estipula en la sección 13 que figura más adelante. Al final de este documento también encontrarás otros recursos que te ayudarán a comprender cómo funciona Cuevadoo.</p>
                                        <p>Puesto que Cuevadoo ofrece una amplia gama de servicios, es posible que te pidamos que leas y aceptes condiciones complementarias aplicables a tu interacción con una aplicación, un producto o un servicio determinados. En caso de que esas condiciones complementarias entren en conflicto con esta DDR, las condiciones complementarias asociadas con la aplicación, el producto o el servicio prevalecerán en lo referente al uso de tales aplicaciones, productos o servicios en caso de conflicto.</p>
                                    <h3><u>Privacidad</u></h3>
                                        <p>Tu privacidad es muy importante para nosotros. Hemos diseñado nuestra Política de datos para ayudarte a comprender cómo puedes utilizar Cuevadoo para compartir contenido con otras personas y cómo recopilamos y podemos utilizar tu contenido e información. Te animamos a que leas nuestra Política de datos y a que la utilices con el fin de poder tomar decisiones fundamentadas.</p>
     
                                    <h3><u>Compartir el contenido y la información</u></h3>
                                        <p>Eres el propietario de todo el contenido y la información que publicas en Cuevadoo, y puedes controlar cómo se comparte a través de la configuración de la privacidad y de las aplicaciones. Además:</p>
                                        <ul>
                                        <li type="circle">Con relación al contenido protegido por derechos de propiedad intelectual, como fotografías y vídeos (en lo sucesivo, "contenido de PI"), nos concedes específicamente el siguiente permiso, de acuerdo con la configuración de la privacidad y las aplicaciones: nos concedes una licencia no exclusiva, transferible, con derechos de sublicencia, libre de derechos de autor, aplicable globalmente, para utilizar cualquier contenido de PI que publiques en Cuevadoo o en conexión con Cuevadoo (en adelante, "licencia de PI"). Esta licencia de PI finaliza cuando eliminas tu contenido de PI o tu cuenta, salvo si el contenido se ha compartido con terceros y estos no lo han eliminado.</li>
                                        <li type="circle">Cuando eliminas contenido de PI, este se borra de forma similar a cuando vacías la papelera o papelera de reciclaje de tu equipo. No obstante, entiendes que es posible que el contenido eliminado permanezca en copias de seguridad durante un plazo de tiempo razonable (si bien no estará disponible para terceros).</li>
                                        <li type="circle">Cuando utilizas una aplicación, esta puede solicitarte permiso para acceder a tu contenido e información y al contenido e información que otros han compartido contigo. Exigimos que las aplicaciones respeten tu privacidad; tu acuerdo con esa aplicación controlará el modo en el que la aplicación use, almacene y transfiera dicho contenido e información. (Para obtener más información sobre la plataforma, incluido cómo controlar la información que otras personas pueden compartir con las aplicaciones, lee nuestra Política de datos y la página de la plataforma).</li>
                                        <li type="circle">Cuando publicas contenido o información con la configuración "Público", significa que permites que todos, incluidas las personas que son ajenas a Cuevadoo, accedan y usen dicha información y la asocien a ti (es decir, tu nombre y foto del perfil).</li>
                                        <li type="circle">Siempre valoramos tus comentarios o sugerencias acerca de Cuevadoo, pero debes entender que podríamos utilizarlos sin obligación de compensarte por ello (del mismo modo que tú no tienes obligación de ofrecerlos).</li>
                                        </ul>
                                        <p class="center"><a href = "javascript:void(0)" onclick = "document.getElementById('light').style.display='none';document.getElementById('fade').style.display='none'"><img src="../Imagenes/cerrar.jpg"/width="30px"></a></p>
                                        </div>
                                    </div>
                                <a class="footer" href = "javascript:void(0)" onclick = "document.getElementById('light').style.display='block';document.getElementById('fade').style.display='block';">Términos y condiciones.</a>   
                                
                                <!--Vetana de terminos y condiciones-->

                            </asp:TableCell>
                            <asp:TableCell>
                                <b class="tfooter">CONTACTO</b><br />
                                <a href="/SinIdentificar/Ayuda.aspx" class="footer">Rellenar formulario</a><br /><a href="tel:902253651" class="footer">902 253 651</a><br /><a href="mailto:cuevadoo@help.org" class="footer">cuevadoo@help.org</a>
                            </asp:TableCell>
                         </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="3" CssClass="left">
                                <hr />
                                <b>Copyright © 2015 </b><p id="facebook">f</p>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>

                    <!--Pie de pagina-->
            
                </div>
            </div>
        </form>
    </center>
</body>
</html>
