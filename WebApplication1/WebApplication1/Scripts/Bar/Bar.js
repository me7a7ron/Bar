function zamow() {
    var test1;
    var nazwa;
    var sztuk;
    for (var i = 0; i < $('#listapiw li').length; i++) {
        nazwa = $('#listapiw li')[i].textContent;
        sztuk = $("#" + $('#listapiw li')[i].textContent).val();
        if (test1 == null) {
            test1 = []
        }
        test1[i] = { "Nazwa": nazwa, "Sztuk": sztuk };
    }


    $.ajax({
        type: "POST",
        url: "/Bar/Wypij", // the URL of the controller action method
        //contentType: 'application/json',
        datatype: "json",
        data: { testy: JSON.stringify(test1) }, // optional data
        success: function (data) {
            $("#koszt").text(data[0]);
            $("#toast").text(data[1]);
        },
        error: function (req, status, error) {
            // do something with error
        }
    });
}

function rezerwuj() {
    var iloscOsob = $("#movie").val();
    $.ajax({
        type: "POST",
        url: "/Bar/Wypij", // the URL of the controller action method
        data: { "ilosc": iloscOsob }, // optional data
        success: function (data) {
            $("#koszt").text(data[0]);
            $("#toast").text(data[1]);
        },
        error: function (req, status, error) {
            // do something with error
        }
    });
    $("#KelnerMowi").css("display", "");
    $("#KelnerMowi").text("Co dla Pana");
}