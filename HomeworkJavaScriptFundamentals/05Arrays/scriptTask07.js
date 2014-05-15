taskName = 'Arrays-7';

function Main(bufferElement) {
    var arr = new Array(5, 7, -4, 6, 2, 3, -5, 4, 11, 32, 5, 11, 8);

    var searchedNumber = 6;
    var searchedNumber2 = 13;
    var searchedNumber3 = -5;

    WriteLine('The array is:');
    printArray(arr);
    WriteLine();

    arr.sort(orderby);
    WriteLine('The sorted array is:');
    printArray(arr);
    WriteLine();

    binarySearch(arr, searchedNumber);
    binarySearch(arr, searchedNumber2);
    binarySearch(arr, searchedNumber3);
}

function binarySearch(arr, searchedNumber) {
    var start = 0;
    var end = arr.length - 1;
    var middle;
    var numberExists = false;

    while (start <= end) {
        middle = parseInt((start + end) / 2);//if you do not use parseint function the loop is endless

        if (arr[middle] == searchedNumber) {
            numberExists = true;
            WriteLine();
            WriteLine('The index of the number ' + searchedNumber + ' in the sorted array is ' + middle);
            break;
        }

        if (arr[middle] < searchedNumber) {
            start = middle + 1;
        }

        if (arr[middle] > searchedNumber) {
            end = middle - 1;
        }
    }

    if (numberExists == false) {
        WriteLine();
        WriteLine('The number ' + searchedNumber + ' you are searching for does not exist in the array.');
    }
}

function orderby(a, b) {
    return ((a == b) ? 0 : (a > b) ? 1 : -1);
}

function printArray(arr) {
    for (var counter = 0; counter < arr.length; counter++) {
        Write(arr[counter] + ' ');
    }
}