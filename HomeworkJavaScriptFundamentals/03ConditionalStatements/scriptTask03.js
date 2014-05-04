taskName = "ConditionalStatements-3";

function Main(bufferElement) {
    var readFirst = ReadLine("Please enter first integer: ");
    var readSecond = ReadLine("Please enter second integer: ");
    var readThird = ReadLine("Please enter third integer: ");

    SetSolveButton(function () {
        var first = readFirst.value * 1;
        var second = readSecond.value * 1;
        var third = readThird.value * 1;

        if ((first % 1 === 0) && (second % 1 === 0) && (third % 1 === 0)) {
            if (first >= second) {
                if (first >= third) {
                    WriteLine(Format("First integer {0} is the biggest.",
                        first));
                } else {
                    WriteLine(Format("Third integer {0} is the biggest.",
                        third));
                }
            } else {
                if (second >= third) {
                    WriteLine(Format("Second integer {0} is the biggest",
                        second));
                } else {
                    WriteLine(Format("Third integer {0} is the biggest.",
                        third));
                }
            }
        } else {
            WriteLine("Please enter correct integers!");
        }
    });
}