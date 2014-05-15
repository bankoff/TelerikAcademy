taskName = 'Functions-5';

function Main(bufferElement) {
    var testArr = new Array(4, -5, 7, 8, 4, 11, 6, 4);
    var numToSearch = 4;
    var count;

    printArray(testArr);
    count = countOccurences(testArr, numToSearch);
    WriteLine('The number ' + numToSearch + ' occurs ' +
        count + ' times');
}

function countOccurences(testArr, numToSearch) {
    var i;
    var counter = 0;

    for (i = 0; i < testArr.length; i += 1) {
        if (testArr[i] === numToSearch) {
            counter++;
        }
    }

    return counter;
}

function printArray(testArr) {
    WriteLine('The array is: ' + testArr.join(', '));
}