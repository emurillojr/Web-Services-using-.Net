<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherInfoBoston.aspx.cs" Inherits="WebServiceGetHTTPCalls.WeatherInfoBoston" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Find Weather in Boston" Width="152px" />
        </div>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" Height="97px" TextMode="MultiLine" Width="310px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
