<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Consumer.aspx.cs" Inherits="Consumer" %>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <asp:Button CssClass="btn btn-primary" Text="Click To Invoke Server" runat="server" OnClick="Unnamed2_Click" />
    <asp:Label Text="" ID="lblMessage" runat="server" />

    <asp:GridView runat="server" ID="grDetails"></asp:GridView>
</asp:Content>    