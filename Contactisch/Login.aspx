<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Contactisch.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contactisch</title>
    <link rel="stylesheet" type="text/css" href="Layout/Main.css" />
    <link href='http://fonts.googleapis.com/css?family=Droid+Sans' rel='stylesheet' type='text/css' />
</head>
<body>
    <img id="logo" class="centerHorizontal" src="Images/LogoMain.png" />
    <div id="login" class="box centerHorizontal loginBox">
        <form id="form1" runat="server" defaultfocus="Username">
            <asp:Panel ID="ErrorContainer" CssClass="errorContainer" runat="server" Visible="false">
                <asp:Label CssClass="errorMessage" ID="MessageLabel" runat="server" Text=""></asp:Label>
            </asp:Panel>
            <div class="label">
                <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label>
            </div>
            <div class="inputContainer">
                <asp:TextBox CssClass="input" ID="Username" runat="server" tabindex="1"></asp:TextBox>
            </div>
            <div class="label">
                <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
                <a class="forgotPassword" href="ResetPassword.aspx" tabindex="5">Forgot your password?</a>
            </div>
            <div class="inputContainer">
                <asp:TextBox CssClass="input" ID="Password" TextMode="Password" runat="server" tabindex="2"></asp:TextBox>
            </div>
            <asp:Button ID="LoginButton" CssClass="button loginButton" runat="server" Text="Login" OnClick="LoginButton_Click" tabindex="3" />
        </form>
    </div>
</body>
</html>
