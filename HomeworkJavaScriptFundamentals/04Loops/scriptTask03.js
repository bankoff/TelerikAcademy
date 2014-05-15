taskName = 'Loops-3';

function Main(bufferElement) {
    var readCount = ReadLine("Please enter count of numbers: ");

    SetSolveButton(function () {
        var count = readCount.value * 1;
        var number;
        var sign;
        var i;
        var min = Number.MAX_VALUE;
        var max = -Number.MAX_VALUE;

        ConsoleClear();

        if ((count % 1 === 0) && (count > 0)) {
            for (i = 1; i <= count; i += 1) {
                // get random number sign
                if (Math.random() < 0.5) {
                    sign = -1;
                } else {
                    sign = 1;
                }

                // get random number in range [-1000, 1000]
                number = sign * Math.floor(Math.random() * 1000);
                WriteLine(Format('Number {0} is : {1}', i, number));

                if (number>max) {
                    max = number;
                }

                if (number<min) {
                    min = number;
                }
            }
        } else {
            WriteLine("Please enter correct integer!");
        }

        WriteLine();
        WriteLine('The max number is: ' + max);
        WriteLine('The min number is: ' + min);
    });
}