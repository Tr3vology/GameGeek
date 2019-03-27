<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewPage.aspx.cs" Inherits="ReviewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 188px;
            left: 331px;
            z-index: 1;
            height: 51px;
            width: 349px;
        }
        .auto-style2 {
            position: absolute;
            top: 248px;
            left: 358px;
            z-index: 1;
            width: 560px;
            height: 268px;
        }
        .auto-style3 {
            position: absolute;
            top: 610px;
            left: 293px;
            z-index: 1;
            width: 129px;
            height: 33px;
        }
        .auto-style4 {
            position: absolute;
            top: 611px;
            left: 828px;
            z-index: 1;
            width: 113px;
            height: 28px;
        }
        .auto-style5 {
            position: absolute;
            top: 557px;
            left: 615px;
            z-index: 1;
            width: 228px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Please write your reviews here"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2" TextMode="MultiLine"></asp:TextBox>
            <asp:Button ID="btnBack" runat="server" CssClass="auto-style3" OnClick="btnBack_Click" Text="Back" />
            <asp:Button ID="btnSave" runat="server" CssClass="auto-style4" OnClick="btnSave_Click" Text="Save" />
            <asp:Label ID="lblReview" runat="server" CssClass="auto-style5"></asp:Label>
        </div>
    </form>
</body>
</html>
