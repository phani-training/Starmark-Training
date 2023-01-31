<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Main.Master" AutoEventWireup="true" CodeBehind="RegisterPatient.aspx.cs" Inherits="HospitalSoftware.WebForms.RegisterPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Patient Registration Form</h1>
    <hr />
    <div class="container">
        <div class="row">
            <div class="col-md-10">
                <p>
                    PatientId: 
                    <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
                </p>
                <p>
                    PatientName: 
                    <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
                </p>
                <p>
                    Mobile No:
                    <asp:TextBox TextMode="Number" ID="txtMobile" CssClass="form-control" runat="server" />
                </p>
                <p>
                    Date of Birth:
                    <asp:TextBox TextMode="Date" ID="txtDob" CssClass="form-control" runat="server" />
                </p>
                <p>
                    DoctorName:
                    <asp:DropDownList runat="server" ID="dpDoctors" CssClass="form-control">
                    </asp:DropDownList>
                </p>
                <p>
                    <asp:Button Text="Register" runat="server" CssClass="btn btn-danger" />
                </p>
            </div>
        </div>
    </div>
</asp:Content>
