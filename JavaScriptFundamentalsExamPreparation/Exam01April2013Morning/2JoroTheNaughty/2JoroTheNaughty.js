//BGCoder 100/100

function solve(args) {
    function buildJump(row, col) {
        return {
            row: row,
            col: col,
            toString: function () { return '(' + this.row + ' ' + this.col + ')'; }
        };
    }

    var lines = [];
    var matrix = {},
        rowsN,
        colsM,
        jumpsJ,
        positionRow,
        positionCol,
        jumps = [],
        sumOfNumbers,
        numberOfJumps=1,
        nextJump=0;

    for (var i = 0; i < args.length; i += 1) {
        lines[i] = args[i].split(' ');
        lines[i] = lines[i].map(Number);
    }

    rowsN = lines[0][0];
    colsM = lines[0][1];
    jumpsJ = lines[0][2];

    positionRow = lines[1][0];
    positionCol = lines[1][1];

    for (var j = 2; j < args.length; j += 1) {
        jumps.push(buildJump(lines[j][0], lines[j][1]));

        //console.log(jumps[j - 2].toString());
    }

    sumOfNumbers = positionRow * colsM + positionCol + 1;

    while (true) {
        positionRow += jumps[nextJump].row;
        positionCol += jumps[nextJump].col;

        if (positionRow < 0 || positionRow > rowsN - 1 || positionCol < 0 || positionCol > colsM - 1) {
            return 'escaped ' + sumOfNumbers;
        }

        if (matrix[sumOfNumbers]===true) {
            return 'caught ' + numberOfJumps;
        }

        sumOfNumbers += positionRow * colsM + positionCol + 1;
        numberOfJumps += 1;
        nextJump += 1;

        matrix[positionRow * colsM + positionCol + 1] = true;

        if (nextJump===jumpsJ) {
            nextJump = 0;
        }
    }
}


var test1 = [
'6 7 3',
'0 0',
'2 2',
'-2 2',
'3 -1'
];

console.log(solve(test1));
//console.dir(solve(test1));