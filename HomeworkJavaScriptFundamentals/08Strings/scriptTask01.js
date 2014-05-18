taskName = 'Strings-1';

function Main(bufferElement) {
    var readStr = ReadLine('Please enter one string: ');

    SetSolveButton(function () {
        var readString = readStr.value;
        var resultString;

        resultString = stringReverse(readString);
        WriteLine(resultString);
    });
}

function stringReverse(inputString) {
    var resultString = '';

    for (var i = inputString.length-1; i >=0 ; i-=1) {
        resultString += inputString[i];
    }

    return resultString;
}