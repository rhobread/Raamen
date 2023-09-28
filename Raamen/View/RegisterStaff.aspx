<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterStaff.aspx.cs" Inherits="Raamen.View.RegisterStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register Staff</h1>
            <asp:Label ID="UsernameStaffRegisterLabel" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="UsernameStaffRegisterTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="EmailStaffRegisterLabel" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="EmailStaffRegisterTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="GenderStaffLabel" runat="server" Text="Gender"></asp:Label>
            <br />
            <asp:DropDownList ID="GenderStaffList" runat="server">
                <asp:ListItem>---Select Below---</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="PasswordStaffRegisterLabel" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="PasswordStaffRegisterTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="ConfirmPassStaffLabel" runat="server" Text="Confirm Password"></asp:Label>
            <br />
            <asp:TextBox ID="ConfirmPassStaffTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="ErrorStaffLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        </div>
    </form>
</body>
</html>
