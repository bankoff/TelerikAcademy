taskName = 'Arrays-4';

function Main(bufferElement) {
    var arr = new Array(8, 4, -5, 2, 6, 11, 9, 1, 55);

    WriteLine('The elements in the array are:');
    printArray(arr);
    WriteLine();
    findMaxIncreasingSeq(arr);
}

function findMaxIncreasingSeq(arr) {
    var currentLen = 1;
    var bestLen = 1;
    var bestLenIndex = 0;

    for (var counter = 1; counter < arr.length; counter++) {
        if (arr[counter] > arr[counter - 1]) {
            currentLen++;
        }

        if (counter == arr.length - 1) {
            if (currentLen > bestLen) {
                bestLen = currentLen;
                bestLenIndex = counter;
            }
        }

        if (arr[counter] <= arr[counter - 1]) {
            if (currentLen > bestLen) {
                bestLen = currentLen;
                bestLenIndex = counter - 1;
            }

            currentLen = 1;
        }
    }

    WriteLine('The max sequence of increasing elements is ' + bestLen);
    Write('{');
    printMaxIncreasingElement(arr, bestLenIndex, bestLen);
}

function printArray(arr) {
    for (var counter = 0; counter < arr.length; counter++) {
        Write(arr[counter] + ' ');
    }
}

function printMaxIncreasingElement(arr, bestLenIndex, bestLen) {
    for (var counter = bestLenIndex - bestLen + 1; counter <= bestLenIndex; counter++) {
        if (counter == bestLenIndex) {
            WriteLine(arr[counter] + '}');
        }
        else {
            Write(arr[counter] + ', ');
        }
    }
}