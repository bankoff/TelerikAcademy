// Write a script that creates a number of div elements.Each div element must have the following
// Random width and height between 20px and 100px
// Random background color
// Random font color
// Random position on the screen (position:absolute)
// A strong element with text "div" inside the div
// Random border-radius
// Random border color
// Random border-width between 1px and 20px
window.onload = function () {
    var maxWidth = screen.width - 100;
    var maxHeight = screen.height - 300;
    var buttonGenerateDivs = document.getElementById('btn-generate-boxes');

    buttonGenerateDivs.addEventListener('click', function () {
        var contentDiv = document.getElementById("content");

        // deletes the divs from the previous clicks (the previously generated randomly divs)
        while (contentDiv.firstChild) {
            contentDiv.removeChild(contentDiv.firstChild);
        }

        var count = (document.getElementById("divs-count").value | 0) || 5;

        for (var i = 0; i < count; i++) {
            var randomDiv = document.createElement("div");
            randomDiv.classList.add("colored");
            makeDivsRandomParams(randomDiv);
            contentDiv.appendChild(randomDiv).appendChild(createStrong('div'));
        }

        return false;
    });

    function generateRandomColor() {
        var red = (Math.random() * 256) | 0;
        var green = (Math.random() * 256) | 0;
        var blue = (Math.random() * 256) | 0;

        return "rgb(" + red + "," + green + "," + blue + ")";
    }

    function makeDivsRandomParams(randomDiv) {

        randomDiv.style.position = "absolute";

        // position top left
        var topPos = parseInt(Math.random() * (maxHeight));
        randomDiv.style.top = topPos + "px";
        var left = parseInt(Math.random() * (maxWidth));
        randomDiv.style.left = left + "px";

        // width and heigth
        var width = parseInt(Math.random() * (100 - 20) + 20);
        randomDiv.style.width = width + "px";
        var height = parseInt(Math.random() * (100 - 20) + 20);
        randomDiv.style.height = height + "px";

        // text and background style
        randomDiv.style.backgroundColor = generateRandomColor();
        randomDiv.style.color = generateRandomColor();
        randomDiv.style.textAlign = "center";

        // border style
        randomDiv.style.borderWidth = parseInt(Math.random() * (20 - 1) + 1) + "px";
        randomDiv.style.borderRadius = parseInt(Math.random() * 50) + "%";
        randomDiv.style.borderColor = generateRandomColor();
    }

    // create strong text inside the div
    function createStrong(text) {
        var result = document.createElement('strong');
        result.appendChild(document.createTextNode(text));

        return result;
    }
}();