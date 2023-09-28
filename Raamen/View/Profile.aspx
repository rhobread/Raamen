<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Raamen.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Profile</h1>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <div>
                Username&nbsp;&nbsp;&nbsp; : <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox> <br />
                Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox> <br />
                Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : <asp:DropDownList ID="ddlGender" runat="server" >
                    <asp:ListItem Value="null">Select a gender</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList> <br />
                Password&nbsp;&nbsp;&nbsp; : <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox> <br />
                <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label> <br />
                <asp:LinkButton ID="btnUpdate" runat="server" OnClick="btnUpdate_Click">Update</asp:LinkButton>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
