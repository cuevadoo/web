<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PerfilOtros.aspx.cs" Inherits="SinIdentificar_PerfilOtros" %>

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

