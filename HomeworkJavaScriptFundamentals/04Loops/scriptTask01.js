taskName = 'Loops-1';

function Main(bufferElement) {
    var readNumber = ReadLine('Please enter number N: ');

    SetSolveButton(function () {
        var number = readNumber.value * 1;
        var i;
        var result = '';

        if ((number % 1 === 0)&&(number>0)) {
            for (i = 1; i <= number; i += 1) {
                result += i;

                if (i < number) {
                    result += ', ';
                }
            }
        } else {
            WriteLine('Please enter correct number!');
        }

        WriteLine(result);
    });
}
