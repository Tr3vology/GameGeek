<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Basket.aspx.cs" Inherits="Shopping_Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" 
        style="top: 110px; left: 533px; position: absolute; height: -7px; width: 189px; margin-left: 0px;">
             
                <asp:Button ID="btnDone" runat="server" OnClick="btnDone_Click" style="z-index: 1; left: -350px; top: 401px; position: absolute; width: 137px; right: 402px;" Text="Continue Shopping" />
                
           
            
            <asp:Button ID="btnCheckOut" runat="server" OnClick="btnCheckOut_Click" style="z-index: 1; left: 264px; top: 408px; position: absolute" Text="Check Out" />
                
           
            
            <asp:Label ID="lblItem" runat="server" style="z-index: 1; left: -217px; top: 50px; position: absolute; height: 26px; width: 74px;" Text="Item"></asp:Label>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 282px; top: 53px; position: absolute; height: 16px;" Text="Price"></asp:Label>
            <asp:Label ID="lblTotal" runat="server" style="z-index: 1; left: 175px; top: 350px; position: absolute; width: 74px;" Text="Total"></asp:Label>
                
           
            
        </asp:Panel>
            <h1 class="auto-style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Shopping Cart</h1>
             
                <p>
            <asp:Label ID="lblQ" runat="server" style="z-index: 1; left: 627px; top: 162px; position: absolute; height: 23px;" Text="Quantity"></asp:Label>
            </p>
        <asp:Label ID="lblSampleGameName" runat="server" style="z-index: 1; left: 315px; top: 211px; position: absolute" Text="Driveclub VR"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblSamplegameQ" runat="server" style="z-index: 1; left: 649px; top: 208px; position: absolute; width: 17px" Text="1"></asp:Label>
        <asp:Label ID="lblSampleGamePrice" runat="server" style="z-index: 1; left: 812px; top: 208px; position: absolute" Text="£49.99"></asp:Label>
        <asp:Label ID="lblSampleTotal" runat="server" style="z-index: 1; left: 816px; top: 458px; position: absolute" Text="£49.99"></asp:Label>
        <asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" style="z-index: 1; left: 937px; top: 202px; position: absolute" Text="Remove" />
    </form>
                         
                </body>
</html>
