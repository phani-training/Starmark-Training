<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BookStoreApp.Web_Forms.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Create New Book</h1>
            <hr />
            <p>
                Enter the Book Title:
                <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control"/>
            </p>
                        <p>
                Enter the Book Author:
                <asp:TextBox runat="server" ID="txtAuthor" CssClass="form-control"/>
            </p>
                        <p>
                Enter the Book Price:
                <asp:TextBox runat="server" ID="txtPrice" TextMode="Number" CssClass="form-control"/>
            </p>
            <p>
                <asp:Button Text="Submit" runat="server" ID="btnSubmit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
            </p>
        </div>
    </form>
</body>
</html>
