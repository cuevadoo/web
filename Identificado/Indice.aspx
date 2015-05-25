<%@ Page Title="" Language="C#" MasterPageFile="~/Identificado/MasterPage.master" AutoEventWireup="true" CodeFile="Indice.aspx.cs" Inherits="Identificado_Indice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--Aqui aparecerá el registro de actividad de tus amigos, donde también podrás realizar tus propias publicaciones. También encontramos
        otro buscador en la parte superior-->
    <center>
        <div class="todo">
            <!--div para el buscador de amigos en la esquina superior izquierda-->
            <div runat="server" class="BuscadorFlotante">
                &nbsp;<asp:TextBox onclick = "document.getElementById('ContentPlaceHolder1_light').style.display='block';document.getElementById('ContentPlaceHolder1_fade').style.display='block';document.getElementById('ContentPlaceHolder1_TextBox1').placeholder='Buscar amigo';document.getElementById('ContentPlaceHolder1_TextBox1').focus();document.getElementById('ContentPlaceHolder1_TextBox1').value='';" CssClass="box" placeholder="Buscar amigo" ID="TextBox3" runat="server" Width="776px"></asp:TextBox>                      
                <div runat="server" id="fade" class="FondoBuscador" onclick = "document.getElementById('ContentPlaceHolder1_light').style.display='none';document.getElementById('ContentPlaceHolder1_fade').style.display='none';document.getElementById('ContentPlaceHolder1_TextBox1').value=''"></div>
               <!-- div para los resultados de búsqueda de amigos--> 
                 <div runat="server" id="light" class="ContenidoBuscador">
                    &nbsp;<asp:TextBox CssClass="box" placeholder="" ID="TextBox1" runat="server" Width="776px" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    <asp:Table CssClass="tablaBuscador" ID="Table2" runat="server" Width="800px"></asp:Table>
                    <asp:Table ID="Table1" runat="server"></asp:Table>
                </div> 
            </div>
            <!--div para el resto de componentes de la página íncide: cuadro de publicación, botón de publicación, tabla de amigos, registro de actividad...--> 
            <div>
                <br /><br />
                <asp:Table ID="Table3" runat="server" Width="100%">
                    <asp:TableRow>
                        <asp:TableCell Width="650px" Height="180px">
                            <asp:Table ID="TableEstatica" runat="server" Width="100%">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:TextBox ID="TextBoxPublicacion" style="max-width:600px;max-height:60px" Wrap="true" runat="server" Width="600px" Height="60px" CssClass="box" placeholder="Cuéntale a tus amigos qué estás haciendo" TextMode="MultiLine" EnableViewState="True" EnableTheming="True"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Button ID="ButtonEnviarP" runat="server" Text="Enviar" cssclass="boton" OnClick="Button1_Click"></asp:Button>
                                        <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <p class="titulo">REGISTRO DE ACTIVIDAD</p>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                        <asp:TableCell RowSpan="2">
                            <asp:Table ID="TableAmigos" OnLoad="TableAmigos_Load" CssClass="tablaBuscador"  runat="server" style="table-layout:fixed;overflow-y:scroll;overflow-x:scroll;" Width="250px" Height="580px"></asp:Table>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell VerticalAlign="Top">
                            <asp:Table ID="TablePublicaciones" OnLoad="TablePublicaciones_Load" CssClass="tablaBuscador" runat="server" style="table-layout:fixed;text-wrap:normal;text-align:center"></asp:Table>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
        </div>
    </center>
</asp:Content>

