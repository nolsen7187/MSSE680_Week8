<%@ Page Title="Adminstrative Actions" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="PresentationWebForms.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Page.Title %></h1>
            </hgroup>
                 <section class="featured">
                    <br />
                        <a href="/EmployeeRegistration.aspx">Employee Registration</a>
                        <br />
                        <a href="/AdminItemCategory.aspx">Item Category Maintenance</a>
                     <br />
                        <a href="/AdminItem.aspx">Item Maintenance</a>
                     <br />
                   <br />
                 </section>            
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
