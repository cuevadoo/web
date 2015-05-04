<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Configuracion.aspx.cs" Inherits="Identificado_Configuracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div>
        <asp:ImageMap ID="ImageMap1" runat="server" Height="300px" Width="300px" HotSpotMode="PostBack" ImageUrl="~/Imagenes/ImagenPerfil.jpg">
            <asp:RectangleHotSpot Bottom="50" Left="0" Right="50" Top="0" AlternateText="Hola" PostBackValue="Adios" />
        </asp:ImageMap>
        <asp:Label ID="LabelFoto" runat="server" Text=""></asp:Label>
    </div>




</asp:Content>

