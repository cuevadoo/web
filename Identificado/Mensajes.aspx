<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Mensajes.aspx.cs" Inherits="Identificado_Mensajes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--Se mostrarán los mensajes que has recibido -->
    <center>
        <div>
            <h3 class="titulo">Recibidos</h3><br />
            <asp:Table ID="Table2" runat="server" Width="70%">
                <asp:TableRow>                  
                   <asp:TableCell CssClass="center">                   
                      <h3 class="titulo" >USUARIO</h3>                         
                   </asp:TableCell>
                   <asp:TableCell CssClass="center">
                       <h3 class="titulo" >MENSAJE</h3>
                   </asp:TableCell>                       
                </asp:TableRow>
            </asp:Table>
            <asp:Table ID="Table1" runat="server" OnLoad="Table1_Load" Width="60%"></asp:Table>
       </div>
   </center>
</asp:Content>

