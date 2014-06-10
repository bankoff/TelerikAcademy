// Crеate a function that gets the value of <input type="color"> and sets the background of the body to this value

var body = document.body;

var inputColor = document.createElement('input');
inputColor.type = 'color';
inputColor.id = 'inputColor';
inputColor.onchange = changeBackgroundColor;

body.appendChild(inputColor);

function changeBackgroundColor() {
    body.style.backgroundColor = document.getElementById('inputColor').value;
}