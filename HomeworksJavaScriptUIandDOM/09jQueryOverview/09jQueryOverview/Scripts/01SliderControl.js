/// <reference path="jquery-2.1.1.min.js" />

//Create a slider control using jQuery
//The slider can have many slides
//Only one slide is visible at a time
//Each slide contains HTML code
//i.e. it can contain images, forms, divs, headers, links, etc…
//Implement functionality for changing the visible slide after 5 seconds
//Create buttons for next and previous slide
(function () {
    var slides = [
        '<h1>01 Slider Control</h1>',
        '<a href="http://telerikacademy.com/">Софтуерна академия</a> <p>Запишете се за нашите онлайн курсове с безплатен достъп до всички материали и видео уроци. Станете .NET нинджа!</p>',
        '<img src="./Images/omg-cat.gif"/>'
    ];

    var slideNumber = 0;

    var $divSlider = $('#slider'),
        $prevBtn = $('<button />'),
        $nextBtn = $('<button />'),
        $currentSlide = $('<div />');

    $prevBtn.attr('id', 'prev-button')
        .append('<');
    $nextBtn.attr('id', 'next-button')
        .append('>');
    $currentSlide.attr('id', 'current-slide');

    $divSlider.append($prevBtn)
        .append($nextBtn)
        .append($currentSlide);

    $('#slider').css('border', '1px solid black')
        .css('width', '800px')
        .css('height', '600px')
        .css('text-align', 'center');
    $('#current-slide').css('margin', '20px');

    setSlide();
    $('#prev-button').on('click', prevSlide);
    $('#next-button').on('click', nextSlide);

    function nextSlide() {
        slideNumber++;
        if (slideNumber === slides.length) {
            slideNumber = 0;
        }

        setSlide();
        resetTimer();
    }

    function prevSlide() {
        slideNumber--;
        if (slideNumber < 0) {
            slideNumber = slides.length - 1;
        }

        setSlide();
        resetTimer();
    }

    function setSlide() {
        var slide = slides[slideNumber];
        $('#current-slide').html(slide);
    }

    function resetTimer() {
        clearInterval(autoSlideChanger);
        autoSlideChanger = setInterval(nextSlide, 5000);
    }

    var autoSlideChanger = setInterval(nextSlide, 5000);


})();



