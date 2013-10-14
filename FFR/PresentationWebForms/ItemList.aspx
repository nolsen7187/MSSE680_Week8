<%@ Page Title="Items" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemList.aspx.cs" Inherits="PresentationWebForms.ItemList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Page.Title %></h1>
            </hgroup>

                 <section class="featured">
                    <ul> 
                        <asp:ListView ID="itemList" runat="server"
                            DataKeyNames="ItemId"
                            GroupItemCount="3" ItemType="PresentationWebForms.Models.Item" SelectMethod="GetItems">
                            <EmptyDataTemplate>      
                                <table id="Table1" runat="server">        
                                    <tr>          
                                        <td>No data was returned.</td>        
                                    </tr>     
                                </table>  
                            </EmptyDataTemplate>  
                            <EmptyItemTemplate>     
                                <td id="Td1" runat="server" />  
                            </EmptyItemTemplate>  
                            <GroupTemplate>    
                                <tr ID="itemPlaceholderContainer" runat="server">      
                                    <td ID="itemPlaceholder" runat="server"></td>    
                                </tr>  
                            </GroupTemplate>  
                            <ItemTemplate>    
                                <td id="Td2" runat="server">      
                                    <table>        
                                        <tr>          
                                            <td>&nbsp;</td>          
                                            <td>
                                                <a href="ItemDetails.aspx?ItemId=<%#:Item.ItemId%>"></a> 
                                            </td>
                                            <td>
                                                <a href="ItemDetails.aspx?ItemId=<%#:Item.ItemId%>">
                                                    <span class="ItemName">
                                                        <%#:Item.ItemName%>
                                                    </span>
                                                </a>            
                                                <br />
                                                <span class="ItemPrice">           
                                                    <b>Price: </b><%#:String.Format("{0:c}", Item.Price)%>
                                                </span>
                                                <br />            
                                            </td>        
                                        </tr>      
                                    </table>    
                                </td>  
                            </ItemTemplate>  
                            <LayoutTemplate>    
                                <table id="Table2" runat="server">      
                                    <tr id="Tr1" runat="server">        
                                        <td id="Td3" runat="server">          
                                            <table ID="groupPlaceholderContainer" runat="server">            
                                                <tr ID="groupPlaceholder" runat="server"></tr>          
                                            </table>        
                                        </td>      
                                    </tr>      
                                    <tr id="Tr2" runat="server"><td id="Td4" runat="server"></td></tr>    
                                </table>  
                            </LayoutTemplate>
                        </asp:ListView>
                    </ul>
               </section>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
