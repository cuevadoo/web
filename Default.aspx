<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Table class="justify" ID="Table1" border runat="server" Height="130px" Width="251px">
        <asp:TableRow runat="server">
            <asp:TableCell columnSpan="3" runat="server">
                <h3 class="titulo">BIENVENIDOS A CUEVADOO</h3>
                <p> Cuevadoo es una red social creada exclusivamente para informátic@s y aficionad@s a la informática. Aquí podrás compartir tus gustos y opiniones, interactúa con el resto de usuarios, agrega amigos, visita sus perfiles y empápate del ambiente que más te gusta.  </p>
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
                <p> Nuestra sede se encuentra en el Laboratorio L04 </p>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow  runat="server">
            <asp:TableCell columnSpan="2" runat="server">
                <p> Este es un proyecto realizado por alumnos de grado en Ingeniería Informática por la Universidad de Alicante, España.  </p>
            </asp:TableCell>
            <asp:TableCell  runat="server">
                <p> del edificio Escuela Politécnica Superior, donde serás bien recibido para cualquier consulta. </p>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell columnSpan="3" runat="server">
                <img src="Imagenes/logo bajo.png"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

</asp:Content>


