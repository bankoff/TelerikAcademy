window.onload = (function () {
    var drawRect = document.getElementById('draw-rect'),
        drawCircle= document.getElementById('draw-circle'),
        drawLine = document.getElementById('draw-line'),
        rect = new Rect(20, 20, 260, 160),
        circle = new Circle(300, 300, 60),
        line = new Line(100, 200, 200, 350);

    drawRect.addEventListener('click', function () { rect.draw(); });
    drawCircle.addEventListener('click', function () { circle.draw(); });
    drawLine.addEventListener('click', function () { line.draw(); });
}());