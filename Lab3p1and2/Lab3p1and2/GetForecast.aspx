<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetForecast.aspx.cs" Inherits="Lab3p1and2.GetForecast" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Get Weather Forecast For Boston</div>
        <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="Get Forecast" Width="109px" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="368px" TextMode="MultiLine" Width="851px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
