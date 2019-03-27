<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-size: x-large;
            color: #3366FF;
        }
        .auto-style3 {
            color: #3366FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1">&nbsp;Telephone No: 01165678765</span></p>
    <p>
        <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E-mail: <span class="auto-style3">gamegeek</span></span><a href="mailto:mswatch@gmail.com"><span class="auto-style2">@gmail.com</span></a></p>
    <p class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Address: 12 Castle Street Leicester &nbsp;</p>
    <p class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Post Code: LE12 9DB</p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 78px; top: 378px; position: absolute; height: 28px; width: 133px" Text="Home" />
        </p>
    </form>
    </body>
</html>
