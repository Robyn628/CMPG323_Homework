<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="_34669205_Assessment2.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #FFFFCC">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            height: 39px;
        }
        .auto-style2 {
            text-decoration: underline;
        }
        .auto-style3 {
            height: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong><span class="auto-style2"><span style="font-family: 'Gill Sans MT'">Registration Page</span></span>&nbsp;&nbsp; <em>&nbsp;<br />
            <br />
            <br />
            </em></strong></div>
        <p style="height: 10px; font-family: 'Gill Sans MT';">
            Username:&nbsp;&nbsp;
            <asp:TextBox ID="txtbUser" runat="server"></asp:TextBox>
        </p>
        <p style="height: 12px; font-family: 'Gill Sans MT';">
            Password:&nbsp; &nbsp;
            <asp:TextBox ID="txtbPass" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p style="font-family: 'Gill Sans MT';" class="auto-style3">
            &nbsp;</p>
        <p>
&nbsp;
            <asp:Button ID="btnRegister" runat="server" Height="24px" Text="Register" Width="70px" Font-Names="Gill Sans MT" OnClick="btnRegister_Click" BackColor="#FF9933" BorderColor="#FF9933" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </em></strong>
            <asp:Label ID="lblError" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
