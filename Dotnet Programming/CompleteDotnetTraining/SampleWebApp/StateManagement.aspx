﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainSheet.Master" AutoEventWireup="true" CodeBehind="StateManagement.aspx.cs" Inherits="SampleWebApp.StateManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <style>
        .item{
            border:2px solid blue;
        }
    </style>
    <h1 class="h1">
        Server side state management using Sessions and Application State
    </h1>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <asp:Repeater runat="server" ID="rpProducts">
        <HeaderTemplate>
            <div>
                <h2>List of items with Us!!!!</h2>
                <hr />
        </HeaderTemplate>
        <ItemTemplate>
            <div class="row item">
                <div class="col-md-8">
                    <asp:Image ImageUrl=<%#Eval("Image")%> runat="server" />
                    <p>Price: <%#Eval("Price") %></p>
                    <p>
                    <asp:Button Text="Details" CommandName="Details" CommandArgument='<%#Eval("ProductId") %>' OnCommand="OnView_Command" runat="server" CssClass="btn btn-info"/>
                    </p>
                </div>
                <%--<div class="col-md-5">
                    <div>
                        <h2><%#Eval("ProductName") %></h2>
                    </div>
                    <hr />
                    <p>Product ID: <asp:Label Text='<%#Eval("ProductId") %>' runat="server" />
                        </p>
                    
                    <p>Quantity: <%#Eval("Quantity")%></p>
                </div>--%>

            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
            </div>
            <div class="col-md-5">
                <h2>Details of the selected Product</h2>
                <div>
                    Product ID: <asp:TextBox ID="txtProductId" runat="server" Enabled="false" CssClass="form-control" />
                </div>
                <div>
                    <asp:Image ID="imgSelected"  runat="server" Width="200px" Height="150px" />
                </div>
                <div>
                    ProductName:
                    <asp:TextBox ID="txtProductName" runat="server" Enabled="false" CssClass="form-control my-3" />
                </div>
                <div>
                    Product Cost:
                    <asp:TextBox ID="txtProductCost" runat="server" Enabled="false" CssClass="form-control my-3" />
                </div>
                <div>
                    Product Quantity:
                    <asp:TextBox runat="server" ID="txtQuantity" CssClass=" my-3 form-control" />   
                </div>
                <div>
                    <asp:Button Text="Add to Cart" runat="server" CssClass="btn btn-success my-3" OnClick="Unnamed1_Click" />
                    <asp:Button Text="Check out!!!" runat="server" CssClass="btn btn-secondary my-3" OnClick="Unnamed2_Click" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-10">
            <asp:DataList ID="lstRecentList" runat="server" RepeatColumns="5">
                <ItemTemplate>
                    <div>
                            <h2><%#Eval("ProductName")%></h2>
                            <asp:Image ImageUrl=<%#Eval("Image")%> runat="server" Width="100px" Height="100px" />
                            <p>Price: <%#Eval("Price") %></p>
                    </div>
                </ItemTemplate>
            </asp:DataList>
                </div>
        </div>
    </div>
</asp:Content>
