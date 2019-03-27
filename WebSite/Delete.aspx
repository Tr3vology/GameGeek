<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 355px;
            left: 656px;
            z-index: 1;
            width: 82px;
            height: 36px;
        }
        .auto-style2 {
            position: absolute;
            top: 238px;
            left: 507px;
            z-index: 1;
            width: 272px;
            height: 30px;
        }
        .auto-style3 {
            position: absolute;
            top: 356px;
            left: 508px;
            z-index: 1;
            width: 78px;
            height: 34px;
        }
        .auto-style4 {
            position: absolute;
            top: 311px;
            left: 510px;
            z-index: 1;
            width: 429px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style1" Text="No" OnClick="btnNo_Click" />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style3" Text="Yes" OnClick="btnYes_Click" />
        <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Are you sure you want to delete this game"></asp:Label>
    </form>
</body>
</html>
