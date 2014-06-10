// Draw the following graphics using canvas

window.onload = function () {
    var theCanvas = document.getElementById("the-canvas");
    var canvasCtx = theCanvas.getContext("2d");

    human();
    bicycle();
    house();


    function house() {
        canvasCtx.beginPath();
        canvasCtx.fillStyle = '#975B5B';
        canvasCtx.strokeStyle = '#000000';
        canvasCtx.lineWidth = '3';
        canvasCtx.save();

        moveTo(500, 600);
        canvasCtx.lineTo(790, 600);
        canvasCtx.lineTo(790, 380);
        canvasCtx.lineTo(500, 380);
        canvasCtx.lineTo(500, 600);
        canvasCtx.fill();
        canvasCtx.closePath();
        canvasCtx.stroke();

        canvasCtx.beginPath();
        canvasCtx.moveTo(500, 380);
        canvasCtx.lineTo(645, 230);
        canvasCtx.lineTo(790, 380);
        canvasCtx.fill();
        canvasCtx.closePath();
        canvasCtx.stroke();

        canvasCtx.beginPath();
        canvasCtx.moveTo(735, 340);
        canvasCtx.lineTo(735, 260);
        canvasCtx.lineTo(705, 260);
        canvasCtx.lineTo(705, 340);
        canvasCtx.fill();
        canvasCtx.stroke();
        canvasCtx.save();

        canvasCtx.scale(1, 0.3);
        drawArcPath(720, 870, 15, 0, 2 * Math.PI);
        canvasCtx.restore();

        canvasCtx.beginPath();
        canvasCtx.moveTo(530, 600);
        canvasCtx.lineTo(530, 525);
        canvasCtx.bezierCurveTo(550, 500, 590, 500, 610, 525);
        canvasCtx.lineTo(610, 600);
        canvasCtx.moveTo(570, 600);
        canvasCtx.lineTo(570, 505);
        canvasCtx.stroke();

        canvasCtx.beginPath();
        canvasCtx.arc(558,565, 4, 0, 2 * Math.PI);
        canvasCtx.stroke();
        canvasCtx.beginPath();
        canvasCtx.arc(582, 565, 4, 0, 2 * Math.PI);
        canvasCtx.stroke();

        canvasCtx.fillStyle = '#000000';
        canvasCtx.beginPath();
        canvasCtx.moveTo(520, 480);
        canvasCtx.lineTo(623, 480);
        canvasCtx.lineTo(623, 413);
        canvasCtx.lineTo(520, 413);
        canvasCtx.closePath();
        canvasCtx.fill();

        canvasCtx.beginPath();
        canvasCtx.moveTo(667, 480);
        canvasCtx.lineTo(770, 480);
        canvasCtx.lineTo(770, 413);
        canvasCtx.lineTo(667, 413);
        canvasCtx.closePath();
        canvasCtx.fill();

        canvasCtx.moveTo(667, 570);
        canvasCtx.lineTo(770, 570);
        canvasCtx.lineTo(770, 503);
        canvasCtx.lineTo(667, 503);
        canvasCtx.closePath();
        canvasCtx.fill();

        canvasCtx.strokeStyle = '#975B5B';
        canvasCtx.beginPath();
        canvasCtx.moveTo(571, 410);
        canvasCtx.lineTo(571, 485);

        canvasCtx.moveTo(510, 445);
        canvasCtx.lineTo(780, 445);

        canvasCtx.moveTo(719, 590);
        canvasCtx.lineTo(719, 410);

        canvasCtx.moveTo(650, 537);
        canvasCtx.lineTo(780, 537);

        canvasCtx.stroke();
    }

    function bicycle() {
        canvasCtx.beginPath();
        canvasCtx.fillStyle = '#90CAD7';
        canvasCtx.strokeStyle = '#347F92';
        canvasCtx.lineWidth = '3';
        canvasCtx.save();

        drawArcPath(100, 500, 60, 0, 2 * Math.PI);
        drawArcPath(325, 500, 60, 0, 2 * Math.PI);
        canvasCtx.beginPath();
        canvasCtx.moveTo(100, 500);
        canvasCtx.lineTo(175, 425);
        canvasCtx.lineTo(310, 425);
        canvasCtx.lineTo(205, 498);
        canvasCtx.closePath();

        canvasCtx.moveTo(205, 498);
        canvasCtx.lineTo(160, 390);

        canvasCtx.moveTo(135, 390);
        canvasCtx.lineTo(185, 390);

        canvasCtx.moveTo(305, 380);
        canvasCtx.lineTo(325, 500);
        canvasCtx.moveTo(305, 380);
        canvasCtx.lineTo(255, 400);
        canvasCtx.moveTo(305, 380);
        canvasCtx.lineTo(335, 345);
        canvasCtx.stroke();

        canvasCtx.beginPath();
        canvasCtx.arc(205, 498, 17, 50 * Math.PI / 180, 230 * Math.PI / 180);
        canvasCtx.lineTo(185, 473);
        canvasCtx.arc(205, 498, 17, 230 * Math.PI / 180, 410 * Math.PI / 180);
        canvasCtx.lineTo(225, 523);
        canvasCtx.stroke();
    }

    function human() {
        canvasCtx.beginPath();
        canvasCtx.fillStyle = '#90CAD7';
        canvasCtx.strokeStyle = '#22545F';
        canvasCtx.lineWidth = '3';
        canvasCtx.save();
        canvasCtx.scale(1, 0.9);
        drawArcPath(85, 165, 65, 0, 2 * Math.PI);
        canvasCtx.restore();

        canvasCtx.save();
        canvasCtx.scale(1, 0.65);
        drawArcPath(50, 200, 10, 0, 2 * Math.PI);
        drawArcPath(100, 200, 10, 0, 2 * Math.PI);

        canvasCtx.beginPath();
        canvasCtx.moveTo(75, 200);
        canvasCtx.lineTo(60, 250);
        canvasCtx.lineTo(75, 250);
        canvasCtx.stroke();

        canvasCtx.fillStyle = '#22545F';
        canvasCtx.scale(0.35, 1);
        drawArcPath(135, 200, 7, 0, 2 * Math.PI);
        drawArcPath(278, 200, 7, 0, 2 * Math.PI);

        canvasCtx.restore();
        canvasCtx.save();

        canvasCtx.beginPath();
        canvasCtx.rotate(5 * Math.PI / 180);
        canvasCtx.scale(1, 0.3);
        canvasCtx.arc(90, 580, 25, 0, 2 * Math.PI);
        canvasCtx.lineWidth = '5';
        canvasCtx.stroke();

        canvasCtx.restore();
        canvasCtx.save();
        canvasCtx.beginPath();
        canvasCtx.fillStyle = '#396693';
        canvasCtx.strokeStyle = '#24201C';

        canvasCtx.scale(0.95, 0.2);
        drawArcPath(85, 490, 80, 0, 2 * Math.PI);
        canvasCtx.scale(1, 2);
        drawArcPath(90, 60, 40, 0, 2 * Math.PI);
        canvasCtx.lineTo(130, 215);
        canvasCtx.arc(90, 220, 40, 10 * Math.PI / 180, 190 * Math.PI / 180);
        canvasCtx.lineTo(50, 60);
        canvasCtx.fill();
        canvasCtx.stroke();
        canvasCtx.restore();
    }

    function drawArcPath(x, y, r, from, to, isCounterClockwise) {
        canvasCtx.beginPath();
        canvasCtx.arc(x, y, r, from, to, isCounterClockwise);
        canvasCtx.fill();
        canvasCtx.beginPath();
        canvasCtx.arc(x, y, r, 0, 2 * Math.PI);
        canvasCtx.stroke();
    }
};
