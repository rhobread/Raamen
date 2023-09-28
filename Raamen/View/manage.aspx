<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage.aspx.cs" Inherits="Raamen.view.manage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    
                    <asp:BoundField DataField="Id" HeaderText="Ramen Id" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Ramen Name" SortExpression="Name" />
                    
                    <asp:BoundField DataField="Borth" HeaderText="Broth" SortExpression="Borth" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:CommandField ButtonType="Button" HeaderText="actions" ShowEditButton="True" ShowHeader="True" />
                    
                    <asp:CommandField ButtonType="Button" HeaderText="delete" ShowDeleteButton="True" ShowHeader="True" />
                    
                </Columns>
               
            </asp:GridView>

            
            <asp:Button ID="insert" runat="server" Text="insert ramen" OnClick="insert_Click" />
            
            
        </div>

        
        
    </form>
</body>
</html>
