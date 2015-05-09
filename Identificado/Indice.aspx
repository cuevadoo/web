<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Indice.aspx.cs" Inherits="Identificado_Indice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <div class="todo">
    <div runat="server" class="BuscadorFlotante">
        &nbsp;<asp:TextBox onclick = "document.getElementById('ContentPlaceHolder1_light').style.display='block';document.getElementById('ContentPlaceHolder1_fade').style.display='block';document.getElementById('ContentPlaceHolder1_TextBox1').placeholder='Buscar amigo';document.getElementById('ContentPlaceHolder1_TextBox1').focus();document.getElementById('ContentPlaceHolder1_TextBox1').value='';" CssClass="box" placeholder="Buscar amigo" ID="TextBox3" runat="server" Width="776px"></asp:TextBox>
        <div runat="server" id="fade" class="FondoBuscador" onclick = "document.getElementById('ContentPlaceHolder1_light').style.display='none';document.getElementById('ContentPlaceHolder1_fade').style.display='none';document.getElementById('ContentPlaceHolder1_TextBox1').value=''"></div>
        <div runat="server" id="light" class="ContenidoBuscador">
            &nbsp;<asp:TextBox CssClass="box" placeholder="" ID="TextBox1" runat="server" Width="776px" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:Table CssClass="tablaBuscador" ID="Table2" runat="server" Width="800px"></asp:Table>
            <asp:Table ID="Table1" runat="server"></asp:Table>
        </div> 
    </div>

    <div>
        <br /><br />
        <asp:Table ID="Table3" runat="server" Width="100%">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" Width="70%">
                    <asp:TextBox ID="TextBox2" runat="server" Width="80%" Height="60px" CssClass="box" placeholder="Cuéntale a tus amigos qué estás haciendo" TextMode="MultiLine" EnableViewState="True" EnableTheming="True"></asp:TextBox>
</asp:TableCell>
            <asp:TableCell Width="30%" HorizontalAlign="Center">
                <p>CHAT</p>
            </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow2" runat="server" Width="50%">
                <asp:TableCell ID="TableCell2" runat="server"><asp:Button ID="Button2" runat="server" Text="Enviar" cssclass="boton" OnClick="Button2_Click"></asp:Button>
                    


</asp:TableCell>
                <asp:TableCell runat="server" Width="50%"><asp:TextBox ID="TextBox4" runat="server" Width="80%" CssClass="box" placeholder="Amigos"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow3" runat="server">
                <asp:TableCell ID="TableCell3" runat="server"><asp:Label ID="Label1" runat="server" Text="REGISTRO DE ACTIVIDAD"></asp:Label>
                    


</asp:TableCell>
                <asp:TableCell runat="server" Width="50%">
<div style="background-color: #FFFFFF; width: 85%;"><br /><br /><br /><br /><br /><br />

</div>
                </asp:TableCell>
            </asp:TableRow>


            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"><asp:TextBox ID="TextBox5" runat="server" Width="80%" CssClass="box" placeholder="Escribe aquí"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"><asp:Button ID="Button1" runat="server" Text="Enviar" cssclass="boton"></asp:Button></asp:TableCell>
            </asp:TableRow>


        </asp:Table>
    </div>


  
        
    
            </div>
        </center>
</asp:Content>

