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
        function ci(photo,textbox) {
            var img = document.getElementById(photo);
            img.src = "";
            img.src = "foto01.jpg";
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
                            <asp:Menu ID="Menu1" runat="server" StaticSubMenuIndent="16px" Orientation="Horizontal" RenderingMode="Default" DisappearAfter="100">
                                <Items>
                                    <asp:MenuItem Text="[Usuario]" Value="Nuevo elemento" NavigateUrl="~/Identificado/Configuracion.aspx"></asp:MenuItem>
                                    <asp:MenuItem Text="SubirFoto" Value="Nuevo Elemento" NavigateUrl="~/Identificado/SubirFoto.aspx"></asp:MenuItem>
                                </Items>
                            </asp:Menu>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </center>
        </div>
        <div id="CuerpoI">
            <div id="ContenidoI">
                <br /><br /><br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="Button1" runat="server" Text="Subir foto" OnClick="Button1_Click" />
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            </div>
            <div>
                <footer><b>Copyright © 2015 </b><p id="facebook">f</p></footer>
            </div>
        </div>
    </form>
</body>
</html>
