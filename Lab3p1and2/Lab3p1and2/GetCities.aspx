<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetCities.aspx.cs" Inherits="Lab3p1and2.GetCities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Zip Code<asp:TextBox ID="TextBox1" runat="server" Width="146px"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Cities For Zip Code" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get Cities NearbyZip " />
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Height="157px" TextMode="MultiLine" Width="385px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
