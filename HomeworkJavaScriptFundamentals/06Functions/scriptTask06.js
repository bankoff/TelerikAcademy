taskName = 'Functions-6';

function Main(bufferElement) {
    var testArray = new Array(4, -5, 7, 8, 4, 11, 6, 4);
    var position;
    var check;

    printArray(testArray);

    position = 3;
    check = checkIfBiggerThanNeighbours(testArray, position);
    Write('The element ' + testArray[position] + ' at position ' + position);
    WriteLine(check ? ' IS bigger than its neighbours.' : ' is NOT bigger than its neighbours.');

    position = 2;
    check = checkIfBiggerThanNeighbours(testArray, position);
    Write('The element ' + testArray[position] + ' at position ' + position);
    WriteLine(check ? ' IS bigger than its neighbours.' : ' is NOT bigger than its neighbours.');
}

function checkIfBiggerThanNeighbours(testArr, position) {
    if (position < 0 && position > testArr.length - 1) {
        return false;
    }

    if (testArr.length === 1 && position === 0) {
        return true;
    }

    if (position === 0 && testArr[position] > testArr[position + 1]) {
        return true;
    }

    if (position === testArr.length - 1 && testArr[position] > testArr[position - 1]) {
        return true;
    }

    if (testArr[position] > testArr[position - 1] && testArr[position] > testArr[position + 1]) {
        return true;
    }

    return false;
}

function printArray(testArr) {
    WriteLine('The array is: ' + testArr.join(', '));
}