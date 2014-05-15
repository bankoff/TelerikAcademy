taskName = 'Arrays-1';

function Main(bufferElement) {
    var arrayOfIntegers = new Array(20);

    for (var i = 0; i < arrayOfIntegers.length; i += 1) {
        arrayOfIntegers[i] = i * 5;
    }

    WriteLine(arrayOfIntegers);
}
