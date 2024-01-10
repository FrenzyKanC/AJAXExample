// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    console.log("Page is ready!");

    // durch diesen Teil wird der RadioButton ein OneClickEvent (+IndexTeil)
    $(".customerRadio").change(function () {
        console.log("Radio button changed");
        doCustomerUpdate();
    });

    function doCustomerUpdate() {
        $.ajax({
            type: "POST",
            url: 'Customer/ShowOnePerson',
            // formatiert die seite
            data: $("form").serialize(),
            success: function (data) {
                console.log(data);
                $("#customerInformationArea").html(data);
            }
        });
    };

    $("#selectCustomer").click(function () {
        event.preventDefault();
        console.log("Kontrollnachricht: durch 'event.preventDefault();' wird das standard event des submit buttons geblockt.");
        doCustomerUpdate();
    });
});