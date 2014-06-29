var Line = (function () {
    function Line(startPointX, startPointY, endPointX, endPointY) {
        Shape.call(this, startPointX, startPointY);
        this.endPointX = endPointX;
        this.endPointY = endPointY;
    }

    Line.prototype = new Shape();
    Line.prototype.constructor = Line;
    Line.prototype.draw = function () {
        Shape.prototype.draw.call(this);
        this._canvasCtx.moveTo(this.startPointX, this.startPointY);
        this._canvasCtx.lineTo(this.endPointX, this.endPointY);
        this._canvasCtx.stroke();
    };

    return Line;
}());