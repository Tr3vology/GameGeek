<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditCustomerDetail.aspx.cs" Inherits="EditCustomerDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Customer Detail</title>
     <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 197px;
            left: 390px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 351px;
            left: 526px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 403px;
            left: 524px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 290px;
            left: 525px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 195px;
            left: 758px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 470px;
            left: 514px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 353px;
            left: 311px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 293px;
            left: 371px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 197px;
            left: 525px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 412px;
            left: 349px;
            z-index: 1;
        }
        .auto-style11 {
            height: 91px;
        }
        .auto-style12 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style11">
            <asp:Button ID="btnConfirm" runat="server" CssClass="auto-style6" Text="Confirm Change" OnClick="Button1_Click" />
            <asp:Button ID="btnSearch" runat="server" CssClass="auto-style5" Text="Search" OnClick="btnSearch_Click" />
            <asp:Label ID="Label1" runat="server" CssClass="auto-style8" Text="Customer Name"></asp:Label>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style7" Text="Customer Date Of Birth"></asp:Label>
            <asp:Label ID="Label3" runat="server" CssClass="auto-style1" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style4"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style2"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style9"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" CssClass="auto-style10" Text="Customer Address"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><span class="auto-style12">&nbsp;
            <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Edit Customer Detail</span></strong></h2>
        </div>
    </form>
</body>
</html>
