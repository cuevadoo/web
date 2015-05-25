<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Mensajes.aspx.cs" Inherits="Identificado_Mensajes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <!--Se mostrarán los mensajes que has recibido -->
    <center>
        <div>
            <h3 class="titulo">Recibidos</h3><br />
            <asp:Table CssClass="tablaBuscador" ID="Table1" runat="server" OnLoad="Table1_Load" Width="60%">
                <asp:TableRow>                  
                    <asp:TableCell> 
                        <center>                    
                        <h3 class="titulo" >USUARIO</h3>
                        </center>                         
                    </asp:TableCell>                        
                    <asp:TableCell CssClass="center">
                        <center>
                        <h3 class="titulo">MENSAJE</h3>
                        </center>
                    </asp:TableCell>
                 </asp:TableRow>
            </asp:Table>
       </div>
   </center>
</asp:Content>

