<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Workshop.aspx.cs" Inherits="_34669205_Assessment2.Workshop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #CCFFFF">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: small;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            width: 270px;
        }
        .auto-style4 {
            width: 237px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="auto-style2"><strong style="font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif">Welcome&nbsp;&nbsp;<asp:Label ID="lblWelcomeUser" runat="server" Text="Username!"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Log Out" BackColor="Red" BorderColor="Red" />
            </strong></span><br />
            <br />
            <strong style="font-family: 'Felix Titling'; font-size: x-small;"><span class="auto-style1">Please indicate your preferred date for a programming </span>
            <br class="auto-style1" />
            <span class="auto-style1">workshop below.</span></strong><br />
            <br />
            Here is your current date and selected programming language (if any):&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="color: #000000"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:GridView ID="GridView" runat="server" CellPadding="4" ForeColor="#333333" Height="71px" Width="286px" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            To indicate a new preferred date, choose one on the calendar below:<br />
&nbsp;<table style="width:100%;">
                <tr>
                    <td class="auto-style3">
                        <asp:Calendar ID="Calendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="273px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                    <td class="auto-style4">
                        &nbsp;&nbsp;
                        <asp:RadioButton ID="rbtnJava" runat="server" GroupName="CompLang" Text="Java" />
                        <br />
                        <br />
&nbsp;
                        <asp:RadioButton ID="rbtnCSharp" runat="server" GroupName="CompLang" Text="CSharp" />
                        <br />
                        <br />
&nbsp;
                        <asp:RadioButton ID="rbtnCPP" runat="server" GroupName="CompLang" Text="CPP" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Image ID="imgWorkshop" runat="server" Height="176px" ImageUrl="~/workshop.png" Visible="False" Width="212px" />
                        <br />
            <asp:Label ID="lblThankYou" runat="server" ForeColor="Black" style="color: #000000" Font-Names="Berlin Sans FB Demi" Visible="False">Thank you for confirming your date with us!</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <br />
        <asp:Button ID="btnConfirm" runat="server" Text="Confirm date" OnClick="btnConfirm_Click" BackColor="#00CC00" BorderColor="#00CC00" />
    </form>
</body>
</html>
