taskName = "OperatorsAndExpressions-6";

function Main(bufferElement) {
    var readX = ReadLine("Please enter coordinate X on point A: ");
    var readY = ReadLine("Please enter coordinate Y on point A ");

    SetSolveButton(function () {
        var xCoord = readX.value * 1;
        var yCoord = readY.value * 1;

        if ((xCoord * 0 === 0) && (yCoord * 0 === 0)) {
            if ((5 * 5) < ((xCoord * xCoord) + (yCoord * yCoord))) {
                WriteLine(Format("The point ({0},{1}) is out of a " +
                    "circle K((0,0), 5)", xCoord, yCoord));
            }
            else {
                WriteLine(Format("The point ({0},{1}) in a " +
                    "circle K((0,0), 5)", xCoord, yCoord));
            }
        } else {
            WriteLine("Please enter correct coordinates!");
        }
    });
}