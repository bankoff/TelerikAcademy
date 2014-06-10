// Draw a circle that flies inside a box
// When it reaches an edge, it should bounce that edge

window.onload = function () {
    var theCanvas = document.getElementById("the-canvas");
    var canvasCtx = theCanvas.getContext("2d");


    function buildBall(x, y) {
        return {
            x: x,
            y: y
        };
    }

    var ball = {};
    ball.x = Math.floor(theCanvas.width / 2);
    ball.y = Math.floor(theCanvas.height / 2);
    ball.radius = 10;

    var down = +1;
    var rigth = +1;

    function animationFrame() {
        canvasCtx.clearRect(0, 0, theCanvas.width, theCanvas.height);
        //canvasCtx.fillStyle = '#FFFFFF';
        //canvasCtx.beginPath();
        //canvasCtx.arc(ball.x, ball.y, ball.radius+1, 0, 2 * Math.PI);
        //canvasCtx.fill();

        ball.x += rigth;
        ball.y += down;

        if (rigth == +1 && ball.x == theCanvas.width-ball.radius) {
            rigth = -1;
            ball.x += rigth;
        }

        if (down == +1 && ball.y == theCanvas.height-ball.radius) {
            down = -1;
            ball.y += down;
        }

        if (rigth == -1 && ball.x == ball.radius) {
            rigth = +1;
            ball.x += rigth;
        }

        if (down == -1 && ball.y == ball.radius) {
            down = +1;
            ball.y += down;
        }

        canvasCtx.fillStyle = '#FF0000';
        canvasCtx.beginPath();
        canvasCtx.arc(ball.x, ball.y, ball.radius, 0, 2 * Math.PI);
        canvasCtx.fill();
        requestAnimationFrame(animationFrame);
    }

    animationFrame();
}