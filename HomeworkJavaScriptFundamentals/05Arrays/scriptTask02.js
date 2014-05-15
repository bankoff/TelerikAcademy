taskName = 'Arrays-2';

function Main(bufferElement) {
    var firstArray = 'academy'; //strings are char arrays
    var secondArray = 'telerik';
    compareCharArrays(firstArray, secondArray);

    firstArray = 'kids'; //strings are char arrays
    secondArray = 'academy';
    compareCharArrays(firstArray, secondArray);

    firstArray = 'telerik'; //strings are char arrays
    secondArray = 'telerik';
    compareCharArrays(firstArray, secondArray);   
}

function compareCharArrays(firstArray, secondArray) {
    if (firstArray.localeCompare(secondArray) < 0) {
        WriteLine('The first char array "' + firstArray +
                '" is before the second "' + secondArray + '"');
    }
    else if (firstArray.localeCompare(secondArray) > 0) {
        WriteLine('The second char array "' + secondArray +
                '" is before the first "' + firstArray + '"');
    }
    else {
        WriteLine('The arrays "' + firstArray + '" and "' +
                secondArray + '" ' + 'are equal.');
    }
}