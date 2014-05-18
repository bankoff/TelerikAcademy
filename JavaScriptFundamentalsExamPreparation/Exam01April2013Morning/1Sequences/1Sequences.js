//BGCoder 100/100

function solve(args) {
    var input = args.map(Number);
    var result = 1;

    for (var i = 2; i < input.length; i += 1) {
        if (input[i] < input[i - 1]) {
            result++;
        }
    }

    return result;
}


//var test1 = [
//    '7',
//'1',
//'2',
//'-3',
//'4',
//'4',
//'0',
//'1'
//];

//console.log(solve(test1));
//console.dir(solve(test1));