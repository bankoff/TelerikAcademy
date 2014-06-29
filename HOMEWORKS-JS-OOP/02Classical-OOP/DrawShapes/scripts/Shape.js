var Shape = (function () {
    var theCanvas = document.getElementById("the-canvas");
    var canvasCtx = theCanvas.getContext("2d");

    function Shape(startPointX, startPointY) {
        this.startPointX = startPointX;
        this.startPointY = startPointY;
        this._canvasCtx = canvasCtx;
    }

    Shape.prototype.draw = function () {

        this._canvasCtx.beginPath();
        this._canvasCtx.lineWidth = "6";
        this._canvasCtx.strokeStyle = "red";
    };

    return Shape;
}());