var map;
var geocoder;
var infowindow = new google.maps.InfoWindow();
var x = 42.692530;
var y = 23.321013;
var z = 7;

var onlineMap = {
    init: function () {
        var mapOptions = {
            zoom: z,
            center: new google.maps.LatLng(x, y),
            mapTypeId: google.maps.MapTypeId.ROADMAP,
        };
        map = new google.maps.Map(document.getElementById('map-canvas'),
            mapOptions);

        geocoder = new google.maps.Geocoder();
    },
    goTo: function (x, y) {
        var center = new google.maps.LatLng(x, y);
        map.setCenter(center);
        geocoder.geocode({ 'latLng': center }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                if (results[1]) {
                    map.setZoom(11);
                    marker = new google.maps.Marker({
                        position: center,
                        map: map
                    });
                    infowindow.setContent(results[1].formatted_address);
                    infowindow.open(map, marker);
                } else {
                    alert('No results found');
                }
            } else {
                alert('Geocoder failed due to: ' + status);
            }
        });
    },
}