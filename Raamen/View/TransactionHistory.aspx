<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="Raamen.View.TransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h1>History</h1>
        <div> 
           <table width="500px" border="1">
               <tr>
                   <td>Username</td>
                   <td class="auto-style1">Date</td>
                   <td class="auto-style2">Total Product</td>
                   
               </tr>

               <% foreach (var Head in Headers)
                   { %>
                <tr>
                    <td><%= Head.User.Username %></td>
                   <td class="auto-style1"><%= Head.Date %></td>
                   <td class="auto-style2"><%= Head.Detail.Quantity %></td>
                   <td><a href="/View/TransactionDetails.aspx?id=<%= Head.Id %>">Details</a></td>
               </tr>
               
               
               <% }%>

           </table>
        </div>
    </form>
</body>
</html>
