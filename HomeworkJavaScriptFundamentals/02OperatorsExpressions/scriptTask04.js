taskName = "OperatorsAndExpressions-4";

function Main(bufferElement) {
    var readNumber = ReadLine("Please enter one integer number: ");

    SetSolveButton(function () {
        var intNumber = readNumber.value * 1;
        if (intNumber % 1 !== 0) {
            WriteLine("Please enter correct integer number");
        } else {
            for (var i = 0; i < 2; i++) {
                intNumber = (intNumber - intNumber % 10) / 10;
            }
            
            WriteLine(Format("The third digit (right-to-left) is " +
                Math.abs(intNumber % 10)));
        }
    });
}