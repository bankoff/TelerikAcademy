// Create a TODO list with the following UI controls
// Form input for new Item
// Button for adding the new Item
// Button for deleting some item
// Show and Hide Button
var oList = document.querySelector('#toDoList');

// I am attaching the buttons to events
var addButton = document.querySelector('#add');
addButton.addEventListener('click', addNewListItem, false);

var removeItemButton = document.getElementById('remove');
removeItemButton.addEventListener('click', removeListItem, false);

var showHideButton = document.getElementById('showHide');
showHideButton.addEventListener('click', showHide, false);

function addNewListItem(event) {
    // if event.preventDefault is not applied, browser does not know which event to apply in many cases
    // see more at  http://www.w3schools.com/jquery/event_preventdefault.asp
    event.preventDefault();
    var listItem = document.createElement('li');
    // get the value from the input text
    var inputValue = document.getElementById('enter').value;
    listItem.innerHTML = inputValue;
    oList.appendChild(listItem);
}

function showHide(event) {
    event.preventDefault();
    var elements = document.querySelectorAll('ol>li');
    var i = 0;
    // all visible elements are made invisible, all invisible are made visible
    for (i = 0; i < elements.length; i++) {
        if (elements[i].style.display !== 'none') {
            elements[i].style.display = 'none';
        }
        else {
            elements[i].style.display = 'list-item';
        }
    }
}

function removeListItem(event) {
    event.preventDefault();
    var valueToRemove = document.getElementById("enter").value;
    
    // create value=0 if the value not a number
    valueToRemove = valueToRemove | 0;
    var elementsToRemove = document.querySelector("li:nth-child(" + valueToRemove + ")");

    if (elementsToRemove) {
        elementsToRemove.parentNode.removeChild(elementsToRemove);
    }
}