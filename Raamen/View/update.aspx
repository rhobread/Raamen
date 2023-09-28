<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="Raamen.view.update" %>

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
            <asp:Label ID="meat_label" runat="server" Text="meat : "></asp:Label>
            <asp:DropDownList ID="meat_box" runat="server" OnSelectedIndexChanged="meat_box_SelectedIndexChanged"></asp:DropDownList>
            <asp:Label ID="broth_label" runat="server" Text="broth : "></asp:Label>
            <asp:TextBox ID="broth_box" runat="server"></asp:TextBox>
            <asp:Label ID="price_label" runat="server" Text="price : "></asp:Label>
            <asp:TextBox ID="price_box" runat="server"></asp:TextBox>
            <asp:Button ID="updateRamen" runat="server" Text="update ramen" OnClick="UpdateRamen" />
            <asp:Button ID="manage" runat="server" Text="back to manage" OnClick="manage_Click" />
        </div>
    </form>
</body>
</html>
