taskName = "ConditionalStatements-1";

function Main(bufferElement) {
    var readFirst = ReadLine("Please enter first integer: ");
    var readSecond = ReadLine("Please enter second integer: ");

    SetSolveButton(function () {
        var first = readFirst.value * 1;
        var second = readSecond.value * 1;
        var exchange;

        if ((first % 1 === 0) && (second % 1 === 0)) {

            if (first > second) {
                exchange = first;
                first = second;
                second = exchange;
            }

            WriteLine(Format("First integer = {0} and second integer = {1}" +
                " because {0} <= {1}", first, second));
        } else {
            WriteLine("Please enter correct integers!");
        }
    });
}
