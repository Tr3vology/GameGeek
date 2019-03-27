<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADescription.aspx.cs" Inherits="ASwap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Game Geek</title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Panel ID="Panel1" runat="server" 
            
            
        style="top: 115px; left: 160px; position: absolute; height: 621px; width: 1139px">
            <asp:Label ID="lblPictureName" runat="server" 
                style="z-index: 1; left: 250px; top: 33px; position: absolute; width: 279px" 
                Text="Picture File"></asp:Label>
            <asp:FileUpload ID="fupPicture" runat="server" 
                style="z-index: 1; left: 250px; top: 56px; position: absolute; width: 568px" />
            <asp:Button ID="btnSet" runat="server" 
                style="z-index: 1; left: 834px; top: 54px; position: absolute; width: 79px" 
                Text="Set" />
            <asp:Label ID="lblTitle" runat="server" 
                style="z-index: 1; left: 250px; top: 93px; position: absolute; width: 279px" 
                Text="Watch Brand"></asp:Label>
            <asp:TextBox ID="txtTitle" runat="server" 
                style="z-index: 1; left: 250px; top: 120px; position: absolute; width: 660px"></asp:TextBox>
            <asp:Label ID="lblDescription" runat="server" 
                style="z-index: 1; left: 250px; top: 151px; position: absolute; width: 279px" 
                Text="Watch Description"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server" 
                style="z-index: 1; left: 250px; top: 177px; position: absolute; width: 660px; height: 248px" 
                TextMode="MultiLine"></asp:TextBox>
            <asp:Button ID="btnSave" runat="server" 
                style="z-index: 1; left: 831px; top: 435px; position: absolute; width: 68px" 
                Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnDone" runat="server" 
                style="z-index: 1; left: 10px; top: 511px; position: absolute; width: 78px" 
                Text="Done" OnClick="btnDone_Click" />
            <asp:Image ID="img4" runat="server" ImageUrl="~/4.jpg" 
                style="z-index: 1; left: 21px; top: 22px; position: absolute; height: 252px; width: 213px;" />        
        
        
            <asp:Label ID="lblError" runat="server" ForeColor="Red" 
                
                
                style="z-index: 1; left: 94px; top: 513px; position: absolute; width: 842px"></asp:Label>
            
        </asp:Panel>
        </form>
</body>
</html>
