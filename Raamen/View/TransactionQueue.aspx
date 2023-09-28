<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionQueue.aspx.cs" Inherits="Raamen.View.TransactionQueue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Transaction Queue</h1>
        <div> 
           <table width="500px" border="1">
               <tr>
                    <td class="auto-style1">Transaction ID</td>
                   <td class="auto-style1">User ID</td>
                   <td>User</td>
                   <td class="auto-style1">Date</td>
                   <td class="auto-style1">Quantity</td>
                   <td class="auto-style1">Ramen Name</td>
                   <td class="auto-style1">Meat</td>
                   <td class="auto-style1">Broth</td>
                   <td class="auto-style2"></td>
                </tr>
                   <% foreach (var HeadTool in HeaderTools)
                   { %>
               <tr>
                   <td class="auto-style1"><%= HeadTool.Id%></td>
                    <td><%= HeadTool.Customerid %></td>
                   <td class="auto-style1"><%= HeadTool.User.Username %></td>
                   <td class="auto-style2"><%= HeadTool.Date %></td>
                   <td class="auto-style3"><%= HeadTool.DetailTool.Quantity %></td>
                   <td class="auto-style4"><%= HeadTool.DetailTool.Raman.Name %></td>
                   <td class="auto-style5"><%= HeadTool.DetailTool.Raman.Meat.name %></td>
                   <td class="auto-style6"><%= HeadTool.DetailTool.Raman.Borth %></td>
                   <td><asp:Button ID="Button2" runat="server" Text="Handle Order" OnClick="Button2_Click" /></td>
               </tr>
               
               <% }%>
         </table>
        </div>
            </div>
    </form>
</body>
</html>
