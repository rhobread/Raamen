<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderRaamen.aspx.cs" Inherits="Raamen.View.OrderRaamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .cont{
            padding: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Order Raamen</h1>
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

        <div class="cont">
        <h3>&nbsp;Menu&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cart</h3>
            <asp:GridView ID="ramenGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="ramenGridView_RowCommand" >
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Meat.name" HeaderText="Meat" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Borth" HeaderText="Broth" />
                    <asp:TemplateField HeaderText="">
                        <ItemTemplate>
                            <asp:Button ID="btnOrder" runat="server" Text="Order" CommandName="Order" CommandArgument='<%# Container.DataItemIndex %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Quantity">
                        <ItemTemplate>
                            <asp:Label ID="quantityLabel" runat="server" Text='0'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Amount">
                        <ItemTemplate>
                            <asp:Label ID="amountLabel" runat="server" Text='0'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <h4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Total: <asp:Label ID="totalLabel" runat="server" Text='0'></asp:Label></h4>
            <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>

        <div>
            <asp:Button ID="btnClear" runat="server" Text="Clear Cart" OnClick="btnClear_Click" />
            <asp:Button ID="Button1" runat="server" Text="Buy Cart" OnClick="btnBuy_Click" />
        </div>

        </ContentTemplate>
        </asp:UpdatePanel>
        


    </div>
</asp:Content>
