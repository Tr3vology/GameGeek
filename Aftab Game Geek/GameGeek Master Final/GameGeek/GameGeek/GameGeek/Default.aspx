<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>  
   <link href="MSWatchShop.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 513px;
            left: 413px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 259px;
            left: 394px;
            z-index: 1;
            width: 407px;
            height: 211px;
        }
        .auto-style3 {
            position: absolute;
            top: 585px;
            left: 425px;
            z-index: 1;
        }
    </style>
</head>
<body 
    <form id="form1" runat="server">
        <form id="form2" runat="server">
        <div>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
            <asp:Button ID="btnPopulate" runat="server" CssClass="auto-style1" OnClick="btnPopulate_Click" Text="Populate" />
            <asp:ListBox ID="lstUser" runat="server" CssClass="auto-style2"></asp:ListBox>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="lblError"></asp:Label>
        </form>
</body>
</html>
