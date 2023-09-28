<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="Raamen.view.insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Name_label" runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="Name_box" runat="server"></asp:TextBox>
            <asp:Label ID="Name_Error" runat="server" Text=" "></asp:Label>
            <br />
            <asp:Label ID="meat_label" runat="server" Text="meat : "></asp:Label>
            <asp:DropDownList ID="meat_box" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="broth_label" runat="server" Text="broth : "></asp:Label>
            <asp:TextBox ID="broth_box" runat="server"></asp:TextBox>
            <asp:Label ID="Broth_Error" runat="server" Text=" "></asp:Label>
            <br />
            <asp:Label ID="price_label" runat="server" Text="price : "></asp:Label>
            <asp:TextBox ID="price_box" runat="server"></asp:TextBox>
            <asp:Label ID="Price_Error" runat="server" Text=" "></asp:Label>
            <br />
            <asp:Button ID="insertRamen" runat="server" Text="insert ramen" OnClick="InsertRamen" />
            <asp:Button ID="manage" runat="server" Text="back to manage" OnClick="manage_Click" />
        </div>
    </form>
</body>
</html>
