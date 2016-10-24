﻿
function Initialize() { 
 
    // Google has tweaked their interface somewhat - this tells the api to use that new UI 
    google.maps.visualRefresh = true; 
    var Tunisie = new google.maps.LatLng(36.81881, 10.16596); 
 
    // These are options that set initial zoom level, where the map is centered globally to start, and the type of map to show 
    var mapOptions = { 
        zoom: 8, 
        center: Tunisie, 
        mapTypeId: google.maps.MapTypeId.G_NORMAL_MAP 
    }; 
 
    // This makes the div with id "map_canvas" a google map 
    var map = new google.maps.Map(document.getElementById("map_canvas"), mapOptions); 
    var data = [
              { "Id": 1, "PlaceName": "Zaghouan", "GeoLong": "36.401081", "GeoLat": "10.16596" }, 
              { "Id": 2, "PlaceName": "Hammamet ", "GeoLong": "36.4", "GeoLat": "10.616667" }, 
              { "Id": 3, "PlaceName": "Sousse", "GeoLong": "35.8329809", "GeoLat": "10.63875" }, 
              { "Id": 4, "PlaceName": "Sfax", "GeoLong": "34.745159", "GeoLat": "10.7613" } 
    ]; 
 
    // Using the JQuery "each" selector to iterate through the JSON list and drop marker pins 
    $.each(data, function (i, item) { 
        var marker = new google.maps.Marker({ 
            'position': new google.maps.LatLng(item.GeoLong, item.GeoLat), 
            'map': map, 
            'title': item.PlaceName 
        }); 
 
        // Make the marker-pin blue! 
        marker.setIcon('http://maps.google.com/mapfiles/ms/icons/blue-dot.png') 
 
        // put in some information about each json object - in this case, the opening hours. 
        var infowindow = new google.maps.InfoWindow({ 
            content: "<div class='infoDiv'><h2>" + item.PlaceName + "</div></div>" 
        }); 
 
        // finally hook up an "OnClick" listener to the map so it pops up out info-window when the marker-pin is clicked! 
        google.maps.event.addListener(marker, 'click', function () { 
            infowindow.open(map, marker); 
        }); 
 
    }) 
} 
 