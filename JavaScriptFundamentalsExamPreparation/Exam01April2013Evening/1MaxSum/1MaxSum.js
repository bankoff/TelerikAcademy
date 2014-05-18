//BGCoder 100/100

function Solve(params) {
    var N = parseInt(params[0]);
    var answer = -2000000;
    // Your code here...
    var arr = [],
        sum;
    for (var i = 1; i <= N; i += 1) {
        arr.push(parseInt(params[i]));
    }

    for (var j = 0; j < arr.length; j++) {
        sum = 0;

        for (var k = j; k < arr.length; k++) {
            sum += arr[k];

            if (sum > answer) {
                answer = sum;
            }
        }
    }

    return answer;
}

//var params = [
//    '8',
//    '1',
//    '6',
//    '-9',
//    '4',
//    '4',
//    '-2',
//    '10',
//    '-1'
//];

//console.log(Solve(params));