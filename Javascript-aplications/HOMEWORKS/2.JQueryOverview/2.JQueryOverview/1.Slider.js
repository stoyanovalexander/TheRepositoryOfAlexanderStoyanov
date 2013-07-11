(function($) {
    var Slider = {
        init: function (time) {
            _self = this;
            this.enlarged = 0;
            this.setOfSlides = [];
            this.time = time;
            this.slider = $('#slider');
        },

        addSlide: function (code) {
            this.setOfSlides.push(code);
        },

        previous: function(){
            clearInterval(auto);
            auto = setInterval(_self.tick, _self.time);
            if(crnt > 0) {
                current.hide();
                current = current.prev().show();
                crnt -= 1;
            } else {
                crnt = _self.setOfSlides.length - 1;
                current.hide();
                current = $('#slides').children().last();
                current.show();
            }
        },

        next: function(){
            clearInterval(auto);
            auto = setInterval(_self.tick, _self.time);
            if(crnt < _self.setOfSlides.length - 1) {
                current = current.next().show();
                current.prev().hide();
                crnt += 1;
            } else {
                crnt = 0;
                $('#slides').children().last().hide();
                current = $('#slides').children().first();
                current.show();
            }
           
        },

        tick: function() {
           _self.next();
        },
        initButtons: function() {
            var prevbtn = $("<button></button>");
            var nextbtn = $("<button></button>");
            prevbtn.attr('id', 'btn-prev');
            nextbtn.attr('id', 'btn-next');
            prevbtn.on('click', this.previous);
            nextbtn.on('click', this.next);
            this.slider.prepend(prevbtn);
            this.slider.append(nextbtn);
        },

        render: function () {
            this.slider.append('<div id="slides"></div>');
            var slides = $('#slides');
            for (var i = 0; i < this.setOfSlides.length; i++) {
                var slide = $('<div id="slide"></div>');
                slide.append($(this.setOfSlides[i])).hide();
                slides.append(slide);
            }
            slides.children().first().show();
            current = slides.children().first();
            crnt = 0;

            this.initButtons();

            auto = setInterval(this.tick, this.time);
        }
    }

    var slider = Object.create(Slider);
    slider.init(5000);

    slider.addSlide("<h1>THIS IS NOT A LIFE THIS IS HEAVEN</h1>");
    slider.addSlide('<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam rutrum enim et mi ultricies, a sagittis velit bibendum. Etiam vitae velit feugiat, tempus turpis quis, laoreet tellus. Aliquam sodales mi massa, in dictum enim aliquam ac. Cras accumsan justo vitae massa accumsan egestas. Sed bibendum, diam id rhoncus malesuada, nunc mauris ultricies ligula, id feugiat felis nunc quis nisi. Sed imperdiet id turpis blandit feugiat. Praesent tempor vestibulum consequat. Nunc at turpis odio. Ut semper pharetra lorem vel iaculis. Aliquam eget mi id felis hendrerit ullamcorper. Vivamus vehicula, eros id aliquam semper, nulla dui aliquam lorem, ac tempus magna libero interdum tortor. Proin tempor congue tincidunt. Pellentesque at tincidunt ligula, ut feugiat enim. Nam eleifend velit nec facilisis bibendum. Nulla tempus dictum lacus, nec tempor eros venenatis vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam rutrum enim et mi ultricies, a sagittis velit bibendum. Etiam vitae velit feugiat, tempus turpis quis, laoreet tellus. Aliquam sodales mi massa, in dictum enim aliquam ac. Cras accumsan justo vitae massa accumsan egestas. Sed bibendum, diam id rhoncus malesuada, nunc mauris ultricies ligula, id feugiat felis nunc quis nisi. Sed imperdiet id turpis blandit feugiat. Praesent tempor vestibulum consequat. Nunc at turpis odio. Ut semper pharetra lorem vel iaculis. Aliquam eget mi id felis hendrerit ullamcorper. Vivamus vehicula, eros id aliquam semper, nulla dui aliquam lorem, ac tempus magna libero interdum tortor. Proin tempor congue tincidunt. Pellentesque at tincidunt ligula, ut feugiat enim. Nam eleifend velit nec facilisis bibendum. Nulla tempus dictum lacus, nec tempor eros venenatis vel.</p>');
    slider.addSlide('<p>Siabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so onSiabonga Nomwete is the king of zamunda the master of game balls the man of mans hi felt down to the stairs every day with plesure and style and go to hospital to fix him self ad so on </p>')
    slider.render();
})(jQuery);