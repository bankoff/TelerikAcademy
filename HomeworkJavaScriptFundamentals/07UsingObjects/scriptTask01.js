taskName = 'UsingObjects-1';

function Main(bufferElement) {
    var line1 = { Point1: buildPoint(3,4), Point2: buildPoint(5,0) };
    var line2 = { Point1: buildPoint(5, 0), Point2: buildPoint(-4, 3) };
    var line3 = { Point1: buildPoint(-4, 3), Point2: buildPoint(3, 4) };
    var line4 = { Point1: buildPoint(-11, 13), Point2: buildPoint(13, 14) };

    WriteLine("The Distance between points of line 1 is:" +
    Math.round(calcDistance(line1.Point1, line1.Point2) * 100) / 100); //useful link for rounding in java http://www.javascriptkit.com/javatutors/round.shtml
    WriteLine("The Distance between points of line 2 is:" +
    Math.round(calcDistance(line2.Point1, line2.Point2) * 100) / 100);
    WriteLine("The Distance between points of line 3 is:" +
    Math.round(calcDistance(line3.Point1, line3.Point2) * 100) / 100);
    WriteLine("Can our three segment lines form a triangle?");
    checkIfCanFormTriangel(line1, line2, line3);

    WriteLine();

    WriteLine("The Distance between points of line 1 is:" +
    Math.round(calcDistance(line1.Point1, line1.Point2) * 100) / 100);
    WriteLine("The Distance between points of line 2 is:" +
    Math.round(calcDistance(line2.Point1, line2.Point2) * 100) / 100);
    WriteLine("The Distance between points of line 4 is:" +
    Math.round(calcDistance(line4.Point1, line4.Point2) * 100) / 100);
    WriteLine("Can our three segment lines form a triangle?");
    checkIfCanFormTriangel(line1, line2, line4);
}

function buildPoint(x, y) {
    return {
        x: x,
        y: y
    };
}

function calcDistance(Point1, Point2) {
    var distance = Math.sqrt((Point1.x - Point2.x) * (Point1.x - Point2.x) + (Point1.y - Point2.y) * (Point1.y - Point2.y));
    return distance;
}

function checkIfCanFormTriangel(line1, line2, line3) {
    var line1Len = calcDistance(line1.Point1, line1.Point2);
    var line2Len = calcDistance(line2.Point1, line2.Point2);
    var line3Len = calcDistance(line3.Point1, line3.Point2);

    if (line1Len < line2Len + line3Len && line2Len < line1Len + line3Len && line3Len < line2Len + line1Len) {
        WriteLine('True');
    }
    else {
        WriteLine('False');
    }
}
