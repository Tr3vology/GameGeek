<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogIn.aspx.cs" Inherits="AdminLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 240px;
            left: 569px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 334px;
            left: 565px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 338px;
            left: 443px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 245px;
            left: 442px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 443px;
            left: 600px;
            z-index: 1;
        }
        .auto-style6 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox>
        </div>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Username"></asp:Label>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style3" Text="Password"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><span class="auto-style6">&nbsp;Adminstrative Log In&nbsp;&nbsp;</span></strong></p>
        <asp:Button ID="btnLogIn" runat="server" CssClass="auto-style5" Text="Log In" OnClick="btnLogIn_Click" />
    </form>
</body>
</html>
