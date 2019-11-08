$("#send").on("click", function () {
    var title = $("#title").val();
    var text = $("#text").val();
    var pathImage = $("#path").val();
    var request = { "Title": title, "Text": text, "PathImage": pathImage };
    $.ajax({
        url: "AddNews",
        type: "POST",
        dataType: "json",
        data: request,
        success: function (response) {
            console.log(response);
            $("p").css({
                "visibility": "visible"
            })
        }
    })
});

//$("#title")[0].value = "";
//$("#text").[0].value = "";
//$("#path").[0].value = "";