<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 545px;
            left: 430px;
            z-index: 1;
            width: 83px;
            height: 30px;
        }
        .auto-style2 {
            position: absolute;
            top: 544px;
            left: 625px;
            z-index: 1;
            width: 78px;
            height: 34px;
        }
        .auto-style4 {
            position: absolute;
            top: 483px;
            left: 431px;
            z-index: 1;
            width: 149px;
            height: 23px;
        }
        .auto-style5 {
            position: absolute;
            top: 412px;
            left: 439px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 359px;
            left: 439px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 303px;
            left: 441px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            left: 330px;
            z-index: 1;
            top: 485px;
        }
        .auto-style10 {
            position: absolute;
            top: 294px;
            left: 327px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 359px;
            left: 327px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            left: 329px;
            z-index: 1;
            height: 24px;
            top: 419px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnCancel" runat="server" CssClass="auto-style1" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Button ID="btnOk" runat="server" CssClass="auto-style2" Text="Ok" OnClick="btnOk_Click" />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style6"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style5"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style12" Text="Developer"></asp:Label>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style9" Text="Console"></asp:Label>
            <asp:Label ID="Label3" runat="server" CssClass="auto-style11" Text="Price"></asp:Label>
            <asp:Label ID="Label4" runat="server" CssClass="auto-style10" Text="Game Title"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style7"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" CssClass="auto-style4">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
