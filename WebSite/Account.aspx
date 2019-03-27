<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Account.aspx.cs" Inherits="Account" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            width: 1423px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <asp:Panel ID="Panel1" runat="server"  
        style="top: 121px; left: 574px; position: absolute; height: -5px; width: 310px">
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" style="z-index: 1; left: 238px; top: 486px; position: absolute; margin-bottom: 282px; height: 28px;" Text="Update" />
                <asp:Button ID="btnDone" runat="server" OnClick="btnDone_Click" style="z-index: 1; left: -57px; top: 543px; position: absolute" Text="Done" />
                <asp:Label ID="lblUpdated" runat="server" style="z-index: 1; left: 50px; top: 544px; position: absolute" Font-Size="Medium"></asp:Label>
           
            
             <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: -28px; top: 113px; position: absolute" Text="Username"></asp:Label>
             <asp:Label ID="lblFName" runat="server" style="z-index: 1; left: -28px; top: 161px; position: absolute" Text="First Name"></asp:Label>
             <asp:Label ID="lblLName" runat="server" style="z-index: 1; left: -29px; top: 215px; position: absolute" Text="Last Name"></asp:Label>
             <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: -27px; top: 272px; position: absolute" Text="Address"></asp:Label>
             <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: -25px; top: 326px; position: absolute" Text="Town"></asp:Label>
             <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: -22px; top: 366px; position: absolute" Text="Postcode"></asp:Label>
             <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: -29px; top: 418px; position: absolute" Text="E Mail Address"></asp:Label>
             <asp:TextBox ID="txtUser" runat="server" style="z-index: 1; left: 127px; top: 161px; position: absolute; height: 17px; width: 157px;"></asp:TextBox>
             <asp:TextBox ID="txtFName" runat="server" style="z-index: 1; left: 123px; top: 116px; position: absolute" OnTextChanged="txtFName_TextChanged"></asp:TextBox>
             <asp:TextBox ID="txtLName" runat="server" style="z-index: 1; left: 129px; top: 211px; position: absolute"></asp:TextBox>
             <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 130px; top: 271px; position: absolute"></asp:TextBox>
             <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 132px; top: 324px; position: absolute"></asp:TextBox>
             <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 135px; top: 371px; position: absolute"></asp:TextBox>
             <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 138px; top: 416px; position: absolute"></asp:TextBox>
           
            
        </asp:Panel>
    </form>
            <h1 class="auto-style1">
                Account Details
            </h1>
                </body>
</html>
