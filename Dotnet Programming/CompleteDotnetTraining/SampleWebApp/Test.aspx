<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="SampleWebApp.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rpTest" runat="server">
                <ItemTemplate>
                    <p style="background-color:aliceblue">Item: <%#Eval("Item")%></p>
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <p style="background-color:yellow">Item: <%#Eval("Item")%></p>
                </AlternatingItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
