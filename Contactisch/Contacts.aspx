<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="Contactisch.Contacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       Hello 
        <asp:Label ID="Username" runat="server" Text="Label"></asp:Label>,
        here are all your contacts!<br />
        <br />
        <asp:Label ID="ContactsLabel" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
