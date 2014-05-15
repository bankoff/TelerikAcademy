taskName = 'Arrays-3';

function Main(bufferElement) {
    var arr = new Array(11, -21, 1, 1, 5, 5, 5, -2, -2, -2, -2, 4, 5, 5);

    WriteLine('The elements in the array are:');
    printArray(arr);
    WriteLine();

    findMaxEqualSeq(arr);
}

function findMaxEqualSeq(arr) {
    var counter;
    var currentLen = 1;
    var bestLen = 1;
    var equalElementsExist = false;
    var equalElement = 0;

    for (counter = 1; counter < arr.length; counter++) {
        if (arr[counter] == arr[counter - 1]) {
            equalElementsExist = true;
            currentLen++;
        }
        if (arr[counter] != arr[counter - 1] || counter == arr.length - 1) {
            if (currentLen > bestLen) {
                bestLen = currentLen;
                equalElement = arr[counter - 1];
            }
            currentLen = 1;
        }
    }

    Write('{');
    printMaxEqualElement(arr, bestLen, equalElement);

    WriteLine('The max sequence of equal elements is ' + bestLen);
    if (equalElementsExist == true) {
        WriteLine('The value of equal elements is ' + equalElement);
    }
}

function printArray(arr) {
    for (var counter = 0; counter < arr.length; counter++) {
        Write(arr[counter] + ' ');
    }
}

function printMaxEqualElement(arr, bestLen, equalElement) {
    for (var counter = 0; counter < bestLen; counter++) {
        Write(equalElement + ' ');
    }

    WriteLine('}');
}