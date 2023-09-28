<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Raamen.View.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register Customer</h1>
            <asp:Label ID="UsernameRegisterLabel" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="UsernameRegisterTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="EmailRegisterLabel" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="EmailRegisterTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="GenderLabel" runat="server" Text="Gender"></asp:Label>
            <br />
            <asp:DropDownList ID="GenderList" runat="server">
                <asp:ListItem>---Select Below---</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="PasswordRegisterLabel" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="PasswordRegisterTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="ConfirmPassLabel" runat="server" Text="Confirm Password"></asp:Label>
            <br />
            <asp:TextBox ID="ConfirmPassTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        </div>
    </form>
</body>
</html>
