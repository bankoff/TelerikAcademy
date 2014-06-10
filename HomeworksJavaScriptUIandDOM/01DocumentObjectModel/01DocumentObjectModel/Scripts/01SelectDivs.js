// Write a script that selects all the div nodes that are directly inside other div elements
//  Create a function using querySelectorAll()
//  Create a function using getElementsByTagName()

console.log('These are all divs in divs selected with querySelectorAll');
console.dir(getDivsByQuerySelectorAll());
console.log('This is the count of divs in divs selected with querySelectorAll');
console.log(getDivsByQuerySelectorAll().length);

console.log('These are all divs in divs selected with getElementsByTagName');
console.dir(getDivsByTagname());
console.log('This is the count of divs in divs selected with getElementsByTagName');
console.log(getDivsByTagname().length);

function getDivsByQuerySelectorAll() {
    var divs = document.querySelectorAll('div>div');

    return divs;
}

function getDivsByTagname() {
    var divs = document.getElementsByTagName('div');
    var result = [];

    for (var i = 0, len = divs.length; i < len; i += 1) {
        if (divs[i].parentElement instanceof HTMLDivElement) {
            result.push(divs[i]);
        }
    }

    return result;
}