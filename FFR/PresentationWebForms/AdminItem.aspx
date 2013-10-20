<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminItem.aspx.cs" Inherits="PresentationWebForms.AdminItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .auto-style2
        {
            width: 394px;
        }
        .auto-style3
        {
            width: 534px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 91%; margin-right: 0px;">
        <tr>
            <td class="auto-style3">Item Name:</td>
            <td class="auto-style2">
                <asp:TextBox ID="ItemNameTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Item Category:(Must be an Integer Value)</td>
            <td class="auto-style2">
                <asp:TextBox ID="ItemCategoryTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Quantity Available:</td>
            <td class="auto-style2">
                <asp:TextBox ID="QtyAvailTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Item Cost:</td>
            <td class="auto-style2">
                <asp:TextBox ID="ItemCostTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Item Price:(Must be an Real Number with two decimals. EX. 19.99)</td>
            <td class="auto-style2">
                <asp:TextBox ID="ItemPriceTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
        <asp:Button ID="CustomerButton" runat="server" OnClick="Button1_Click" Text="Add Item" />
            </td>
            <td class="auto-style2">
                <asp:Label ID="SuccessLabel" runat="server" ForeColor="Red" Width="275px"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
