taskName = "OperatorsAndExpressions-9";

function Main(bufferElement) {
    var readX = ReadLine("Please enter coordinate X on point A: ");
    var readY = ReadLine("Please enter coordinate Y on point A ");

    SetSolveButton(function () {
        var coordX = readX.value * 1;
        var coordY = readY.value * 1;
        var condition = ((3 * 3) > (((coordX - 1) * (coordX - 1)) +
                                    ((coordY - 1) * (coordY - 1)))) &
                                    ((coordX < -1) | (coordX > 5) |
                                    (coordY > 1) | (coordY < -1));

        if ((coordX * 0 === 0) && (coordY * 0 === 0)) {
            if (condition) {
                WriteLine(Format("The point ({0},{1}) " +
                    "is within the circle K((1,1)3) and ouside " +
                    "the rectangle (top=1, left=-1, width=6, height=2)",
                    coordX, coordY));
            }
            else {
                WriteLine(Format("The point ({0},{1}) " +
                    "do not meet the required conditions " +
                    "for the given circle and rectangle.",
                    coordX, coordY));
            }
        } else {
            WriteLine("Please enter correct coordinates!");
        }
    });
}