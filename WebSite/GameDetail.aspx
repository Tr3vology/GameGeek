<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GameDetail.aspx.cs" Inherits="details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Game Information</title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 95px;
            top: 257px;
            position: absolute;
            width: 118px;
        }
        .auto-style2 {
            z-index: 1;
            left: 88px;
            top: 121px;
            position: absolute;
            width: 127px;
        }
        .auto-style3 {
            position: absolute;
            top: 558px;
            left: 70px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Button ID="btnReview" runat="server" CssClass="auto-style3" Text="Write Review" OnClick="btnReview_Click" />
    
        <asp:Panel ID="Panel1" runat="server" 
            
            
        style="top: 117px; left: 438px; position: absolute; height: -6px; width: 239px">
                        <asp:Button ID="btnDone" runat="server" 
                style="z-index: 1; left: -334px; top: 532px; position: absolute; width: 78px" 
                Text="Done" OnClick="btnDone_Click" />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" 
                
                style="z-index: 1; left: -123px; top: 544px; position: absolute; width: 842px"></asp:Label>
                        <asp:Image ID="imgDVD" runat="server" ImageUrl="~/2.jpg" 
                style="z-index: 1; left: -412px; top: 97px; position: absolute; height: 301px" />
            <asp:Label ID="lblConsole" runat="server" 
                Text="Console" CssClass="auto-style1"></asp:Label>
            <asp:Label ID="lblGamePrice" runat="server" 
                style="z-index: 1; left: 94px; top: 161px; position: absolute; width: 142px" 
                Text="Game Price"></asp:Label>
            <asp:Label ID="lblTitle" runat="server" 
                Text="Game Title" CssClass="auto-style2"></asp:Label>
                        <asp:Label ID="lblDeveloper" runat="server" style="z-index: 1; left: 97px; top: 215px; position: absolute; width: 106px" Text="Developer"></asp:Label>
        </asp:Panel>
                        <h1>
                            Game Info</h1>
                        <asp:Label ID="lblDcName" runat="server" style="z-index: 1; left: 682px; top: 236px; position: absolute" Text="DriveclubVR"></asp:Label>
        <asp:Label ID="lblDcPrice" runat="server" style="z-index: 1; left: 683px; top: 276px; position: absolute" Text="£49.99"></asp:Label>
        <asp:Label ID="lblDcDev" runat="server" style="z-index: 1; left: 684px; top: 331px; position: absolute" Text="Evolution Studios"></asp:Label>
        <asp:Label ID="lblDcConsole" runat="server" style="z-index: 1; left: 687px; top: 371px; position: absolute" Text="PS4"></asp:Label>
        <asp:Button ID="btnAddtoCart" runat="server" OnClick="btnAddtoCart_Click" style="z-index: 1; left: 627px; top: 431px; position: absolute" Text="Add to Cart" />
        </form>
                        </body>
</html>
