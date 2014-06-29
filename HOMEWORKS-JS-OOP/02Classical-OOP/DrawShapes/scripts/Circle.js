var Circle = (function () {
    function Circle(startPointX, startPointY, radius) {
        Shape.call(this, startPointX, startPointY);
        this.radius = radius;
    }

    Circle.prototype = new Shape();
    Circle.prototype.constructor = Circle;
    Circle.prototype.draw = function () {
        Shape.prototype.draw.call(this);
        this._canvasCtx.arc(this.startPointX, this.startPointY, this.radius, 0, 2 * Math.PI, false);
        this._canvasCtx.stroke();
    };

    return Circle;
}());