var Snake = (function () {
    var i;

    this.initialLength = 5;
    this.length = 5;

    function createSnake() {
        this.theSnake = [];
        for (i = length - 1; i >= 0; i--) {
            this.theSnake.push({ x: i, y: 0 });
        }
    }

    function drawSnake() {
        for (i = 0; i < this.theSnake.length; i++) {
            Field.drawCell(this.theSnake[i].x, this.theSnake[i].y, "yellow", "#333");
        }
    }

    function moveSnake() {
        //get the head coordnates and calculate the new head position
        var x = this.theSnake[0].x;
        var y = this.theSnake[0].y;
        var tail = this.theSnake.pop();

        this.direction = this.directionQueue;

        if (this.direction === "right") x++;
        else if (this.direction === "left") x--;
        else if (this.direction === "top") y--;
        else if (this.direction === "bottom") y++;

        //pop of the tail and make it the new head     
        tail.x = x;
        tail.y = y;
        this.theSnake.unshift(tail);
    }

    function changeDirection(keycode) {
        //if it is not in the oppisite direction set it to the queue
        if (keycode === 37 && this.direction !== "right") this.directionQueue = "left";
        else if (keycode === 38 && this.direction !== "bottom") this.directionQueue = "top";
        else if (keycode === 39 && this.direction !== "left") this.directionQueue = "right";
        else if (keycode === 40 && this.direction !== "top") this.directionQueue = "bottom";
    }

    return {
        theSnake: this.theSnake,
        initialLength: this.initialLength,
        direction: this.direction,
        directionQueue: this.directionQueue,
        createSnake: createSnake,
        drawSnake: drawSnake,
        moveSnake: moveSnake,
        changeDirection: changeDirection
    };
})();