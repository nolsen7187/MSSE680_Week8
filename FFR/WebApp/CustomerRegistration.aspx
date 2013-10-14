<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRegistration.aspx.cs" Inherits="WebApp.CustomerRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 153px;
        }
        .auto-style2
        {
            width: 394px;
        }
    </style>
</head>
<body style="height: 497px">
    <form id="form1" runat="server">
    <div>
        <table style="width: 60%; margin-right: 0px;">
            <tr>
                <td class="auto-style1">First Name:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Last Name:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="LastNameTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">City:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="CityTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">State:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="StateTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Street:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="StreetTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Zip:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="ZipTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Address:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="AddressTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Phone:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="PhoneTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="EmailTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="CustomerButton" runat="server" OnClick="Button1_Click" Text="Register" />
    </div>
    </form>
</body>
</html>
