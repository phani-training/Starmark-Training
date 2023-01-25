<%@ Page Title="" Language="C#" MasterPageFile="~/MainSheet.Master" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="SampleWebApp.Validation"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <script>
        function customValidation(sender, args) {
            if ((args.Value == "Trainer") || (args.Value == "Trainee"))
                args.IsValid = true;
            else {
                args.IsValid = false;
                alert("Trainer or Trainee is expected");
            }
        }
    </script>
    <div class="container">
        <div class="row">
            <div class="col-8">
                <h1 class="h1">
            Employee Validation Page
        </h1>
        <hr />
        <div>
            <p>
                Enter the Employee Name: 
                <asp:textbox runat="server" ID="txtName" />
                <asp:requiredfieldvalidator ControlToValidate="txtName" runat="server" errormessage="Name is mandatory" ForeColor="#FF3300"></asp:requiredfieldvalidator>
                <asp:CustomValidator  ID="CustomValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Name should be either Trainer or Trainee" ForeColor="#FF3300" OnServerValidate="CustomValidator1_ServerValidate" ClientValidationFunction="customValidation"></asp:CustomValidator>
            </p>
             <p>
                Enter the Employee Email: 
                <asp:textbox runat="server" ID="txtEmail" TextMode="Email" />
                <asp:requiredfieldvalidator runat="server" errormessage="Email is mandatory" ForeColor="#FF3300" ControlToValidate="txtEmail"></asp:requiredfieldvalidator>
                 <asp:regularexpressionvalidator runat="server" errormessage="Email is not in a proper format" ForeColor="red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail"></asp:regularexpressionvalidator>
            </p>
            <p>
                Enter the Password:
                <asp:textbox runat="server" ID="txtPwd" TextMode="Password" />
                 <asp:requiredfieldvalidator runat="server" errormessage="Password must be entered" ForeColor="#FF3300" ControlToValidate="txtPwd"></asp:requiredfieldvalidator>
            </p>
            <p>
                Retype the Password:
                <asp:textbox runat="server" ID="txtRetype" TextMode="Password" />
                <asp:comparevalidator runat="server" errormessage="Password Mismatch" ControlToCompare="txtPwd" ControlToValidate="txtRetype" ForeColor="#FF3300"></asp:comparevalidator>
            </p>
            <p>
                Enter the years of Experience:
                 <asp:textbox runat="server" ID="txtExperience" TextMode="Number" />
                <asp:rangevalidator errormessage="Experience should be b/w 3 to 10 years" controltovalidate="txtExperience" runat="server" MaximumValue="10" MinimumValue="3" Type="Integer" />
            </p>
            <p>
                <asp:button text="Submit" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click"/>
            </p>
            </div>
        </div>
            <div class="col-4">
                <asp:validationsummary runat="server" DisplayMode="List" ForeColor="#FF3300" HeaderText="List of Errors to Resolve:" ShowMessageBox="True"></asp:validationsummary>
                <asp:Label runat="server" ID="lblInfo" ForeColor="indianred" />
            </div>
        </div>
    </div>
</asp:Content>
