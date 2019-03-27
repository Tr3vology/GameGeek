<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Game Geek</title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 1152px;
            top: 543px;
            position: absolute;
            width: 172px;
            height: 30px;
        }
        .auto-style2 {
            z-index: 1;
            left: 1037px;
            top: 441px;
            position: absolute;
            width: 167px;
            height: 29px;
        }
        .auto-style3 {
            z-index: 1;
            left: 21px;
            top: 327px;
            position: absolute;
            width: 170px;
            height: 30px;
        }
        .auto-style4 {
            z-index: 1;
            left: 21px;
            top: 261px;
            position: absolute;
            height: 28px;
            width: 168px;
        }
        .auto-style5 {
            z-index: 1;
            left: 25px;
            top: 416px;
            position: absolute;
            width: 173px;
            height: 31px;
        }
        .auto-style7 {
            z-index: 1;
            left: 70px;
            top: 194px;
            position: absolute;
            height: 158px;
            width: 187px;
        }
        .auto-style8 {
            z-index: 1;
            left: -53px;
            top: 163px;
            position: absolute;
            width: 70px;
        }
        .auto-style9 {
            z-index: 1;
            left: 929px;
            top: 327px;
            position: absolute;
            width: 86px;
            height: 23px;
        }
        .auto-style10 {
            z-index: 1;
            left: 595px;
            top: 199px;
            position: absolute;
            height: 166px;
            width: 194px;
        }
        .auto-style11 {
            z-index: 1;
            left: 20px;
            top: 365px;
            position: absolute;
            width: 173px;
        }
        .auto-style12 {
            z-index: 1;
            left: 664px;
            top: -37px;
            position: absolute;
            height: 449px;
            width: 222px;
        }
        .auto-style13 {
            position: absolute;
            top: 25px;
            left: 10px;
            z-index: 1;
            height: 6px;
        }
        .auto-style14 {
            position: absolute;
            top: 15px;
            left: 10px;
            z-index: 1;
            width: 175px;
            height: 148px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" CssClass="auto-style13" />
        <asp:Image ID="Image2" runat="server" CssClass="auto-style14" ImageUrl="~/15 Logo.png" />
    
        <asp:Panel ID="Panel1" runat="server" 
            
            style="top: 102px; left: 464px; position: absolute; height: -4px; width: 184px">
            
            <asp:Panel ID="Panel4" runat="server" 
                
                            style="z-index: 1; left: -346px; top: 52px; position: absolute; width: 866px">
                
                <asp:Label ID="lblSearch" runat="server" 
                    style="z-index: 1; left: 85px; top: 17px; position: absolute; width: 70px" 
                    Text="Search"></asp:Label>
                <asp:Button ID="btnContactUs" runat="server" OnClick="btnContactUs_Click" Text="Contact Us" CssClass="auto-style2" />
                <asp:TextBox ID="txtSearch" runat="server" 
                    style="z-index: 1; left: 162px; top: 14px; position: absolute"></asp:TextBox>
                <asp:Button ID="btnSearch0" runat="server" 
                    style="z-index: 1; left: 345px; top: 12px; position: absolute; width: 65px" 
                    Text="Search" OnClick="btnSearch0_Click" />
                <asp:Button ID="btnClear" runat="server" 
                    style="z-index: 1; left: 430px; top: 13px; position: absolute; width: 65px" 
                    Text="Clear" OnClick="btnClear_Click" />
                <asp:Label ID="lblResultsCount" runat="server" 
                    style="z-index: 1; left: 554px; top: 12px; position: absolute; width: 190px"></asp:Label>
                <asp:Button ID="btnLeft" runat="server" 
                    Text="&lt;--" OnClick="btnLeft_Click" CssClass="auto-style8" />
                <asp:Image ID="img1" runat="server" ImageUrl="~/1.jpg" CssClass="auto-style7" />
                <asp:Image ID="img2" runat="server" ImageUrl="~/2.jpg" 
                    style="z-index: 1; left: 317px; top: 234px; position: absolute; height: 158px; width: 216px;" />
                <asp:Image ID="img3" runat="server" ImageUrl="~/3.jpg" CssClass="auto-style10" />
                <asp:Button ID="btnDetails" runat="server" 
                    style="z-index: 1; left: 404px; top: 430px; position: absolute; width: 83px; height: 26px" 
                    Text="Details" OnClick="btnDetails_Click" />
            </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" CssClass="auto-style12">
            <asp:Button ID="btnSignUp" runat="server" 
                style="z-index: 1; left: 21px; top: 19px; position: absolute; width: 173px" 
                Text="Sign up" OnClick="btnSignUp_Click" />
            <asp:Label ID="lblUserName" runat="server" 
                style="z-index: 1; left: 18px; top: 56px; position: absolute; width: 173px" 
                Text="EMail Address"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" 
                style="z-index: 1; left: 18px; top: 80px; position: absolute; width: 173px"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 18px; top: 109px; position: absolute; width: 173px" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 18px; top: 134px; position: absolute; width: 173px" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 18px; top: 167px; position: absolute; width: 173px;" Text="Login" />
            <asp:Button ID="btnResend" runat="server" OnClick="btnResend_Click" style="z-index: 1; left: 18px; top: 198px; position: absolute; width: 173px;" Text="Resend Password" />
            <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" Visible="False" CssClass="auto-style3" />
            <asp:Button ID="btnAccDetails" runat="server" OnClick="btnAccDetails_Click" style="z-index: 1; left: 22px; top: 295px; position: absolute; width: 170px; margin-bottom: 0px;" Text="Account Details" />
            <asp:Button ID="btnChange" runat="server" style="z-index: 1; left: 18px; top: 227px; position: absolute; width: 174px" Text="Change Password" />
            <asp:Button ID="btnBasket" runat="server" OnClick="btnBasket_Click" Text="Shopping Basket" CssClass="auto-style11" />
            <asp:Button ID="btnCheckOut" runat="server" OnClick="btnCheckOut_Click" Text="Check Out" CssClass="auto-style5" />
            <asp:Button ID="btnAdminLogIn" runat="server" OnClick="btnAdminLogIn_Click" Text="Admin Log In" CssClass="auto-style4" />
        </asp:Panel>

            
                        <asp:Label ID="lblError" runat="server" ForeColor="Red" 
                            
                            style="z-index: 1; left: -212px; top: 554px; position: absolute; width: 694px"></asp:Label>
        </asp:Panel>
        
    
    </div>
            
        <p>
                <asp:Button ID="btnHelp" runat="server" OnClick="btnHelp_Click" style="margin-top: 0px; color: #00FF00;" Text="Help" CssClass="auto-style1" />
                </p>
            
                        <h1>
                            Game Geek</h1>
        <asp:Label ID="lblHelp" runat="server" style="z-index: 1; left: 252px; top: 625px; position: absolute; width: 648px"></asp:Label>
        <p>
                <asp:Button ID="btnRight" runat="server" 
                    Text="--&gt;" OnClick="btnRight_Click" CssClass="auto-style9" />
                </p>
    </form>
</body>
</html>
