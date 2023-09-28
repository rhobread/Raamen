<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Startup.aspx.cs" Inherits="Raamen.View.Startup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="LogInButton" runat="server" Text="Log In" OnClick="LogInButton_Click" />
            <asp:Button ID="CustomerRegisterButton" runat="server" Text="Register as Customer" OnClick="CustomerRegisterButton_Click" />
            <asp:Button ID="StaffRegisterButton" runat="server" Text="Register as Staff" OnClick="StaffRegisterButton_Click" />
        </div>
    </form>
</body>
</html>
