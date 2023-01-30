<%@ Page Title="" Language="C#" MasterPageFile="~/MainSheet.Master" AutoEventWireup="true" CodeBehind="BillingPage.aspx.cs" Inherits="SampleWebApp.BillingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-10">
                <h2>Billing of Items</h2>
                <hr />
                <asp:ListView ID="lstCart" runat="server">
                    <LayoutTemplate>
                        <table runat="server" border="1">
                            <tr runat="server">
                                <th runat="server">Product Id</th>
                                <th runat="server">Product Name</th>
                                <th runat="server">Product Price</th>
                                <th runat="server">Product Quantity</th>
                                <th runat="server">Total Price</th>
                            </tr>
                            <tr id="ItemPlaceHolder" runat="server" />
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("ProductId") %></td>
                            <td><%#Eval("ProductName") %></td>
                            <td><%#Eval("Price") %></td>
                            <td><%#Eval("Quantity") %></td>
                            <td><%#string.Format("{0:c}", Convert.ToInt32(Eval("Price")) * Convert.ToInt32(Eval("Quantity")))%></td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <div>
                <asp:Button Text="Order Now!!!" runat="server" OnClick="Unnamed1_Click" />
                <asp:Label Text="" runat="server" ID="lblMessage" />
            </div>
        </div>
    </div>
</asp:Content>
