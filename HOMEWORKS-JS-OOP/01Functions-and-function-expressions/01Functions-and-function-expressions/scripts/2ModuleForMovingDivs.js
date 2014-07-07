var movingShapes = (function () {
    function add(shape) {
        var divElement,
            wrapper,
            centerX,
            centerY,
            radiusA,
            radiusB,
            angle,
            leftPosition,
            topPosition,
            left,
            top,
            right,
            bottom,
            direction;


        divElement = document.createElement('div');

        divElement.style.width = '40px';
        divElement.style.height = '20px';
        divElement.style.backgroundColor = '#ffff33';
        divElement.style.border = '5px solid blue';
        divElement.style.textAlign = 'center';
        divElement.style.position = 'absolute';

        wrapper = document.getElementById('wrapper');
        wrapper.appendChild(divElement);

        if (shape == 'ellipse') {
            centerX = 300;
            centerY = 350;
            radiusA = 200;
            radiusB = 100;

            angle = 0;

            setInterval(function moveDivs() {
                angle += 0.5;
                if (angle === 360) {
                    angle = 0;
                }

                leftPosition = centerX + Math.cos((2 * 3.14 / 180) * (angle)) * radiusA;
                topPosition = centerY + Math.sin((2 * 3.14 / 180) * (angle)) * radiusB;

                divElement.innerHTML = 'ellipse';
                divElement.style.left = leftPosition + 'px';
                divElement.style.top = topPosition + 'px';
            }, 20);
        }
        else if (shape == 'rect') {
            left = 100;
            top = 100;
            leftPosition = left;
            topPosition = top;
            right = 600;
            bottom = 200;
            direction = 0;

            setInterval(function moveDivs() {
                if (direction > 3) {
                    direction = 0;
                }

                switch (direction) {
                    case 0: leftPosition += 3;
                        if (leftPosition >= right) {
                            direction++;
                        }
                        break;
                    case 1: topPosition += 3;
                        if (topPosition >= bottom) {
                            direction++;
                        }
                        break;
                    case 2: leftPosition -= 3;
                        if (leftPosition <= left) {
                            direction++;
                        }
                        break;
                    case 3: topPosition -= 3;
                        if (topPosition <= top) {
                            direction++;
                        }
                        break;
                }

                divElement.innerHTML = 'rect';
                divElement.style.left = leftPosition + 'px';
                divElement.style.top = topPosition + 'px';
            }, 20);
        }

    }

    return {
        add: add
    };

})();