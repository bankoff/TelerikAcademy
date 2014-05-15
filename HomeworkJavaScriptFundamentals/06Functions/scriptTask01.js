taskName = 'Functions-1';

function Main(bufferElement) {
    var readInt = ReadLine("Please enter one integer: ");

    SetSolveButton(function () {
        var integer = readInt.value * 1;
        var lastDigit;

        if (integer % 1 === 0) {
            lastDigit = lastDigitName(integer);
            WriteLine(Format('Last digit of {0} is {1}', integer, lastDigit));
        } else {
            WriteLine("Please enter correct integer!");
        }
    });
}

function lastDigitName(number) {
    var digitName='';

    switch (number % 10) {
        case 1: digitName = "one"; break;
        case 2: digitName = "two"; break;
        case 3: digitName = "three"; break;
        case 4: digitName = "four"; break;
        case 5: digitName = "five"; break;
        case 6: digitName = "six"; break;
        case 7: digitName = "seven"; break;
        case 8: digitName = "eight"; break;
        case 9: digitName = "nine"; break;
        case 0: digitName = "zero"; break;
    }

    return digitName;
}
