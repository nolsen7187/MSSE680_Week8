﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminItemCategory.aspx.cs" Inherits="PresentationWebForms.AdminItemCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 60%; margin-right: 0px;">
        <tr>
            <td class="auto-style1">Employee First Name:</td>
            <td class="auto-style2">
                <asp:TextBox ID="CategoryTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Employee Last Name:</td>
            <td class="auto-style2">
                <asp:TextBox ID="DescriptionTextBox" runat="server" Width="275px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
        <asp:Button ID="CustomerButton" runat="server" OnClick="Button1_Click" Text="Register" />
            </td>
            <td class="auto-style2">
                <asp:Label ID="SuccessLabel" runat="server" ForeColor="Red" Width="275px"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
