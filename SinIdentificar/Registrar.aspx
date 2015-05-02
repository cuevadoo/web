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
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" Width="100%" CssClass="box" placeholder="Nombre"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator1" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox2" runat="server" Width="100%" CssClass="box" placeholder="Primer Apellido"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator2" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox3" runat="server" Width="100%" CssClass="box" placeholder="Segundo Apellido"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator3" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" TextAlign="center">
                        <center>
                            <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList1" runat="server" >
                                <asp:ListItem Text="Hombre" Value="Hombre"></asp:ListItem><asp:ListItem Text="Mujer" Value="Mujer"></asp:ListItem>
                            </asp:RadioButtonList>
                        </center>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator4" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="RadioButtonList1"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox5" runat="server" Width="100%" CssClass="box" placeholder="Email"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator5" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <center>
                            <asp:RegularExpressionValidator CssClass="warning" ID="RegularExpressionValidator1" runat="server" ErrorMessage="El email es incorrecto" ControlToValidate="TextBox5" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </center>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <center>Fecha de Nacimiento:</center>
                        <asp:Table ID="Table2" runat="server">
                            <asp:TableRow ID="TableRow1" runat="server">
                                <asp:TableCell ID="TableCell1" runat="server">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="TextBox6" runat="server" Width="40px" CssClass="box" placeholder="dd"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator6" runat="server" ErrorMessage="&nbsp;*" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
                                </asp:TableCell>
                                <asp:TableCell ID="TableCell2" runat="server">
                                    <asp:TextBox ID="TextBox8" runat="server" Width="40px" CssClass="box" placeholder="mm"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator9" runat="server" ErrorMessage="&nbsp;*" ControlToValidate="TextBox8"></asp:RequiredFieldValidator>
                                </asp:TableCell>
                                <asp:TableCell ID="TableCell3" runat="server">
                                    <asp:TextBox ID="TextBox9" runat="server" Width="80px" CssClass="box" placeholder="yyyy"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator10" runat="server" ErrorMessage="&nbsp;*" ControlToValidate="TextBox9"></asp:RequiredFieldValidator>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox7" runat="server" TextMode="Password" Width="100%" CssClass="box" placeholder="Contraseña"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator7" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox7"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox4"  runat="server" TextMode="Password" Width="100%" CssClass="box" placeholder="Confirmar Contraseña"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator CssClass="warning" ID="RequiredFieldValidator8" runat="server" ErrorMessage="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <center>
                            <asp:CompareValidator CssClass="warning" ControlToValidate="TextBox4" ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas no son iguales"></asp:CompareValidator>
                        </center>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <center>
                            <asp:Label  CssClass="warning" ID="Label10" runat="server"></asp:Label>
                        </center>
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

