<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_34669205_Assessment2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #CCFFCC">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 25px">
            <strong><span class="auto-style1"><em>Welcome to login screen</em></span></strong><br />
        </div>
        <p style="height: 6px">
            Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtbUsername" runat="server" Width="151px"></asp:TextBox>
        </p>
        <p>
            Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtbPassword" runat="server" Width="151px" TextMode="Password"></asp:TextBox>
        </p>
        <asp:CheckBox ID="cbxRemeber" runat="server" Text="Remember me" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblIncorrect" runat="server" Text="???????????????"></asp:Label>
        <br />
        <br />
        <br />
        <asp:HyperLink ID="hlRegister" runat="server" NavigateUrl="~/Register.aspx">Click here to register...</asp:HyperLink>
    </form>
</body>
</html>
