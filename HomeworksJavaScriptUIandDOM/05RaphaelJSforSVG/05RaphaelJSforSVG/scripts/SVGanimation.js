setTimeout(function () { }, 1500);

var paper = Raphael('svg-container', 500, 500);

var rect = paper.rect(40, 50, 100, 50)
    .attr({
        x: 150,
        fill: 'yellow',
        stroke: 'purple',
        'stroke-width': 5,
    })
    .rotate(25, 150, 200)
    .animate({
        x: 450,
        fill: 'purple',
        width:50,
        callback:function() {
            rect.animate({
                x: 40,
                fill: 'yellow'
            },1000);
        }
    }, 1000);