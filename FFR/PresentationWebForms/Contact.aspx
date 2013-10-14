<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PresentationWebForms.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>

    <section class="contact">
        <header>
            <h3>Phone:</h3>
        </header>
        <p>
            <span class="label">Sales:</span>
            <span>303.123.4567</span>
        </p>
        <p>
            <span class="label">Support:</span>
            <span>303.123.4568</span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Email:</h3>
        </header>
        <p>
            <span class="label">Sales:</span>
            <span><a href="mailto:Sales@example.com">Sales@finishflashracing.com.com</a></span>
        </p>
        <p>
            <span class="label">Support:</span>
            <span><a href="mailto:Support@finishflashracing.com">Support@finishflashracing.com</a></span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Address:</h3>
        </header>
        <p>
            1234 E. Checkered Flag Way<br />
            Parker, CO 80134
        </p>
    </section>
</asp:Content>