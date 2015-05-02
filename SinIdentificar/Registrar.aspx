<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registrar.aspx.cs" Inherits="SinIdentificar_Registrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Registrar</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
        <div>
            <asp:Label ID="Label1" runat="server" Text="BIENVENIDOS A CUEVADOO"></asp:Label>
            <br />
            <br />
        </div>
        <div>
            <asp:Table ID="Table1" runat="server" BorderColor="Yellow" BorderWidth="2">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!-- <asp:Label ID="Label2" runat="server" Text="NOMBRE:"></asp:Label>-->
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" Width="100%" CssClass="box" placeholder="Nombre"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!--<asp:Label ID="Label3" runat="server" Text="PRIMER APELLIDO:"></asp:Label>-->
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox2" runat="server" Width="100%" CssClass="box" placeholder="Primer Apellido"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="     *" ControlToValidate="TextBox2" CssClass="box"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!--<asp:Label ID="Label4" runat="server" Text="SEGUNDO APELLIDO:"></asp:Label>-->
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox3" runat="server" Width="100%" CssClass="box" placeholder="Segundo Apellido"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="     *" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!--<asp:Label ID="Label5" runat="server" Text="SEXO:"></asp:Label>-->
                    </asp:TableCell>
                    <asp:TableCell runat="server" TextAlign="center">
                        <center>
                            <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList1" runat="server" >
                                <asp:ListItem Text="Hombre" Value="Hombre"></asp:ListItem><asp:ListItem Text="Mujer" Value="Mujer"></asp:ListItem>
                            </asp:RadioButtonList>
                        </center>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="     *" ControlToValidate="RadioButtonList1"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!--<asp:Label ID="Label6" runat="server" Text="EMAIL:" ></asp:Label>-->
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox5" runat="server" Width="100%" CssClass="box" placeholder="Email"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="     *" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="El email es incorrecto" ControlToValidate="TextBox5" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <asp:Label ID="Label10" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!--<asp:Label ID="Label7" runat="server" Text="FECHA DE NACIMIENTO:"></asp:Label>-->
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <center>Fecha de Nacimiento:</center>
                        <asp:Table ID="Table2" runat="server">
                            <asp:TableRow ID="TableRow1" runat="server">
                                
                                <asp:TableCell ID="TableCell1" runat="server">
                
                                    <asp:TextBox ID="TextBox6" runat="server" Width="40px" CssClass="box" placeholder="dd"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ID="TableCell2" runat="server">
                                    <asp:TextBox ID="TextBox8" runat="server" Width="40px" CssClass="box" placeholder="mm"></asp:TextBox>
                                </asp:TableCell>
                                <asp:TableCell ID="TableCell3" runat="server">
                                    <asp:TextBox ID="TextBox9" runat="server" Width="80px" CssClass="box" placeholder="yyyy"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Falta dia" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage=" Falta mes" ControlToValidate="TextBox8"></asp:RequiredFieldValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage=" Falta año" ControlToValidate="TextBox9"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <!--<asp:Label ID="Label8" runat="server" Text="CONTRASEÑA:"></asp:Label>-->
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox7" runat="server" TextMode="Password" Width="100%" CssClass="box" placeholder="Contraseña"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="     *" ControlToValidate="TextBox7"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell>
                        <!--<asp:Label ID="Label9" runat="server" Text="REPITE CONTRASEÑA:" ></asp:Label>-->
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox4"  runat="server" TextMode="Password" Width="100%" CssClass="box" placeholder="Confirmar Contraseña"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="     *" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ControlToValidate="TextBox4" ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas no son iguales" ValidationGroup="cont" ValueToCompare="Hola"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto los términos y condiciones." OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="True"></asp:CheckBox>
            <br/><br/>
            <asp:Button ID="Button1" runat="server" Text="Registrar" cssclass="boton" OnClick="Button1_Click" Enabled="False"></asp:Button>
        </div>
    </center>
</asp:Content>

