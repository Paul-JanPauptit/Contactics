<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="Contactisch.Contacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Layout/Main.css" />
    <link href='http://fonts.googleapis.com/css?family=Droid+Sans' rel='stylesheet' type='text/css' />
</head>
<body>
    <form id="form1" runat="server">
    <div>
       Hello  
        <asp:Label ID="Username" runat="server" Text="Label"></asp:Label>,
        here are all your contacts!<br />
        <br />
        <asp:Label ID="ContactsLabel" runat="server" Text="Label"></asp:Label>
        <asp:ListView ID="ListView1" runat="server" ItemType="Contactisch.Contact">
            <ItemTemplate>
                <div class="businessCard"><%# Item.FullName %></div>
            </ItemTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
