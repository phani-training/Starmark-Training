<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="BookStoreApp.Web_Forms.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Edit Book</h1>
            <hr />
            <p>
                BookId:
                <asp:TextBox runat="server" Enabled="false" ID="txtBookId"/>
            </p>
            <p>
                Book Title:
                <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control"/>
            </p>
                        <p>
                Book Author:
                <asp:TextBox runat="server" ID="txtAuthor" CssClass="form-control"/>
            </p>
                        <p>
                Book Price:
                <asp:TextBox runat="server" ID="txtPrice" TextMode="Number" CssClass="form-control"/>
            </p>
            <p>
                <asp:Button Text="Update" runat="server" ID="btnSubmit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
            </p>
        </div>
    </form>
</body>
</html>
