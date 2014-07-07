var Game = (function () {
    var i,
        loop,
        head;
    this.fps = 150;

    function checkForCollision(x1, y1, x2, y2) {
        if (x1 === x2 && y1 === y2)
            return true;
        else return false;
    }

    function startNewGame() {
        //default the direction
        Snake.direction = "right";
        Snake.directionQueue = "right";

        Snake.createSnake();
        Food.createFood();
        Field.drawScore();

        Field.canvas.onkeydown = function (evt) {
            evt = evt || window.event;
            Snake.changeDirection(evt.keyCode);
        };

        //reset/set the game loop
        if (typeof loop !== "undefined")
            clearInterval(loop);
        loop = setInterval(playGame, fps);
    }

    function playGame() {
        Snake.moveSnake();

        head = Snake.theSnake[0];

        //check for wall colliosions
        if (head.x < 0 || head.x === width / cellWidth || head.y < 0 || head.y === height / cellWidth) {
            startNewGame();
            return;
        }

        //if the head is hitting the body
        for (i = 1; i < Snake.theSnake.length; i++) {
            if (head.x == Snake.theSnake[i].x && head.y == Snake.theSnake[i].y) {
                startNewGame();
                return;
            }
        }

        //if the snake is eating
        if (Game.checkForCollision(head.x, head.y, Food.foodPosition.x, Food.foodPosition.y)) {
            Snake.theSnake[Snake.theSnake.length] = { x: head.x, y: head.y };
            Food.createFood();
        }

        //paint
        Field.ctx.beginPath();
        Field.drawBackground();
        Snake.drawSnake();
        Food.drawFood();
        Field.drawScore();
    }

    return {
        fps: fps,
        checkForCollision: checkForCollision,
        startNewGame: startNewGame,
        playGame: playGame
    };
}());