//canvas
var width = 800;
var height = 600;
var canvas = document.getElementById("snake");
canvas.width = width;
canvas.height = height;
canvas.setAttribute('tabindex', 1);
var ctx = canvas.getContext("2d");

//game vars
var fps = 1000 / 10;
var cell_width = 10;
var food = { x: 0, y: 0 };
var snake = [];
var length = 5;
var direction = 'right';
var direction_queue = 'right';

function create_snake() {
    snake = [];
    for (var i = length - 1; i >= 0; i--) {
        snake.push({ x: i, y: 0 });
    }
}

function create_food() {
    food.x = Math.floor(Math.random() * ((width / cell_width) - 1));
    food.y = Math.floor(Math.random() * ((height / cell_width) - 1));
    for (var i = 0; i++; i < snake.length) {
        if (check_collision(food.x, food.y, snake[i].x, snake[i].y))
            create_food();
    }
}

function paint_background() {
    ctx.fillStyle = "#333";
    ctx.fillRect(0, 0, canvas.width, canvas.height);
}

function paint_cell(x, y, fill, stroke) {
    ctx.fillStyle = fill;
    ctx.fillRect(x * cell_width, y * cell_width, cell_width, cell_width);
    //add the stroke if it is defined
    if (typeof stroke !== "undefined") {
        ctx.strokeStyle = stroke;
        ctx.strokeRect(x * cell_width, y * cell_width, cell_width, cell_width);
    }
}

function paint_food() {
    paint_cell(food.x, food.y, "#F02B49", "#333");
}

function paint_snake() {
    for (var i = 0; i < snake.length; i++) {
        paint_cell(snake[i].x, snake[i].y, "#999", "#333");
    }
}

function paint_score() {
    ctx.fillStyle = "#999";
    ctx.font = "normal 10pt Calibri";
    ctx.fillText("score: " + (snake.length - length), 10, height - 10);
}

function move_snake() {
    //get the head coordnates and calculate the new head position
    var x = snake[0].x;
    var y = snake[0].y;
    direction = direction_queue;
    if (direction == "right") x++;
    else if (direction == "left") x--;
    else if (direction == "top") y--;
    else if (direction == "bottom") y++;

    //pop of the tail and make it the new head
    var tail = snake.pop();
    tail.x = x;
    tail.y = y;
    snake.unshift(tail);
}

function change_direction(keycode) {
    //if it is not in the oppisite direction set it to the queue
    if (keycode == 37 && direction != "right") direction_queue = "left";
    else if (keycode == 38 && direction != "bottom") direction_queue = "top";
    else if (keycode == 39 && direction != "left") direction_queue = "right";
    else if (keycode == 40 && direction != "top") direction_queue = "bottom";
}

function check_collision(x1, y1, x2, y2) {
    if (x1 == x2 && y1 == y2)
        return true;
    else return false;
}

function game() {
    move_snake();

    var head = snake[0];

    //check for wall colliosions
    if (head.x < 0 || head.x == width / cell_width || head.y < 0 || head.y == height / cell_width) {
        new_game();
        return;
    }

    //if the head is hitting the body
    for (var i = 1; i < snake.length; i++) {
        if (head.x == snake[i].x && head.y == snake[i].y) {
            new_game();
            return;
        }
    }

    //if the snake is eating
    if (check_collision(head.x, head.y, food.x, food.y)) {
        snake[snake.length] = { x: head.x, y: head.y };
        create_food();
    }

    //paint
    ctx.beginPath();
    paint_background();
    paint_snake();
    paint_food();
    paint_score();
}

function new_game() {
    //default the direction
    direction = "right";
    direction_queue = "right";

    create_snake();
    create_food();

    canvas.onkeydown = function (evt) {
        evt = evt || window.event;
        change_direction(evt.keyCode);
    };

    //reset/set the game loop
    if (typeof loop !== "undefined")
        clearInterval(loop);
    loop = setInterval(game, fps);
}

new_game();