<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="Contactisch.Contacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Layout/Main.css" />
    <link href='http://fonts.googleapis.com/css?family=Droid+Sans' rel='stylesheet' type='text/css' />
    <link rel='stylesheet' href='Layout/fonts.css' />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="Contact.aspx">
                <div class="businessCard addContact">
                    <div class="iconFont icon-plus-sign"></div>
                </div>
            </a>
            <asp:ListView ID="ListView1" runat="server" ItemType="Contactisch.Contact">
                <ItemTemplate>
                    <a href="Contact.aspx?id=<%# Item.Id %>">
                        <div class="businessCard">
                            <div class="lineName"><%# Item.FullName %></div>
                            <div><%# Item.Phone %></div>
                            <div><%# Item.Email %></div>
                        </div>
                    </a>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
