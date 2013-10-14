<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCustomer.aspx.cs" Inherits="WebApplication.RegisterCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 81px;
        }
    </style>
</head>
<body style="height: 497px">
    <form id="form1" runat="server">
    <div>
        <table style="width: 32%; margin-right: 0px;">
            <tr>
                <td class="auto-style1">First Name:</td>
                <td>
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Last Name:</td>
                <td>
                    <asp:TextBox ID="LastNameTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">City:</td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">State:</td>
                <td>
                    <asp:TextBox ID="StateTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Street:</td>
                <td>
                    <asp:TextBox ID="StreetTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Suite:</td>
                <td>
                    <asp:TextBox ID="SuiteTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Address:</td>
                <td>
                    <asp:TextBox ID="AddressTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Phone:</td>
                <td>
                    <asp:TextBox ID="PhoneTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email:</td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="CustomerButton" runat="server" OnClick="Button1_Click" Text="Register" />
    </div>
    </form>
</body>
</html>
