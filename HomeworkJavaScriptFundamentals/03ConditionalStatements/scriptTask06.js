taskName = "ConditionalStatements-6";

function Main(bufferElement) {
    var readA = ReadLine("Please enter a: ");
    var readB = ReadLine("Please enter b: ");
    var readC = ReadLine("Please enter c: ");

    SetSolveButton(function () {
        var a = readA.value * 1;
        var b = readB.value * 1;
        var c = readC.value * 1;
        var d = (b * b) - (4 * a * c);
        var x1;
        var x2;

        if ((a * 0 === 0) && (b * 0 === 0) && (c * 0 === 0)) {
            if ((a == 0) && (b == 0) && (c != 0)) {
                WriteLine("Equation does not have real roots");
            } else if ((a == 0) && (b == 0) && (c == 0)) {
                WriteLine("Roots are all real numbers");
            } else if ((a == 0) && (b != 0)) {
                WriteLine("Equation has 1 real root X = " + (-c / b));
            } else {
                if (d < 0) {
                    WriteLine("Equation does not have real roots");
                } else if (d == 0) {
                    d = Math.sqrt(d);
                    x1 = (-b + d) / (2 * a);
                    WriteLine("Equation has 1 real root X = " + x1);
                } else {
                    d = Math.sqrt(d);
                    x1 = (-b + d) / (2 * a);
                    x2 = (-b - d) / (2 * a);
                    WriteLine("Equation has 2 real roots");
                    WriteLine("X1 = " + x1);
                    WriteLine("X2 = " + x2);
                }
            }
        } else {
            WriteLine("Please enter correct coefficients!");
        }
    });   
}