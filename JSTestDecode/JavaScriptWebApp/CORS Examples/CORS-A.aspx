<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CORS-A.aspx.cs" Inherits="JavaScriptWebApp.CORS_iframePostMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script src="../Scripts/jquery-1.10.2.js"></script>
    <script>
        $(function () {
            $("#btnPost").click(function () {
                var value = $("#postToWCF").val();
                var jsonData = JSON.stringify(value);
                $.ajax({
                    url: "http://172.16.96.128/Service1.svc/postData",
                    type: "POST",
                    contentType: "application/json",
                    datatype: JSON,
                    data: jsonData,
                    success: function (response) {
                        console.log(response);
                    },
                    error: function (response) {
                    }
                });
            });

            //$("#triggerIframe").click(function () {
            //    console.log("where");
            //    $("#iframe").onload = function () {
            //        var win = $("#iframe").contentWindow;
            //        win.postMessage("Hello CORS", "*");
            //    };
            //});
        });

        function test() {
            var iframe = document.getElementById("iframe");
            var win = iframe.contentWindow;
            win.postMessage("Hello, CORS", "*");
        };



    </script>

</head>
<body>

    <iframe id="iframe" src="http://172.16.96.128/Web/iframe.html" onload="test()"></iframe>

    <input id="postToWCF" />
    <button id="btnPost" type="button"> trigger post</button>
    

    <input id="getToWCF" />
    <button id="btnget" type="button"> trigger get</button>

     <button id="triggerIframe" type="button"> trigger iframe</button>


</body>
</html>
