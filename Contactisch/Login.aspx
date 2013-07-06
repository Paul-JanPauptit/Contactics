﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Contactisch.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="MessageLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Password" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
