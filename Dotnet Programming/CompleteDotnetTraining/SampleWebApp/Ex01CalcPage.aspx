<%@ Page Language="C#" MasterPageFile="~/MainSheet.Master" AutoEventWireup="true" CodeBehind="Ex01CalcPage.aspx.cs" Inherits="SampleWebApp.Ex01CalcPage" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
<div style="background-color: #999966">
    <div>
        <h1>Calc Program</h1>
        <hr />
        <p>
            Enter the First Value: 
                <asp:TextBox runat="server" ID="txtFirstNo" />
        </p>
        <p>
            Select the Option: 
                <asp:DropDownList runat="server" ID="dpList">
                    <asp:ListItem Text="Add" />
                    <asp:ListItem Text="Subtract" />
                    <asp:ListItem Text="Multiply" />
                    <asp:ListItem Text="Divide" />
                </asp:DropDownList>
        </p>
        <p>
            Enter the Second Value: 
                <asp:TextBox runat="server" ID="txtSecondNo" />
        </p>
        <p>
            <asp:Button Text="Get Result" runat="server" ID="btnResult" OnClick="btnResult_Click" />
        </p>
        <p>
            <asp:Label Text="The Result: " ID="lblDisplay" runat="server" />
        </p>
    </div>
</div>

</asp:Content>
