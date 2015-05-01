<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registrar.aspx.cs" Inherits="SinIdentificar_Registrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Registrar</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <center>
   <div>       
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       <br />
       <br />
   </div>

   <div>
        
   <asp:Table ID="Table1" runat="server">

       <asp:TableRow runat="server">
           <asp:TableCell runat="server">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
           </asp:TableCell>
           <asp:TableCell runat="server">          
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           </asp:TableCell>
           <asp:TableCell runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Falta por rellenar este campo" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
           </asp:TableCell>
       </asp:TableRow>

        <asp:TableRow ID="TableRow1" runat="server">
           <asp:TableCell runat="server">
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
           </asp:TableCell>
           <asp:TableCell runat="server">          
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
          </asp:TableCell>
          <asp:TableCell runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Falta por rellenar este campo" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
           </asp:TableCell>
       </asp:TableRow>

        <asp:TableRow ID="TableRow2" runat="server">
           <asp:TableCell runat="server">
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
           </asp:TableCell>
           <asp:TableCell runat="server">          
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
          </asp:TableCell>
          <asp:TableCell runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Falta por rellenar este campo" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
          </asp:TableCell>
       </asp:TableRow>

        <asp:TableRow ID="TableRow3" runat="server">
           <asp:TableCell runat="server">
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
           </asp:TableCell>
           <asp:TableCell runat="server">          
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Text="Hombre" Value="Hombre"></asp:ListItem>
                <asp:ListItem Text="Mujer" Value="Mujer"></asp:ListItem>
            </asp:RadioButtonList>
           </asp:TableCell>
           <asp:TableCell runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Falta por marcar este campo" ControlToValidate="RadioButtonList1"></asp:RequiredFieldValidator>
           </asp:TableCell>
       </asp:TableRow>

        <asp:TableRow ID="TableRow4" runat="server">
           <asp:TableCell runat="server">
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
           </asp:TableCell>
           <asp:TableCell runat="server">          
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
          </asp:TableCell>
          <asp:TableCell runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Falta por rellenar este campo" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
          </asp:TableCell>
       </asp:TableRow>

        <asp:TableRow ID="TableRow5" runat="server">
           <asp:TableCell runat="server">
            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
           </asp:TableCell>
           <asp:TableCell runat="server">          
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
          </asp:TableCell>
          <asp:TableCell ID="TableCell1" runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Falta por rellenar este campo" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
          </asp:TableCell>
       </asp:TableRow>

        <asp:TableRow ID="TableRow6" runat="server">
           <asp:TableCell runat="server">
            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
           </asp:TableCell>
           <asp:TableCell runat="server">          
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
          </asp:TableCell>
          <asp:TableCell ID="TableCell2" runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Falta por rellenar este campo" ControlToValidate="TextBox7"></asp:RequiredFieldValidator>
          </asp:TableCell>
       </asp:TableRow>
        
        </asp:Table>
       
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto los términos y condiciones." AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged"></asp:CheckBox>

       <br />

        <asp:Button ID="Button1" runat="server" Text="Registrar" CssClass="boton" OnClick="Button1_Click" Enabled="False"></asp:Button>
           </center>
   </div>
</asp:Content>

