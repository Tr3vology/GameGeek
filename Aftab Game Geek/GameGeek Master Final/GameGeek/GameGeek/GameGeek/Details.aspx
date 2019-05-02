<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        This displays the details for an individual product, again hard coded HTML<br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="317px" ImageUrl="~/Images/cat.jpg" Width="331px" />
        <br />
        <br />
        Quantity
        <asp:TextBox ID="txtQTY" runat="server">1</asp:TextBox>
        <br />
    
    </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add to Cart" />
        <br />
        <br />
        <asp:Button ID="btnContinue" runat="server" OnClick="btnContinue_Click" Text="Continue Shopping" />
    </form>
</body>
</html>
