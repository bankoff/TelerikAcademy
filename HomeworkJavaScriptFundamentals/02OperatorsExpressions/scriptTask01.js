taskName = "OperatorsAndExpressions-1";

function Main(bufferElement) {
    var readNumber = ReadLine("Please enter one integer number: ");

    SetSolveButton(function () {
        var intNumber = readNumber.value * 1;
        if (intNumber % 2 === 0) {
            WriteLine(Format("The number {0} is even", intNumber));
        } else if (intNumber % 2 === 1 || intNumber % 2 === -1) {
            WriteLine(Format("The number {0} is odd", intNumber));
        } else {
            WriteLine(Format("The {0} is not a integer number",
                readNumber.value));
        }
    });
}
