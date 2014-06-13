// Write a script that creates 5 div elements and moves them in circular path with interval of 100 milliseconds
window.onload = function () {

    var divs = document.querySelectorAll('.divRotate'),
        divLen = divs.length,
        i;

    for (i = 0 ; i < divLen; i++) {
        divs[i].style.position = 'absolute';
        divs[i].style.backgroundColor = 'green';
        divs[i].style.borderRadius = '50px';
        divs[i].style.width = '50px';
        divs[i].style.height = '50px';
        divs[i].style.display = 'block';
    }

    // rotation settings
    var angleOfRotation = 0, speed = 0.005, delay = 10, r = 200;

    (function rotate() {
        for (i = 0; i < divLen; i++) {
            var angleOfDiv = angleOfRotation + (i * 2 * Math.PI / divLen);

            divs[i].style.top = r + (Math.sin(angleOfDiv) * r) + 'px';
            divs[i].style.left = r + (Math.cos(angleOfDiv) * r) + 'px';
        }

        // increment our angle and use a modulo so we are always in the range [0..2*Math.PI]
        angleOfRotation = (angleOfRotation + speed) % (2 * Math.PI);

        // after a slight delay, call the same function again
        setTimeout(rotate, delay);
    })();
}();