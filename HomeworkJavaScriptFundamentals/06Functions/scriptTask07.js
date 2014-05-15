taskName = 'Functions-7';

function Main(bufferElement) {
    var testArray1 = new Array(4, -5, 7, 8, 4, 11, 6, 4);
    var testArray2 = new Array(-5, -5, 7, 8, 4, 11, 6, 4);
    var testArray3 = new Array(-5, -5, -6);
    var firstBigger;

    printArray(testArray1);
    firstBigger = findFirstBigger(testArray1);
    printResult(firstBigger, testArray1[firstBigger]);

    printArray(testArray2);
    firstBigger = findFirstBigger(testArray2);
    printResult(firstBigger, testArray2[firstBigger]);

    printArray(testArray3);
    firstBigger = findFirstBigger(testArray3);
    printResult(firstBigger, testArray3[firstBigger]);
}

function findFirstBigger(testArray) {
    var position;

    for (position = 0; position < testArray.length; position += 1) {
        if (checkIfBiggerThanNeighbours(testArray, position)) {
            return position;
        }
    }

    return -1;
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
    WriteLine('Array: ' + testArr.join(', '));
}

function printResult(position, element) {
    if (position === -1) {
        WriteLine('-1' + '   There is no element bigger than its neighbours !');
    } else {
        WriteLine('The element ' + element + ' at position ' + position + ' is FIRST bigger than its neighbours.');
    }
    WriteLine();
}