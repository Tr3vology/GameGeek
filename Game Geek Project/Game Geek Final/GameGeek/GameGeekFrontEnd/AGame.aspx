<%@ Page Title="" Language="C#" MasterPageFile="~/GameGeek.master" AutoEventWireup="true" CodeFile="AGame.aspx.cs" Inherits="AGame" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:TextBox ID="txtTitle" runat="server" Width="127px" ></asp:TextBox>
            <br />
            Console&nbsp;<asp:TextBox ID="txtConsole" runat="server" ></asp:TextBox>
            <br />
            &nbsp;<asp:DropDownList ID="ddlDeveloper" runat="server" style="z-index: 1; " Height="32px"></asp:DropDownList>
            <br />
            &nbsp;<br />
            Developer&nbsp;<br />
            &nbsp;<br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1;" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="61px" OnClick="btnCancel_Click" />

</asp:Content>