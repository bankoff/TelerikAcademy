taskName = "ConditionalStatements-4";

function Main(bufferElement) {
    var readFirst = ReadLine("Please enter first number: ");
    var readSecond = ReadLine("Please enter second number: ");
    var readThird = ReadLine("Please enter third number: ");

    SetSolveButton(function () {
        var first = readFirst.value * 1;
        var second = readSecond.value * 1;
        var third = readThird.value * 1;

        if ((first * 0 === 0) && (second * 0 === 0) && (third * 0 === 0)) {
            if (first >= second) {
                if (second >= third) {
                    WriteLine(Format("The numbers arranged in" +
                        " descending order: {0}, {1}, {2}",
                        first, second, third));
                } else if (first >= third) {
                    WriteLine(Format("The numbers arranged in" +
                        " descending order: {0}, {1}, {2}",
                        first, third, second));
                } else {
                    WriteLine(Format("The numbers arranged in" +
                        " descending order: {0}, {1}, {2}",
                        third, first, second));
                }
            } else {
                if (first >= third) {
                    WriteLine(Format("The numbers arranged in" +
                        " descending order: {0}, {1}, {2}",
                        second, first, third));
                } else if (second >= third) {
                    WriteLine(Format("The numbers arranged in" +
                        " descending order: {0}, {1}, {2}",
                        second, third, first));
                } else {
                    WriteLine(Format("The numbers arranged in" +
                        " descending order: {0}, {1}, {2}",
                        third, second, first));
                }
            }
        } else {
            WriteLine("Please enter correct numbers!");
        }
    });
}