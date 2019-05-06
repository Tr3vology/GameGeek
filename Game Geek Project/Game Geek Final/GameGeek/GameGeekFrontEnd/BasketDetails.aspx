<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Produsct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
         <br />
        <br />
        <br />
        <br />
        <br />
        Your cart has
        <asp:Label ID="lblCartCount" runat="server"></asp:Label>
&nbsp;items. <a href="Viewcart.aspx">View cart</a> <br />
&nbsp;<table style="width:100%;">
            <tr>
                <td>Product 1</td>
                <td>£2.50</td>
                <td>
                    <a href="Details.aspx?ProductID=1">Details</a>
                </td>
            </tr>
            <tr>
                <td>Product 2</td>
                <td>£33.00</td>
                <td>
                    <a href="Details.aspx?ProductID=2">Details</a>
                </td>
            </tr>
            <tr>
                <td>Product 3</td>
                <td>£14.00</td>
                <td>
                    <a href="Details.aspx?ProductID=3">Details</a>
                </td>
            </tr>
        </table>
    
&nbsp;<br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
