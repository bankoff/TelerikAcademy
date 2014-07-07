var Field = (function () {
    var self = this;
    self.width = 800;
    self.height = 600;
    self.canvas = document.getElementById("snake");
    self.ctx = self.canvas.getContext("2d");
    self.cellWidth = 10;

    self.canvas.width = self.width;
    self.canvas.height = self.height;
    self.canvas.setAttribute('tabindex', 1);

    function drawCell(x, y, fill, stroke) {
        self.ctx.fillStyle = fill;
        self.ctx.fillRect(x * self.cellWidth, y * self.cellWidth, self.cellWidth, self.cellWidth);

        //add the stroke if it is defined
        if (typeof stroke !== "undefined") {
            self.ctx.strokeStyle = stroke;
            self.ctx.strokeRect(x * self.cellWidth, y * self.cellWidth, self.cellWidth, self.cellWidth);
        }
    }

    function drawScore() {
        self.ctx.fillStyle = "#999";
        self.ctx.font = "normal 10pt Calibri";
        self.ctx.fillText("score: " + (Snake.theSnake.length - Snake.initialLength), 10, self.height - 10);
    }

    function drawBackground() {
        self.ctx.fillStyle = "green";
        self.ctx.fillRect(0, 0, self.canvas.width, self.canvas.height);
    }

    return {
        width: self.width,
        height: self.height,
        canvas: self.canvas,
        ctx: self.ctx,
        cellWidth: self.cellWidth,
        drawCell: drawCell,
        drawScore: drawScore,
        drawBackground: drawBackground
    };
}());