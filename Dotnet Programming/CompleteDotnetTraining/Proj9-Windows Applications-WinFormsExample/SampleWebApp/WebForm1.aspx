<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SampleWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.6.3.js"></script>
    <script src="Scripts/Functions.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <script>
                window.addEventListener("load", () => {
                    testFunc();
                    const url = "api/Validate";
                    let obj = {};
                    obj.name = "phaniraj";
                    obj.password = "apple123";
                    $.post(url, obj, (data) => {
                        alert(data);
                    })
                })
            </script>
        </div>
    </form>
</body>
</html>
