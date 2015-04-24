<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Button" 
            onclick="Button1_Click" />
    
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    
    </div>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="Apellido1"></asp:Label>
        <asp:Label ID="Label5" runat="server" Text="Apellido2"></asp:Label>
    </p>
    </form>
</body>
</html>
