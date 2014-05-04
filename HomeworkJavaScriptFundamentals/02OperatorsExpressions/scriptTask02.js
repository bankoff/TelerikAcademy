taskName = "OperatorsAndExpressions-2";

function Main(bufferElement) {
    var readNumber = ReadLine("Please enter one integer number: ");

    SetSolveButton(function () {
        var intNumber = readNumber.value * 1;
        if (intNumber % 1 !== 0) {
            WriteLine("Please enter correct integer number");
        } else {
            var isDivisibleByFive= intNumber % 5 == 0;
            var isDivisibleBySeven = intNumber % 7 == 0;
            if (isDivisibleByFive && isDivisibleBySeven) {
                WriteLine(Format("The {0} can be divided " +
                    "(without remainder) by 7 and 5 at the same time",
                    intNumber));
            } else {
                WriteLine(Format("The {0} can not be divided " +
                    "(without remainder) by 7 and 5 at the same time",
                    intNumber));
            }
        }
    });
}
