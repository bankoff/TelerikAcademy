taskName = 'Functions-4';

function Main(bufferElement) {
    var divs = countDivs();
    WriteLine('The number of divs in page is ' + divs);
}

function countDivs() {
    var count = document.getElementsByTagName('div').length;
    return count;
}