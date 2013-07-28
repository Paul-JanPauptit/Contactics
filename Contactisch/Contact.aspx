<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Contactisch.Contact1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Layout/Main.css" />
    <link href='http://fonts.googleapis.com/css?family=Droid+Sans' rel='stylesheet' type='text/css' />
</head>
<body>
    <div id="contact" class="box centerHorizontal">

        <form id="form1" defaultfocus="FullName" runat="server">
            <asp:Panel ID="ErrorContainer" CssClass="errorContainer" runat="server" Visible="false">
                <asp:Label CssClass="errorMessage" ID="MessageLabel" runat="server" Text=""></asp:Label>
            </asp:Panel>
            <div>
                <asp:Label ID="FullNameLabel" CssClass="editLabel" runat="server" Text="Name"></asp:Label>&nbsp;<asp:TextBox ID="FullName" CssClass="editText" runat="server"></asp:TextBox><br />
                <asp:Label ID="AddressLabel" CssClass="editLabel" runat="server" Text="Address"></asp:Label>&nbsp;<asp:TextBox ID="Address" CssClass="editText" runat="server" Rows="4" TextMode="MultiLine"></asp:TextBox><br />
                <asp:Label ID="PhoneLabel" CssClass="editLabel" runat="server" Text="Phone"></asp:Label>&nbsp;<asp:TextBox ID="Phone" CssClass="editText" runat="server"></asp:TextBox><br />
                <asp:Label ID="EmailLabel" CssClass="editLabel" runat="server" Text="Email"></asp:Label>&nbsp;<asp:TextBox ID="Email" CssClass="editText" runat="server"></asp:TextBox><br />
                <asp:Button ID="DoneButton" CssClass="button confirmButton" runat="server" Text="Done" OnClick="DoneButton_Click" />
                <br />
            </div>
        </form>
    </div>
</body>
</html>
