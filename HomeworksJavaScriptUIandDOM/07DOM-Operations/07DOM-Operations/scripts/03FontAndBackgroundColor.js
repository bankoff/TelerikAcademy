// Create a text area and two inputs with type="color"
// Make the font color of the text area as the value of the first color input
// Make the background color of the text area as the value of the second input
window.onload = function () {
    var body = document.body;

    var textArea = document.createElement('textarea');
    textArea.id = 'textArea';
    textArea.textContent = 'Hello!';

    var inputColorFont = document.createElement('input');
    inputColorFont.type = 'color';
    inputColorFont.id = 'inputColorFont';
    inputColorFont.onchange = changeTextFontColor;

    var labelInputColorFont = document.createElement('label');
    labelInputColorFont.setAttribute("for", inputColorFont.id);
    labelInputColorFont.innerHTML = "Please select the color for the font of the text area";
    
    var inputColorBackground = document.createElement('input');
    inputColorBackground.type = 'color';
    inputColorBackground.id = 'inputColorBackground';
    inputColorBackground.onchange = changeBackgroundColor;

    var labelInputColorBackground = document.createElement('label');
    labelInputColorBackground.setAttribute("for", inputColorBackground.id);
    labelInputColorBackground.innerHTML = "Please select the color for the background of the text area";

    body.appendChild(textArea);
    body.appendChild(document.createElement("br"));
    body.appendChild(inputColorFont);
    body.appendChild(labelInputColorFont);
    body.appendChild(document.createElement("br"));
    body.appendChild(inputColorBackground);
    body.appendChild(labelInputColorBackground);

    function changeTextFontColor() {
        return textArea.style.color = document.getElementById('inputColorFont').value;
    }

    function changeBackgroundColor() {
        textArea.style.backgroundColor = document.getElementById('inputColorBackground').value;
    }
}();