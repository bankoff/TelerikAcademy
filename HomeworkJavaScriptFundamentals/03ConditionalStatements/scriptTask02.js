taskName = "ConditionalStatements-2";

function Main(bufferElement) {
    var readFirst = ReadLine("Please enter first number: ");
    var readSecond = ReadLine("Please enter second number: ");
    var readThird = ReadLine("Please enter third number: ");

    SetSolveButton(function () {
        var first = readFirst.value * 1;
        var second = readSecond.value * 1;
        var third = readThird.value * 1;

        if ((first * 0 === 0) && (second * 0 === 0) && (third * 0 === 0)) {
            if (first === 0 || second === 0 || third === 0) {
                WriteLine("The product is zero.");
            } else if ((first < 0 && second < 0 && third < 0) ||
                (first < 0 && second > 0 && third > 0) ||
                (first > 0 && second < 0 && third > 0) ||
                (first > 0 && second > 0 && third < 0)) {
                WriteLine("The product is negative.");
            } else {
                WriteLine("The product is positive.");
            }
        } else {
            WriteLine("Please enter correct numbers");
        }
    });
}
