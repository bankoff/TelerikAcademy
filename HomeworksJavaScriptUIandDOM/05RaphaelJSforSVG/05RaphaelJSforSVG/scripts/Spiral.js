window.onload = function () {
    var paper;
    paper = Raphael(50, 50, 500, 500);

    var centerX = 250,
        centerY = 250,
        radius = 10,
        angleOfRotation = 0;

    function drawPoint(cX, cY) {
        paper.circle(cX, cY, 1).attr({
            fill:'black'
        });
    }

    while (centerX > radius) {
        drawPoint(centerX + radius * Math.cos(angleOfRotation), centerY + radius * Math.sin(angleOfRotation));
        angleOfRotation += 0.01;
        radius += 0.1;
    }
};