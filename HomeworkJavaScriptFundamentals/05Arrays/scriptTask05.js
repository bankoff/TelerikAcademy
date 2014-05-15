taskName = 'Arrays-5';

function Main(bufferElement) {
    var arr = new Array(22, -9, 13, -1, 23, 5, 0, 3, 6, -7, 5);

    WriteLine("The unsorted array is:");
    printArray(arr);
    WriteLine();

    selectionSort(arr);
}

function selectionSort(arr) {
    var counter = 0;
    var i;
    var j;
    var smallest = 0;
    var positionSmallest = 0;
    var sortedArr = new Array(arr.length);

    for (i = 0; i < sortedArr.length; i++) {
        sortedArr[i] = 0;
    }

    while (counter < sortedArr.length) {
        for (j = 0; j < arr.length; j++) {
            if (j == 0) {
                smallest = arr[j];
                positionSmallest = j; //we assume the first element is the smallest
            }

            if (arr[j] < smallest) {
                smallest = arr[j];
                positionSmallest = j; // if we find smaller then assign the smallest variable this value
            }

            //if we are at the end of the array, we save the smallest into the new array and remove smallest value from the original array
            if (j == arr.length - 1) {
                sortedArr[counter] = arr[positionSmallest]; 
                arr.splice(positionSmallest, 1);   
            }
        }

        counter++;
    }

    WriteLine('The sorted array is:');
    printArray(sortedArr);
}

function printArray(arr) {
    for (var counter = 0; counter < arr.length; counter++) {
        Write(arr[counter] + ' ');
    }
}