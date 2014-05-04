taskName = "OperatorsAndExpressions-3";

function Main(bufferElement) {
    var readWidth = ReadLine("Please enter width of rectangle: ");
    var readHeight = ReadLine("Please enter height of rectangle: ");

    SetSolveButton(function () {
        var width = readWidth.value * 1;
        var height = readHeight.value * 1;

        if ((width * 0 === 0) && (height * 0 === 0) &&
            (width > 0) && (height > 0)) {
            WriteLine("Area of rectangle is:" + width * height);
        } else {
            WriteLine("Please enter correct width and height!");
        }
    });
}