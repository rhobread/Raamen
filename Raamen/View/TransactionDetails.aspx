<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetails.aspx.cs" Inherits="Raamen.View.TransactionDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Transaction Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Transaction Details</h1>
        <div>
            <table style="width: 500px">
                <tr>
                    <td>User</td>
                    <td><%= Head.User.Username %></td>
                </tr>
                <tr>
                    <td>Date</td>
                    <td><%= Head.Date %></td>
                </tr>
                <tr>
                    <td>Total Ramen</td>
                    <td><%= Head.User.Headers.Sum( detail => detail.Detail.Quantity) %></td>
                </tr>
                            <tr>
                <td>Total Price</td>
                <td>
                    <% 
                        int totalPrice = 0;
                        foreach (var trans in Head.User.Headers)
                        {
                            int quantity = trans.Detail.Quantity ?? 0;
                            int price = trans.Detail.Raman.Price != null ? Convert.ToInt32(trans.Detail.Raman.Price) : 0;
                            totalPrice += quantity * price;
                        }
                        Response.Write(totalPrice);
                    %>
                </td>
            </tr>
            </table>

            <table style="width: 800px" border="1">
                <tr>
                    <th>Ramen</th>
                    <th>Quantity</th>
                    <th>Broth</th>
                    <th>Meat</th>
                    <th>Price</th>
                    <th>Subtotal</th>
            
                </tr>

                <% foreach (var det in Head.User.Headers)
                    { %>
                    <tr>
                        <td><%= det.Detail.Raman.Name %></td>
                       <td><%= det.Detail.Quantity %></td>
                       <td><%= det.Detail.Raman.Borth %></td>
                      <td><%= det.Detail.Raman.Meat.name %></td>
                        <td><%= det.Detail.Raman.Price %></td>
                        <td><%= (det.Detail.Quantity ?? 0) * (det.Detail.Raman.Price != null ? Convert.ToInt32(det.Detail.Raman.Price) : 0) %></td>

                    </tr>
                <%} %>
                
                
            </table>
        </div>
    </form>
</body>
</html>

