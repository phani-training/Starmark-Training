<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Main.Master" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="HospitalSoftware.WebForms.Billing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container">
        <div class="row">
            Enter the Patient ID:
            <asp:TextBox runat="server" ID="txtPatientId" CssClass="form-control" />
            <asp:Button Text="Fetch" ID="btnFetch" CssClass="btn btn-secondary" runat="server" />
        </div>
        <div class="row">
            <h2>Billing Details</h2>
            <hr />
            <div class="container">
                <div class="row">
                    <div class="col-md-8">
                        Bill No:
                        <asp:TextBox runat="server" Width="300px" ID="txtBillNo" Enabled="false" CssClass="form-control" />
                    </div>
                    <div class="col-md-3 mx-2">
                        Bill Date: 
                        <asp:TextBox CssClass="form-control" Width="200px" runat="server" ID="txtDate" TextMode="Date" Enabled="false" />
                    </div>
                </div>
            </div>
            <p>
                PatientName: 
                    <asp:TextBox Enabled="false" runat="server" ID="txtName" CssClass="form-control" />
            </p>
            <p>
                Mobile No:
                    <asp:TextBox Enabled="false" TextMode="Number" ID="txtMobile" CssClass="form-control" runat="server" />
            </p>
            <p>
                Doctor Name: 
                <asp:TextBox runat="server" ID="txtDoctor" Enabled="false" CssClass="form-control" />
            </p>
            <p>
                Bill Amount: 
                <asp:TextBox runat="server" ID="txtAmount" CssClass="form-control" Enabled="false" />
            </p>
            <p>
                <asp:Button Text="Generate Bill" runat="server" ID="btnBill" CssClass="btn btn-info" />
            </p>
        </div>

    </div>
</asp:Content>
