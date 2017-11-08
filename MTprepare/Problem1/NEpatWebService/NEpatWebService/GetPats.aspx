<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetPats.aspx.cs" Inherits="NEpatWebService.GetPats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Get Pats over 250lbs"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Pats" />
        </p>
        <asp:TextBox ID="TextBox1" runat="server" Height="226px" TextMode="MultiLine" Width="437px"></asp:TextBox>
    </form>
</body>
</html>
