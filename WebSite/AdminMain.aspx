<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminMain.aspx.cs" Inherits="AdminMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 124px;
            left: 359px;
            z-index: 1;
            width: 367px;
            height: 287px;
        }
        .auto-style2 {
            position: absolute;
            top: 540px;
            z-index: 1;
            left: 545px;
            height: 33px;
            width: 146px;
        }
        .auto-style4 {
            position: absolute;
            top: 536px;
            left: 323px;
            z-index: 1;
            height: 41px;
            width: 187px;
        }
        .auto-style5 {
            position: absolute;
            top: 456px;
            left: 477px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 455px;
            left: 287px;
            z-index: 1;
            font-size: medium;
        }
        .auto-style7 {
            position: absolute;
            top: 457px;
            left: 648px;
            z-index: 1;
            height: 24px;
        }
        .auto-style8 {
            position: absolute;
            top: 231px;
            left: 815px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 545px;
            left: 754px;
            z-index: 1;
            width: 124px;
            height: 35px;
        }
        .auto-style10 {
            position: absolute;
            top: 279px;
            left: 1154px;
            z-index: 1;
            height: 37px;
            width: 195px;
        }
        .auto-style11 {
            position: absolute;
            top: 215px;
            left: 1153px;
            z-index: 1;
            width: 197px;
            height: 39px;
        }
        .auto-style12 {
            position: absolute;
            top: 357px;
            left: 1174px;
            z-index: 1;
            width: 160px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>
            <asp:ListBox ID="ListBox1" runat="server" CssClass="auto-style1"></asp:ListBox>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style5"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text="Enter Game Title"></asp:Label>
            <asp:Button ID="btnSearch" runat="server" CssClass="auto-style7" Text="Search Game" />
            <asp:Button ID="btnDisplay" runat="server" CssClass="auto-style8" Text="Display All" />
            <asp:Button ID="btnEdit" runat="server" CssClass="auto-style4" Text="Edit Game Detail" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" CssClass="auto-style2" Text="Delete Game" OnClick="btnDelete_Click" />
            <asp:Button ID="btnAddGame" runat="server" CssClass="auto-style9" Text="Add Game" OnClick="btnAddGame_Click" />
            <asp:Button ID="btnViewOrder" runat="server" CssClass="auto-style10" Text="View Order" OnClick="btnViewOrder_Click" />
            <asp:Button ID="btnSearchCustomer" runat="server" CssClass="auto-style11" Text="Search Customer" OnClick="btnSearchCustomer_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Admin Main
                <asp:Button ID="btnLogOut" runat="server" CssClass="auto-style12" OnClick="btnLogOut_Click" Text="Log Out" />
            </h2>
        </div>
    </form>
</body>
</html>
