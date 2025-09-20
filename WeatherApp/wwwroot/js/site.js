// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(document).ready(function () {
    function search(event) {
        console.log("search() called");
        event.preventDefault();

        jQuery.ajax({
            type: "GET",
            url: "/Weather/MyJson",
            data: {city: jQuery('#SearchBox').val().trim()},
            dataType: "json",
            success: function (response) {
                console.log("AJAX success", response.timelines);
                if (response) {
                    jQuery('#WeatherLocation').text("Weather in " + response.location.name.split(",")[0]);
                    jQuery('#tempDay0').text(response.timelines.hourly[0].values.temperature + "°C");
                    jQuery('#windspeedDay0').text("Windspeed: " + response.timelines.hourly[0].values.windSpeed + " m/s");
                    jQuery('#humidityDay0').text("Humidity: " + response.timelines.hourly[0].values.humidity + "%");

                    jQuery('#tempDay3').text(response.timelines.hourly[72].values.temperature + "°C");
                    jQuery('#windspeedDay3').text("Windspeed: " + response.timelines.hourly[72].values.windSpeed + " m/s");
                    jQuery('#humidityDay3').text("Humidity: " + response.timelines.hourly[72].values.humidity + "%");

                    jQuery('#tempDay5').text(response.timelines.hourly[119].values.temperature + "°C");
                    jQuery('#windspeedDay5').text("Windspeed: " + response.timelines.hourly[119].values.windSpeed + " m/s");
                    jQuery('#humidityDay5').text("Humidity: " + response.timelines.hourly[119].values.humidity + "%");  
                } else {
                    alert("Something went wrong");
                }
            },
            error: function (xhr) {
                alert("Error: " + xhr.responseText);
            }
        });
    }

    $("#SearchForm").on("submit", search);
});

