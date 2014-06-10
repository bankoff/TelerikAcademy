var svgNS = 'http://www.w3.org/2000/svg',
    svg = document.createElementNS(svgNS, 'svg');
svg.setAttribute('width', '800');
svg.setAttribute('height', '600');
document.body.appendChild(svg);

var circlesCount = 4,
    circlesCenterX = 200,
    textPositionX = 100,
    positionY = 100,
    radius = 60,
    fontSize = '40px',
    colors = ['grey', 'black', 'red', 'yellowgreen', 'green'],
    word = ['MEAN', 'express'],
    svgimg = document.createElementNS('http://www.w3.org/2000/svg', 'image');

var OrderedFunctions = [
    function drawLeaf() {
        drawPath('yellowgreen', 'yellowgreen', 'M 200 80 C170 100 200 130 200 130', 1);
        drawPath('green', 'green', 'M 200 80 C230 100 200 130 200 130', 1);
    },
    function drawExpress() {
        writeTextOnThePage(155, 170, 24, 'white', word[1], 'arial');
    },
    function drawAngularJs() {
        drawPath('darkred', 'lightgrey', 'M 200 205 L220 220 L210 280 L200 280', 2);
        drawPath('red', 'lightgrey', 'M 200 205 L180 220 L190 280 L200 280', 2);
        drawPath('red', 'white', 'M 200 210 L180 260', 3);
        drawPath('red', 'lightgrey', 'M 200 210 L220 260', 3);
    },
    function drawNode() {
        svgimg.setAttributeNS(null, 'height', '50');
        svgimg.setAttributeNS(null, 'width', '100');
        svgimg.setAttributeNS('http://www.w3.org/1999/xlink', 'href', 'img/node.png');
        svgimg.setAttributeNS(null, 'x', '150');
        svgimg.setAttributeNS(null, 'y', '260');
        svgimg.setAttributeNS(null, 'visibility', 'visible');
        svg.appendChild(svgimg);
    }
];

function createCircle(x, y, r, fill) {
    var circle = document.createElementNS(svgNS, 'circle');
    circle.setAttribute('cx', x);
    circle.setAttribute('cy', y);
    circle.setAttribute('r', r);
    circle.setAttribute('stroke', 'none');
    circle.setAttribute('fill', fill);
    svg.appendChild(circle);
}

function writeTextOnThePage(x, y, fontSize, color, innerText, fontFamily) {
    var text = document.createElementNS(svgNS, 'text');
    text.setAttribute('x', x);
    text.setAttribute('y', y);
    text.setAttribute('font-size', fontSize);
    text.setAttribute('fill', color);
    text.setAttribute('font-family', fontFamily),
    text.innerHTML = innerText;
    svg.appendChild(text);
}

function drawPath(fillColor, strokeColor, d, strokeWidth) {
    var leftCurve = document.createElementNS(svgNS, 'path');
    leftCurve.setAttribute('d', d);
    leftCurve.setAttribute('fill', fillColor);
    leftCurve.setAttribute('stroke', strokeColor);
    leftCurve.setAttribute('stroke-width', strokeWidth);
    svg.appendChild(leftCurve);
}

// draw every circle with elements in loop
for (var i = 0; i < circlesCount; i++) {
    createCircle(circlesCenterX, positionY, radius, colors[i]);
    writeTextOnThePage(textPositionX, positionY, fontSize, colors[i], word[0][i], 'arial');
    if (OrderedFunctions[i]) {
        OrderedFunctions[i]();
    }
    positionY += 65;
}