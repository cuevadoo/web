﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <center>
    <div class="todo">
            <center>

    <asp:Table  class="justify" ID="Table1" cellspacing="30" runat="server" Height="130px" Width="900px">
        <asp:TableRow runat="server">
            <asp:TableCell columnSpan="3" runat="server">
                <center><h3 class="titulo">BIENVENIDOS A CUEVADOO</h3></center>
                <p> Cuevadoo es una red social creada exclusivamente para informátic@s y aficionad@s a la informática. Aquí podrás compartir tus gustos y opiniones, interactúa con el resto de usuarios, agrega amigos, visita sus perfiles y empápate del ambiente que más te gusta.  </p>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                <center><img src="Imagenes/ua_logo.png"/></center>
                <p> Este es un proyecto realizado por alumnos de grado en Ingeniería Informática por la Universidad de Alicante, España.  </p>
            </asp:TableCell>
            <asp:TableCell runat="server">
                <img width="125px" align="left" src="Imagenes/cueva.png" />Nuestra sede se encuentra en el Laboratorio L04 del edificio Escuela Politécnica Superior, donde serás bien recibido para cualquier consulta.
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell columnSpan="3" runat="server">
              <p> Breve explicación de la búsqueda de usuarios (cuando esté hecha) </p>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow1"  runat="server">
            <asp:TableCell ID="TableCell1" columnSpan="3" runat="server">
              <center><img src="Imagenes/logo bajo.png"/></center>
            </asp:TableCell>
            </asp:TableRow>
    </asp:Table>
    </div>
        </center>
</asp:Content>


