<%@ Page Language="C#" AutoEventWireup="true" CodeFile="resend.aspx.cs" Inherits="resend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Resend Password</title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Panel ID="Panel1" runat="server" 
        style="top: 136px; left: 372px; position: absolute; height: -2px; width: 381px">
            <asp:Label ID="lblEMail" runat="server" 
                style="z-index: 1; left: -29px; top: 140px; position: absolute; width: 196px" 
                Text="E Mail Address"></asp:Label>
            <asp:TextBox ID="txtEMail" runat="server" 
                style="z-index: 1; left: 150px; top: 141px; position: absolute; width: 220px"></asp:TextBox>
            <asp:Button ID="btnPassword" runat="server" 
                style="z-index: 1; left: 150px; top: 189px; position: absolute; width: 228px" 
                Text="Send me my password" OnClick="btnPassword_Click" />
        
                        <asp:Button ID="btnDone" runat="server" 
                style="z-index: 1; left: -84px; top: 375px; position: absolute; width: 78px" 
                Text="Done" OnClick="btnDone_Click" />
            <asp:Label ID="lblConfirm" runat="server" ForeColor="Red" 
                style="z-index: 1; left: -89px; top: 470px; position: absolute; width: 842px"></asp:Label>

        </asp:Panel>
        </form>
                    <h1>
                        Resend Password
                    </h1>
            </body>
</html>
