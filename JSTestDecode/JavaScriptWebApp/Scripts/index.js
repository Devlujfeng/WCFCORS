$(function () {

    $("#btnPost").on("click", function () {
        var dataJson = {
                "FirstName" :  $("#postToWCF").val()
        };
        var json = JSON.stringify(dataJson);
        $.ajax({
            url: "WebService/internalWCF.svc/getAllData2",
            type: 'POST',
            datatype: "json",
            data: json,
            contentType: "application/json",
            success: function (response) {
                console.log(response);
            },
            error: function (response) {
            }
        });
    });



    $("#btnget").on("click", function () {
        $.ajax({
            url: "WebService/internalWCF.svc/getData?name=" + $("#getToWCF").val(),
            type: "GET",
            datatype: "json",
            contentType: "application/json",
            success: function (response) {
                console.log(response);
            },
            error: function (response) {
            }
        });
    });

});





