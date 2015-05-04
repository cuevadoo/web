<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Configuracion.aspx.cs" Inherits="Identificado_Configuracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <div>
        <p>CONFIGURACIÓN DE PERFIL</p>
        <br />
        <p>Imagen de perfil</p>
        <asp:Image CssClass="Manita" onclick = "document.getElementById('light').style.display='block';document.getElementById('fade').style.display='block';" ID="ImageButton1" runat="server" Height="198px" Width="250px" />
        <p>Esta imagen será visible para todos los usuarios de Cuevadoo</p>
        <p>Haz click en ella para cambiar tu foto de perfil</p>
        <br />
        <div id="fade" class="FondoFoto" onclick = "document.getElementById('light').style.display='none';document.getElementById('fade').style.display='none'"></div>
            <div id="light" class="ContenidoFoto">
                <asp:Table OnLoad="Table2_Load" ID="Table2" runat="server"></asp:Table>
            </div>  
    </div></center>

        <div>



<!--Galeria de fotos-->



        </div>

        <div>
            <center>Datos personales</center>
            <br />
            <p>La siguiente información no es obligatoria pero permite que tus amigos sepan donde vives y qué es lo que te gusta. Además facilitará la busqueda al resto de usuarios mediante el Buscador Avanzado de Cuevadoo©.</p>
            <center>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="box" placeholder="País de residencia" Width="200px"></asp:TextBox></asp:TableCell>
                    <asp:TableCell runat="server" >
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="box" placeholder="Comunidad autónoma o Estado" Width="200px"  ></asp:TextBox></asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="box" placeholder="Localidad" Width="200px"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
            </asp:Table><br />
    <asp:Table runat="server" ID="Table2" Width="734px">
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

