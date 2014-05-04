taskName = "OperatorsAndExpressions-8";

function Main(bufferElement) {
    var readA = ReadLine("Please enter side a of trapezoid: ");
    var readB = ReadLine("Please enter side b of trapezoid: ");
    var readH = ReadLine("Please enter height of trapezoid: ");

    SetSolveButton(function () {
        var a = readA.value * 1;
        var b = readB.value * 1;
        var h = readH.value * 1;

        if ((a * 0 === 0) && (b * 0 === 0) && (h * 0 === 0) &&
            (a > 0) && (b > 0) && (h > 0)) {
            WriteLine("Area of trapezoid is: " + ((a + b) * h / 2));
        } else {
            WriteLine("Please enter correct sides and height!");
        }
    });
}