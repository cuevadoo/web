<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Table class="justify" ID="Table1" border runat="server" Height="130px" Width="251px">
        <asp:TableRow runat="server">
            <asp:TableCell columnSpan="3" runat="server">
                <h3 class="titulo">BIENVENIDOS A CUEVADOO</h3>
                <p>  Cuevadoo es una red social creada para El equipo, dirigido por el biólogo Rodolfo Dirzo ha analizado las consecuencias para el ecosistema si desaparecieran 73 especies de grandes hervíboros. La mayor parte de ellos son propios de África, pero también hay animales de ecosistemas en el sudeste asiático, Latinoamérica, Norteamérica o Europa.

Independientemente del lugar en el que viven, la desaparición de estas especies de grandes hervíboros tras una primera conclusión: su muerte arrastra consigo a muchos grandes carnívoros que se alimentan de ellos.

Por si una extinción en cadena no fuera suficiente, la desaparición de animales que devoran grandes cantidades de biomasa también conlleva efectos para el equilibrio del ecosistema vegetal. Muchas especies de plantas utilizan a los grande hervíboros para diseminar sus semillas. Su ausencia limitaría mucho la extensión de ciertas especies vegetales y las pondría también en riesgo de desaparición, alterando completamente la estructura del ecosistema.</p>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                <img src="Imagenes/ua_logo.png"/>
            </asp:TableCell>
            <asp:TableCell runat="server">
                <img width="95px" src="Imagenes/cueva.png" />
            </asp:TableCell>
            <asp:TableCell runat="server">
                <p> texto de la CUEVA </p>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell columnSpan="2" runat="server">
                <p> texto de la UA </p>
            </asp:TableCell>
            <asp:TableCell runat="server">
                <p> continuación texto de la CUEVA </p>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell columnSpan="3" runat="server">
                <img src="Imagenes/logo bajo.png"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

</asp:Content>


