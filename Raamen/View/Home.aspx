<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Raamen.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Welcome <asp:Label ID="lblRole" runat="server" Text="Guest!"></asp:Label>
        </h1>
    </div>
    <div>
        <asp:Label ID="lblList" runat="server" Text="List"></asp:Label> <br />
        <asp:ListBox ID="listUser" runat="server" Height="300px"></asp:ListBox>
    </div>
</asp:Content>
