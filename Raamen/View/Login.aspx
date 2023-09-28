<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Raamen.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="RememberCheckBox" runat="server" Text="Remember Me"/>
            <br />
            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
        </div>
    </form>
</body>
</html>
