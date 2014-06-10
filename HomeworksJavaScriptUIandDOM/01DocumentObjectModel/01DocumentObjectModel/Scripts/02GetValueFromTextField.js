// Create a function that gets the value of <input type="text"> ands prints its value to the console

var body = document.body;

var inputText = document.createElement('input');
inputText.type = 'text';
inputText.id = 'inputText';

var btn = document.createElement('button');
btn.textContent = 'print text';
btn.onclick = print;

body.appendChild(inputText);
body.appendChild(btn);

function print() {
    console.log(inputText.value);
    alert(inputText.value);
}