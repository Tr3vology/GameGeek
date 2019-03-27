<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeOrderStatus.aspx.cs" Inherits="ChangeOrderStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style2 {
            position: absolute;
            top: 187px;
            left: 571px;
            z-index: 1;
            width: 218px;
        }
        .auto-style3 {
            position: absolute;
            top: 253px;
            left: 570px;
            z-index: 1;
            width: 209px;
        }
        .auto-style4 {
            position: absolute;
            top: 322px;
            left: 394px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 190px;
            left: 426px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 251px;
            left: 391px;
            z-index: 1;
            height: 18px;
        }
        .auto-style7 {
            height: 39px;
        }
        .auto-style8 {
            width: 309px;
            height: 213px;
            position: absolute;
            top: 315px;
            left: 550px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 185px;
            left: 844px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 596px;
            left: 551px;
            z-index: 1;
            width: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
        <asp:Calendar ID="Calendar1" runat="server" CssClass="auto-style8"></asp:Calendar>
        <asp:Button ID="btnChange" runat="server" CssClass="auto-style10" Text="Confirm Changes" OnClick="btnChange_Click" />
        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Delivery Date"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style6" Text="Order Quantity"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text="Order ID"></asp:Label>
        <div class="auto-style7">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Check Order Status</h2>
        </div>
        <asp:Button ID="btnSearch" runat="server" CssClass="auto-style9" Text="Search" OnClick="Button1_Click" />
    </form>
</body>
</html>
