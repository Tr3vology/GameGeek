<%@ Page Language="C#" AutoEventWireup="true" CodeFile="changepassword.aspx.cs" Inherits="changepassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change your password</title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 158px;
            top: 269px;
            position: absolute;
            width: 197px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Panel ID="Panel1" runat="server" 
        style="top: 121px; left: 540px; position: absolute; height: -6px; width: 414px">
            <asp:Label ID="lblOldPW" runat="server" 
                style="z-index: 1; left: 5px; top: 94px; position: absolute; width: 180px" 
                Text="Old Password"></asp:Label>
            <asp:TextBox ID="txtOldPW" runat="server" 
                style="z-index: 1; left: 191px; top: 99px; position: absolute; width: 220px" 
                        TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblNewPW1" runat="server" 
                style="z-index: 1; left: 13px; top: 135px; position: absolute; width: 185px" 
                Text="New Password"></asp:Label>
            <asp:TextBox ID="txtNewPW1" runat="server" 
                style="z-index: 1; left: 191px; top: 140px; position: absolute; width: 220px" 
                        TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblNewPW2" runat="server" 
                style="z-index: 1; left: 15px; top: 183px; position: absolute; width: 189px" 
                Text="New Password"></asp:Label>
            <asp:TextBox ID="txtNewPW2" runat="server" 
                style="z-index: 1; left: 194px; top: 184px; position: absolute; width: 220px" 
                        TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnChange" runat="server" 
                Text="Change Password" OnClick="btnChange_Click" CssClass="auto-style1" />
                        <asp:Button ID="btnDone" runat="server" 
                style="z-index: 1; left: 10px; top: 403px; position: absolute; width: 78px" 
                Text="Done" OnClick="btnDone_Click" />


            <asp:Label ID="lblError" runat="server" ForeColor="Red" 
                style="z-index: 1; left: 112px; top: 410px; position: absolute; width: 847px"></asp:Label>

        </asp:Panel>
        </form>
                    <h1>
                        Change your password
                    </h1>
            </body>
</html>
