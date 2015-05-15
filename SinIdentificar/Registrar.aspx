<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registrar.aspx.cs" Inherits="SinIdentificar_Registrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Registrar</title>
            <!--Conjunto de funciones para mostrar un div central y oscurecer el resto de la pagina. En nuestro caso es para que aparezcan
    los terminos y condiciones-->  
    <script type="text/javascript">     
        function aparecer() {
            document.body.style.overflow = 'hidden';
            document.getElementById('light').style.display = "block";
            document.getElementById('fade').style.display = "block";
        }
        function desaparecer() {
            document.body.style.overflow = 'auto';
            document.getElementById('light').style.display = "none";
            document.getElementById('fade').style.display = "none";
        }
        function camBoton(){
            var aux = document.getElementById("ContentPlaceHolder1_Button1");
            if (aux.disabled == "") {
                aux.disabled = "disabled"
            } else {
                aux.disabled = "";
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">  
    <center>
        <div>
            <h3 class="titulo">BIENVENIDOS A CUEVADOO</h3>
        </div>
        <!--En el siguiente div vamos a englobar en una tabla todos los campos relacionados con el registro. Ya sea el nombre, apellidos,
            contraseña, etc. Destacariamos que todos los campos tienen que estar rellenados, y para que el boton de registrar se active
            tendremos que marcar el boton de Aceptar los terminos. -->
        <div>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" Width="100%" CssClass="box" placeholder="Nombre"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator1" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox2" runat="server" Width="100%" CssClass="box" placeholder="Primer Apellido"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator2" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox3" runat="server" Width="100%" CssClass="box" placeholder="Segundo Apellido"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator3" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" TextAlign="center">
                        <center>
                            <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList1" runat="server" >
                                <asp:ListItem Text="Hombre" Value="Hombre"></asp:ListItem><asp:ListItem Text="Mujer" Value="Mujer"></asp:ListItem>
                            </asp:RadioButtonList>
                        </center>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator4" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="RadioButtonList1"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox5" runat="server" Width="100%" CssClass="box" placeholder="Email"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator5" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!-- Comprobamos que el email sea valido, sino mostrará el mensaje de error-->
                        <center>
                            <asp:RegularExpressionValidator CssClass="warning" ID="RegularExpressionValidator1" runat="server" ErrorMessage="El email es incorrecto" ControlToValidate="TextBox5" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </center>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!--Para la decha de nacimiento tenemos 3 campos por rellenar, el dia, el mes y el año. Para estos tres campos
                            hemos comprobado tambien que todos los datos sean correctos. En caso de error, mostrará el mensaje de
                            Fecha no valida -->
                        <center>Fecha de Nacimiento:</center>
                        <asp:Table ID="Table2" runat="server">
                            <asp:TableRow ID="TableRow1" runat="server">
                                <asp:TableCell ID="TableCell1" runat="server">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="TextBox6" runat="server" Width="40px" CssClass="box" placeholder="dd"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator6" runat="server" ErrorMessage="&nbsp;*" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
                                </asp:TableCell>
                                <asp:TableCell ID="TableCell2" runat="server">
                                    <asp:TextBox ID="TextBox8" runat="server" Width="40px" CssClass="box" placeholder="mm"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator9" runat="server" ErrorMessage="&nbsp;*" ControlToValidate="TextBox8"></asp:RequiredFieldValidator>
                                </asp:TableCell>
                                <asp:TableCell ID="TableCell3" runat="server">
                                    <asp:TextBox ID="TextBox9" runat="server" Width="80px" CssClass="box" placeholder="yyyy"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator10" runat="server" ErrorMessage="&nbsp;*" ControlToValidate="TextBox9"></asp:RequiredFieldValidator>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:CustomValidator CssClass="warning" ID="CustomValidator2" runat="server" ErrorMessage="Fecha no valida" ControlToValidate="TextBox9" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox7" runat="server" TextMode="Password" Width="100%" CssClass="box" placeholder="Contraseña"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator7" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox7"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox4"  runat="server" TextMode="Password" Width="100%" CssClass="box" placeholder="Confirmar Contraseña"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator8" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!--Aqui comparamos que las dos contraseñas introducidas (la del campo de Contraseña y Confirmar contraseña) sean 
                            iguales. En caso contrario se mostrará el mensaje de error.-->
                        <center>
                            <asp:CompareValidator CssClass="warning" ControlToValidate="TextBox4" ControlToCompare="TextBox7" ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas no son iguales"></asp:CompareValidator>
                        </center>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!--En este caso se compara que el email no se repita. Para que no te deje la pagina crearte dos o mas cuentas
                            con un solo email -->
                        <center><asp:CustomValidator ControlToValidate="TextBox5" CssClass="warning" ID="CustomValidator1" runat="server" ErrorMessage="Ya existe una cuenta con este email" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                        </center>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto los " onclick="camBoton()"></asp:CheckBox>
            
            <!--En esta parte es donde se mostrarán los términos y condiciones de nuestra web. Utilizando las funciones que anteriormente
                hemos visto en la parte superior-->
            <div id="fade" class="overlay" onclick = "desaparecer()"></div>
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
                        <p class="center"><a href = "javascript:void(0)" onclick = "desaparecer()"><img src="../Imagenes/cerrar.jpg" width="30px"/></a></p>
                    </div>
                </div>
            <a href = "javascript:void(0)" onclick = "aparecer()">términos y condiciones.</a>               

            <br/><br/>
            <asp:Button ID="Button1" runat="server" Text="Registrar" cssclass="boton" OnClick="Button1_Click" Enabled="False" CausesValidation="False"></asp:Button><br />
            <asp:Label ID="Label1" runat="server" Text="No se ha podido crear la cuenta, intentelo mas tarde.<br />Si esto se repite envianos tu problema en ayuda." Visible="false"></asp:Label>
        </div>
    </center>
</asp:Content>

