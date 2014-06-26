/// <reference path="jquery-2.1.1.min.js" />

// Using jQuery implement functionality to insert a DOM element before or after another element

$('#before').on('click', function () {
    $('.buttons').prepend('<div>Before</div>');
});

$('#after').on('click', function () {
    $('.buttons').append('<div>After</div>');
});