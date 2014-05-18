//BGCoder 100/100

function Solve(parameters) {
    var lines = [];
    lines[0] = parameters[0].split(' ').map(Number);
    var rowsM = lines[0][0];
    var colsN = lines[0][1];
    lines[1] = parameters[1].split(' ').map(Number);
    var rowPosition = lines[1][0];
    var colPosition = lines[1][1];

    var matrix = [rowsM];
    var numberInCell = 1;

    for (var i = 0; i < rowsM; i += 1) {
        matrix[i] = [];
        for (var j = 0; j < colsN; j += 1) {
            matrix[i].push(numberInCell);
            numberInCell += 1;
        }
    }

    var directions = [];

    for (var k = 2; k < parameters.length; k++) {
        directions.push(parameters[k]);
    }

    var steps = 1;
    var result = matrix[rowPosition][colPosition];
    matrix[rowPosition][colPosition] = false;

    while (true) {
        switch (directions[rowPosition][colPosition]) {
            case 'l':
                colPosition -= 1;
                break;
            case 'd':
                rowPosition += 1;
                break;
            case 'r':
                colPosition += 1;
                break;
            case 'u':
                rowPosition -= 1;
                break;
        }

        if (rowPosition < 0 || rowPosition >= rowsM || colPosition < 0 || colPosition >= colsN) {
            return 'out ' + result;
        }

        if (matrix[rowPosition][colPosition] === false) {
            return 'lost ' + steps;
        }

        result += matrix[rowPosition][colPosition];
        matrix[rowPosition][colPosition] = false;
        steps += 1;
    }
}


//var args = [
//    "3 4",
//    "1 3",
//    "lrrd",
//    "dlll",
//    "rddd"
//];

//console.log(Solve(args));
