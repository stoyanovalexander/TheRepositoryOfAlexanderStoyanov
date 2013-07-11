var Image = {
    init: function (title, tumbUrl, url) {
        this.title = title;
        this.tumbUrl = tumbUrl;
        this.url = url;
    }
}

var Slider = {
    init: function () {
        _self = this;
        this.enlarged = 0;
        this.setOfImages = [];
    },
    addImage: function (image) {
        this.setOfImages.push(image);
    },
    previous: function(){
        this.enlarged--;

        if (this.enlarged < 0) {
            this.enlarged = this.setOfImages.length - 1;
        }

        $('#enlarged').attr('src', _self.setOfImages[_self.enlarged].url);
    },
    next: function(){
        this.enlarged++;

        if (this.enlarged >= this.setOfImages.length) {
            this.enlarged = 0;
        }

        $('#enlarged').attr('src', _self.setOfImages[_self.enlarged].url);
    },
    render: function () {
        $('#slider').append('<div id="gallery"></div>');
        $('#slider').css('text-align', 'center');

        for (var i = 0; i < this.setOfImages.length; i++) {
            $('#gallery').append('<img src="' + this.setOfImages[i].tumbUrl + '" id="' + i + '" />');
        }

        $("#slider img").hover(
            function () {
                $(this).css('margin', '5px').css('border', '3px solid white').css('cursor', 'pointer');
            },
            function () {
                $(this).css('margin', '5px').css('border', '3px solid grey');
            });

        $('#slider').append('<div id="buttons"></div>');
        $('#buttons').append('<div id="previous"><</div>');
        $('#buttons').append('<div id="next">></div>');

        $('#next, #previous').css('display', 'inline-block').css('color', 'white').css('margin', '10px').css('border', '3px solid grey')
            .css('font-size', '25px').css('border-radius', '50px').css('padding', '10px 15px').css('font-weigth', 'bold');

        $('#next, #previous').hover(
            function () {
                $(this).css('border', '3px solid white').css('cursor', 'pointer');
            },
            function () {
                $(this).css('border', '3px solid grey');
            });

        $('#next').on('click', function () {
            _self.next();
        });

        $('#previous').on('click', function () {
            _self.previous();
        });

        $('#slider').append('<div id="image"></div>');
        $('#image').append('<img src="' + this.setOfImages[this.enlarged].url + '" id="enlarged" />');

        $("#slider img").css('margin', '5px').css('border', '3px solid grey');

        $('#slider img').on('click', function () {
            _self.enlarged = this.id;
            $('#enlarged').attr('src', _self.setOfImages[_self.enlarged].url);
        });
    }
}

var image1 = Object.create(Image);
image1.init("SC2 Image", "images/1t.jpg", "images/1.jpg");
var image2 = Object.create(Image);
image2.init("SC2 Image", "images/2t.jpg", "images/2.jpg");
var image3 = Object.create(Image);
image3.init("SC2 Image", "images/3t.jpg", "images/3.jpg");
var image4 = Object.create(Image);
image4.init("SC2 Image", "images/4t.jpg", "images/4.jpg");
var image5 = Object.create(Image);
image5.init("SC2 Image", "images/5t.jpg", "images/5.jpg");
var image6 = Object.create(Image);
image6.init("SC2 Image", "images/6t.jpg", "images/6.jpg");


var slider = Object.create(Slider);
slider.init();
slider.addImage(image1);
slider.addImage(image2);
slider.addImage(image3);
slider.addImage(image4);
slider.addImage(image5);
slider.addImage(image6);
slider.render();