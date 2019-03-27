<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign up for a new Account</title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 357px;
            top: 460px;
            position: absolute;
            width: 126px;
        }
        .auto-style2 {
            z-index: 1;
            left: 131px;
            top: 394px;
            position: absolute;
            width: 220px;
        }
        .auto-style3 {
            z-index: 1;
            left: -12px;
            top: 388px;
            position: absolute;
            width: 104px;
        }
        .auto-style4 {
            z-index: 1;
            left: 133px;
            top: 358px;
            position: absolute;
            width: 220px;
        }
        .auto-style5 {
            z-index: 1;
            left: -12px;
            top: 352px;
            position: absolute;
            width: 152px;
        }
        .auto-style6 {
            z-index: 1;
            left: 126px;
            top: 207px;
            position: absolute;
            width: 220px;
        }
        .auto-style7 {
            z-index: 1;
            left: 125px;
            top: 172px;
            position: absolute;
            width: 220px;
        }
        .auto-style8 {
            z-index: 1;
            left: -12px;
            top: 168px;
            position: absolute;
            width: 124px;
            bottom: -185px;
        }
        .auto-style9 {
            z-index: 1;
            left: -8px;
            top: 280px;
            position: absolute;
            width: 102px;
        }
        .auto-style10 {
            z-index: 1;
            left: 127px;
            top: 283px;
            position: absolute;
            width: 220px;
            height: 18px;
        }
        .auto-style11 {
            z-index: 1;
            left: -10px;
            top: 237px;
            position: absolute;
            width: 102px;
        }
        .auto-style12 {
            z-index: 1;
            left: -7px;
            top: 318px;
            position: absolute;
            width: 102px;
        }
        .auto-style13 {
            z-index: 1;
            left: 130px;
            top: 318px;
            position: absolute;
            width: 220px;
        }
        .auto-style14 {
            z-index: 1;
            left: 127px;
            top: 246px;
            position: absolute;
            width: 220px;
        }
        .auto-style16 {
            z-index: 1;
            left: -13px;
            top: 201px;
            position: absolute;
            width: 102px;
        }
        .auto-style17 {
            z-index: 1;
            left: -9px;
            top: 128px;
            position: absolute;
            width: 102px;
        }
        .auto-style18 {
            z-index: 1;
            left: 123px;
            top: 135px;
            position: absolute;
            width: 220px;
            right: 61px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Panel ID="Panel1" runat="server" 
        style="top: 118px; left: 356px; position: absolute; height: -7px; width: 412px">
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style7"></asp:TextBox>
            <asp:Label ID="lblLastName" runat="server" 
                Text="Last Name" CssClass="auto-style16"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style6"></asp:TextBox>
            <asp:Label ID="lblEMail" runat="server" 
                Text="E Mail Address" CssClass="auto-style5"></asp:Label>
            <asp:TextBox ID="txtEMail" runat="server" CssClass="auto-style4"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" 
                Visible="False" TextMode="Password" CssClass="auto-style2"></asp:TextBox>
            <asp:Button ID="btnCreate" runat="server" 
                Text="Create Account" Visible="False" OnClick="btnCreate_Click" CssClass="auto-style1" />
                        <asp:Button ID="btnDone" runat="server" 
                style="z-index: 1; left: -140px; top: 513px; position: absolute; width: 78px; right: 474px;" 
                Text="Done" OnClick="btnDone_Click" />
            <asp:Label ID="lblInstructions" runat="server" ForeColor="Red" 
                
                style="z-index: 1; left: -30px; top: 520px; position: absolute; width: 844px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" CssClass="auto-style10"></asp:TextBox>
            <asp:Label ID="lblAddress" runat="server" CssClass="auto-style11" Text="Address"></asp:Label>
            <asp:Label ID="lblPostcode" runat="server" CssClass="auto-style12" Text="Postcode"></asp:Label>
            <asp:TextBox ID="txtPostcode" runat="server" CssClass="auto-style13"></asp:TextBox>
            <asp:TextBox ID="txtTown" runat="server" CssClass="auto-style14"></asp:TextBox>
            <asp:Label ID="lblUser" runat="server" CssClass="auto-style17" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUser" runat="server" CssClass="auto-style18"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" CssClass="auto-style3" Text="Password" Visible="False"></asp:Label>
            <asp:Label ID="lblTown" runat="server" CssClass="auto-style9" Text="Town"></asp:Label>
            <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style8" Text="First Name"></asp:Label>
            <asp:Button ID="btnPassword" runat="server" OnClick="btnPassword_Click" style="z-index: 1; left: 419px; top: 360px; position: absolute; height: 24px; width: 176px" Text="Send Password" />
        </asp:Panel>
        </form>
            <h1>
                New Account Sign up
            </h1>
            </body>
</html>
