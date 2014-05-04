taskName = "OperatorsAndExpressions-7";

function Main(bufferElement) {
    var readNumber = ReadLine("Please enter one integer number from 2 to 100: ");

    SetSolveButton(function () {
        var intNumber = readNumber.value * 1;
        var divider = 2;
        var maxDivider;
        var prime = true;

        if (intNumber % 1 !== 0 || intNumber < 2 || intNumber >100) {
            WriteLine("Please enter correct integer number");
        } else {
            maxDivider = Math.sqrt(intNumber);
                    
            while (prime && (divider <= maxDivider))
            {
                if (intNumber % divider == 0)
                {
                    prime = false;
                    break;
                }

                divider++;
            }
            WriteLine(prime ? "The number is prime." : "The number is not prime.");
        }
    });
}