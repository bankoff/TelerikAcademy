var Rect = (function () {
    function Rect(startPointX, startPointY, width, height) {
        Shape.call(this, startPointX, startPointY);
        this.width = width;
        this.height = height;
    }

    Rect.prototype = new Shape();
    Rect.prototype.constructor = Rect;
    Rect.prototype.draw = function () {
        Shape.prototype.draw.call(this);
        this._canvasCtx.rect(this.startPointX, this.startPointY, this.width, this.height);
        this._canvasCtx.stroke();
    };

    return Rect;
}());