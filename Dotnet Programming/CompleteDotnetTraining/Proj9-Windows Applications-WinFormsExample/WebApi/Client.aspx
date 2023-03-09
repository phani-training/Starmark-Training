<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="WebApi.Client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.8.3.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <script>
                function getData() {
                    $.ajax({  
                      type: "POST",  
                      url: '<%= ResolveUrl("~/Client.aspx/test") %>',  
                      data: '',  
                      contentType: "application/json; charset=utf-8",  
                      dataType: "json",  
                      success: function (response) {  
                          alert(response.d);  
                      },  
                  });  
                }
                //let url ="Client.aspx/test"
                window.addEventListener("load", function () {
                    getData();
                })
            </script>
        </div>
    </form>
</body>
</html>
