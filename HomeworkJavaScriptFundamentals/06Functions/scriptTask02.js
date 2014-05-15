taskName = 'Functions-2';

function Main(bufferElement) {
    var readNumber = ReadLine("Please enter given decimal number: ");

    SetSolveButton(function () {
        var number = readNumber.value * 1;
        var reverseNumber;

        if (number % 1 === 0) {
            reverseNumber = reverseDigits(number);
            WriteLine('The reversed number is: ' + reverseNumber);
        } else {
            WriteLine("Please enter correct number");
        }
    });
}

function reverseDigits(number) {
    var numberString = number.toString();
    var result = '';

    for (var i = numberString.length - 1; i >= 0; i -= 1) {
        result += numberString[i];
    }

    return result * 1;
}