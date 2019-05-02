<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogInPage.aspx.cs" Inherits="LogInPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="MSWatchShop.css" rel="MSWatchShop.css" type="text/css" />
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" Text="Sign In" width="160px" />
            <br />
            <br />
            <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Sign Up" width="160px" />
            <br />
            <br />
            <asp:Button ID="btnReSet" runat="server" OnClick="btnReSet_Click" Text="Re Set Password" width="160px" />
            <br />
            <br />
            <asp:Button ID="btnChangePassword" runat="server" OnClick="btnChangePassword_Click" Text="Change Password" Width="160px" />
            <br />
            <br />
            <asp:Button ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" Text="Sign Out" width="160px" />
        </div>
    </form>
</body>
</html>