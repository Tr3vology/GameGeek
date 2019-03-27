<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment Page.aspx.cs" Inherits="CheckOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="styles.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" 
        style="top: 108px; left: 579px; position: absolute; height: -3px; width: 305px; margin-top: 0px; margin-bottom: 0px;">
                <asp:Button ID="btnDone" runat="server" OnClick="btnDone_Click" style="z-index: 1; left: 21px; top: 498px; position: absolute" Text="Done" />
                <asp:Button ID="btnPay" runat="server" style="z-index: 1; left: 143px; top: 359px; position: absolute" Text="Confirm Payment" OnClick="btnPay_Click" />
                <asp:Label ID="lblCardNo" runat="server" style="z-index: 1; left: -27px; top: 195px; position: absolute" Text="Card No."></asp:Label>
            
            
            <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: -24px; top: 235px; position: absolute" Text="Expiry Date"></asp:Label>
            <asp:Label ID="lblCode" runat="server" style="z-index: 1; left: -26px; top: 282px; position: absolute" Text="Security Code"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 139px; top: 236px; position: absolute; width: 203px"></asp:TextBox>
            <asp:TextBox ID="txtCode" runat="server" style="z-index: 1; left: 141px; top: 283px; position: absolute; width: 203px"></asp:TextBox>
            <asp:Label ID="lblTotal" runat="server" style="z-index: 1; left: -31px; top: 103px; position: absolute; margin-bottom: 22px" Text="Total Amount"></asp:Label>
            
            
            <asp:Label ID="lblPaid" runat="server" style="z-index: 1; left: -43px; top: 420px; position: absolute; width: 519px"></asp:Label>
            
            
            <asp:TextBox ID="txtCardNo1" runat="server" style="z-index: 1; left: 136px; top: 200px; position: absolute; width: 201px"></asp:TextBox>
            
            
        </asp:Panel>
            <h1 class="auto-style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Payment Detail
            </h1>
                <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 781px; top: 209px; position: absolute" Text="£49.99"></asp:Label>
    </form>
                </body>
</html>
