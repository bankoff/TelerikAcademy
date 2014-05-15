taskName = 'Arrays-6';

function Main(bufferElement) {
    var arr = new Array(4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3);

    WriteLine('The array is:');
    printArray(arr);
    WriteLine();
    findMostFrequent(arr);
}

function findMostFrequent(arr) {
    var freqArr = new Array(arr.length);
    var counter = 0;
    var j;
    var maxFrequency = 1;
    var positionMaxFreq = 0;

    for (var i = 0; i < freqArr.length; i++) {
        freqArr[i] = 0;
    }

    while (counter < arr.length) {
        for (j = counter; j < arr.length; j++) {
            if (arr[j] == arr[counter]) {
                freqArr[j]++;
            }
        }

        counter++;
    }

    for (j = 0; j < freqArr.length; j++) {
        if (freqArr[j] > maxFrequency) {
            maxFrequency = freqArr[j];
            positionMaxFreq = j;
        }
    }

    if (maxFrequency == 1) {
        WriteLine('All elements are different. The most frequent number is each of them with frequency 1.');
    } else {
        WriteLine('The most frequent number is ' + arr[positionMaxFreq] + ' (' + maxFrequency + ' times).');
    }
}

function printArray(arr) {
    for (var counter = 0; counter < arr.length; counter++) {
        Write(arr[counter] + ' ');
    }
}