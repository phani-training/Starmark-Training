<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookStoreApp.aspx.cs" Inherits="BookStoreApp.Web_Forms.BookStoreApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <h1 class="h1">Book Store Application</h1>
    <hr />
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <nav>
                    <asp:HyperLink Text="Add New Book" NavigateUrl="~/Web Forms/AddBook.aspx" runat="server" />
                </nav>
            </div>
            <div class="row">
                <div class="col-md-8">
                    <asp:GridView runat="server" ID="grdBooks" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="233px" Width="611px">
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                        <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="BookId" DataNavigateUrlFormatString="~/Web Forms/Details.aspx?BookId={0}" Text="Edit" HeaderText="Options" >
                            <ControlStyle CssClass="btn btn-danger" />
                            </asp:HyperLinkField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
        <div class="text-danger">
            <asp:Label runat="server" ID="lblError" ForeColor="#FF5050"/>
        </div>
    </form>
</body>
</html>
