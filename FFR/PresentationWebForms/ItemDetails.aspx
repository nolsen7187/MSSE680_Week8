﻿<%@ Page Title="Item Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemDetails.aspx.cs" Inherits="PresentationWebForms.ItemDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <asp:FormView ID="itemDetails" runat="server" ItemType="DAL.Item" SelectMethod ="GetSingleItem" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ItemName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td style="vertical-align: top">
                        <b>Item Name:</b><br /><%#:Item.ItemName %>
                        <br />
                        <span><b>Item Number:</b>&nbsp;<%#:Item.ItemId %></span>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.Price) %></span>
                        <br />
                        <a href="/AddToCart.aspx?ItemId=<%#:Item.ItemId %>">               
                            <span class="ProductListItem">
                                <b>Add To Cart<b>
                            </span>           
                        </a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>