/// <reference path="jquery-2.1.1.min.js" />

//Implement functionality to change the background color of a web page
//i.e. select a color from a color picker and set this color as the background color of the page
$('#select-color').on('change', function () {
    var color = $('#select-color').val();
    $('body').css('background', color);
});