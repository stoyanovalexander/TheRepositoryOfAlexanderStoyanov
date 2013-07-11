/// <reference path="online-map.js" />
/// <reference path="external/jquery-2.0.2.js" />
var Slider = {
    init: function () {
        _self = this;
        this.coords = [];
        this.slider = $('#slider');
    },
    addCoord: function (data) {
        data = data.split(',');
        this.coords.push({
            lat: +parseFloat($.trim(data[0])),
            lng: +parseFloat($.trim(data[1]))
        });
    },
    previous: function () {
        if (counter > 0) {
            onlineMap.goTo(
                _self.coords[counter].lat,
                _self.coords[counter].lng);
            counter -= 1;
        } else {
            counter = _self.coords.length - 1;
            onlineMap.goTo(
                _self.coords[counter].lat,
                _self.coords[counter].lng);
        }
    },
    next: function () {
        if (counter < _self.coords.length - 1) {
            onlineMap.goTo(
                _self.coords[counter].lat,
                _self.coords[counter].lng);
            counter += 1;
        } else {
            counter = 0;
            onlineMap.goTo(
                _self.coords[counter].lat,
                _self.coords[counter].lng);
        }

    },
    initButtons: function () {
        var prevButton = $("<button></button>");
        prevButton.attr('id', 'btn-prev');
        prevButton.on('click', this.previous);
        this.slider.prepend(prevButton);
        var nextButton = $("<button></button>");
        nextButton.attr('id', 'btn-next');
        nextButton.on('click', this.next);
        this.slider.append(nextButton);
    },
    render: function () {
        var wrapper = $('#wrapper');
        counter = 0;

        this.initButtons();
        google.maps.event.addDomListener(window, 'load', onlineMap.init());
    }
}