taskName = "OperatorsAndExpressions-5";

function Main(bufferElement) {
    var readNumber = ReadLine("Please enter one integer number: ");

    SetSolveButton(function () {
        var intNumber = readNumber.value * 1;
        var bit3;

        if (intNumber % 1 !== 0) {
            WriteLine("Please enter correct integer number");
        } else {
            bit3 = (intNumber >> 3) & 1;

            WriteLine(Format("Binary representation of {0} is:",
                intNumber));
            WriteLine(dec2Bin(intNumber));
            WriteLine(Format("The bit 3 (counting from 0) is: {0}",
                bit3));
        }
    });
}

function dec2Bin(dec) {
    return (dec >>> 0).toString(2);
}