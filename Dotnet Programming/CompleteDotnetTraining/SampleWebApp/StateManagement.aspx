<%@ Page Title="" Language="C#" MasterPageFile="~/MainSheet.Master" AutoEventWireup="true" CodeBehind="StateManagement.aspx.cs" Inherits="SampleWebApp.StateManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <style>
        .item{
            border:2px solid blue;
        }
    </style>
    <h1 class="h1">
        Server side state management using Sessions and Application State
    </h1>
    <asp:Repeater runat="server" ID="rpProducts">
        <HeaderTemplate>
            <div>
                <h2>List of items with Us!!!!</h2>
                <hr />
        </HeaderTemplate>
        <ItemTemplate>
            <div class="row item">
                <div class="col-md-6">
                    <asp:Image ImageUrl=<%#Eval("Image")%> runat="server" />
                </div>
                <div class="col-md-6">
                    <div>
                        <h2><%#Eval("ProductName") %></h2>
                    </div>
                    <hr />
                    <p>Product ID: <%#Eval("ProductId") %></p>
                    <p>Price: <%#Eval("Price") %></p>
                    <p>Quantity: <%#Eval("Quantity")%></p>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
