<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccessWebService.aspx.cs" Inherits="AccessingWebService.AccessWebService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Phone Verification Lookup"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Enter Phone Number"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Verify" />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
