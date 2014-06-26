$.fn.gallery = function (param) {
    var $gallery = this;
    var imagesOnRow = param || 4;
    var galleryWidth = imagesOnRow * 260 + 'px';

    $gallery.addClass('gallery');
    $gallery.find('.gallery-list').css("width", galleryWidth);
    $gallery.find('.selected').hide();

    $gallery.find('.image-container')
		.on('click', function (ev) {
		    var $this = $(this);

		    var $selectImgDataInfo = $this.find('img').attr('data-info');

		    var prevImg = $selectImgDataInfo * 1 - 1,
                currImg = $selectImgDataInfo,
                nextImg = $selectImgDataInfo * 1 + 1;

            if (currImg === '1') {
                prevImg = 12;
            }
            if (currImg === '12') {
                nextImg = 1;
            }

            $gallery.find('.selected').find('.previous-image').find('#previous-image').attr('src', 'imgs/' + prevImg + '.jpg').attr('data-info',prevImg);

            $gallery.find('.selected').find('.current-image').find('#current-image').attr('src', 'imgs/' + currImg + '.jpg').attr('data-info', currImg);

            $gallery.find('.selected').find('.next-image').find('#next-image').attr('src', 'imgs/' + nextImg + '.jpg').attr('data-info', nextImg);

		    $gallery.find('.gallery-list').addClass('blurred');

		    $gallery.find('.selected').show();
		});

    $gallery.find('.previous-image')
        .on('click', function(ev) {
            var $this = $(this);

            var $selectImgDataInfo = $this.find('img').attr('data-info');

            var prevImg = $selectImgDataInfo * 1 - 1,
                currImg = $selectImgDataInfo,
                nextImg = $selectImgDataInfo * 1 + 1;

            if (currImg === '1') {
                prevImg = 12;
            }
            if (currImg === '12') {
                nextImg = 1;
            }

            $gallery.find('.selected').find('.previous-image').find('#previous-image').attr('src', 'imgs/' + prevImg + '.jpg').attr('data-info', prevImg);

            $gallery.find('.selected').find('.current-image').find('#current-image').attr('src', 'imgs/' + currImg + '.jpg').attr('data-info', currImg);

            $gallery.find('.selected').find('.next-image').find('#next-image').attr('src', 'imgs/' + nextImg + '.jpg').attr('data-info', nextImg);
        });

    $gallery.find('.next-image')
       .on('click', function (ev) {
           var $this = $(this);

           var $selectImgDataInfo = $this.find('img').attr('data-info');

           var prevImg = $selectImgDataInfo * 1 - 1,
               currImg = $selectImgDataInfo,
               nextImg = $selectImgDataInfo * 1 + 1;

           if (currImg === '1') {
               prevImg = 12;
           }
           if (currImg === '12') {
               nextImg = 1;
           }

           $gallery.find('.selected').find('.previous-image').find('#previous-image').attr('src', 'imgs/' + prevImg + '.jpg').attr('data-info', prevImg);

           $gallery.find('.selected').find('.current-image').find('#current-image').attr('src', 'imgs/' + currImg + '.jpg').attr('data-info', currImg);

           $gallery.find('.selected').find('.next-image').find('#next-image').attr('src', 'imgs/' + nextImg + '.jpg').attr('data-info', nextImg);
       });

    $gallery.find('.current-image')
       .on('click', function (ev) {
           $gallery.find('.gallery-list').removeClass('blurred');
           $gallery.find('.selected').hide();
       });
};