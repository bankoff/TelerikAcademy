taskName = 'UsingObjects-2';

function Main(bufferElement) {
    var arr = [1, 2, 1, 3, 4, 1, 111, 3, 2, 1, "1"];
    var resultArr;
    var valueToRemove = 1;

    Array.prototype.removeValue = function () {
        var resultArray = []; 
        for (var i = 0; i < arr.length; i++) {
            if (arr[i] !== valueToRemove) {
                resultArray.push(arr[i]);
            }
        }

        return resultArray;
    };

    WriteLine('The array before removal of all elements with value (' +
            valueToRemove + ") is ");
    printArray(arr);

    resultArr = arr.removeValue(valueToRemove);

    WriteLine('The array after removal of all elements with value (' +
            valueToRemove + ') is ');
    printArray(resultArr);
}

function printArray(arr) {
    for (var i = 0; i < arr.length; i += 1) {
        if (typeof (arr[i]) == 'number') {
            Write(arr[i]);
        } else {
            Write('"' + arr[i] + '"');
        }

        if (i != arr.length - 1) {
            Write(' ,');
        }
    }

    WriteLine();
}