var Food = (function () {
    var self = this,
        i;
    this.foodPosition = { x: 0, y: 0 };

    function createFood() {
        self.foodPosition.x = Math.floor(Math.random() * ((Field.width / Field.cellWidth) - 1));
        self.foodPosition.y = Math.floor(Math.random() * ((Field.height / Field.cellWidth) - 1));
        for (i = 0; i < Snake.theSnake.length; i++) {
            if (Game.checkForCollision(self.foodPosition.x, self.foodPosition.y, Snake.theSnake[i].x, Snake.theSnake[i].y)) {
                createFood();
            }
        }
    }

    function drawFood() {
        Field.drawCell(self.foodPosition.x, self.foodPosition.y, "#F02B49", "#333");
    }

    return {
        foodPosition: self.foodPosition,
        createFood: createFood,
        drawFood: drawFood
    };
}());