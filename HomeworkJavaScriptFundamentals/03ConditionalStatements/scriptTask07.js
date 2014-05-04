taskName = "ConditionalStatements-7";

function Main(bufferElement) {
    var readFirst = ReadLine("Please enter first number: ");
    var readSecond = ReadLine("Please enter second number: ");
    var readThird = ReadLine("Please enter third number: ");
    var readFourth = ReadLine("Please enter fourth number: ");
    var readFifth = ReadLine("Please enter fifth number: ");

    SetSolveButton(function () {
        var firstNumber = readFirst.value * 1;
        var secondNumber = readSecond.value * 1;
        var thirdNumber = readThird.value * 1;
        var fourthNumber = readFourth.value * 1;
        var fifthNumber = readFifth.value * 1;
        var greatestNumber = firstNumber;

        if (firstNumber * 0 === 0 && secondNumber * 0 === 0 &&
            thirdNumber * 0 === 0 && fourthNumber * 0 === 0 &&
            fifthNumber * 0 === 0) {

            if (greatestNumber < secondNumber) {
                greatestNumber = secondNumber;
            }
            if (greatestNumber < thirdNumber) {
                greatestNumber = thirdNumber;
            }
            if (greatestNumber < fourthNumber) {
                greatestNumber = fourthNumber;
            }
            if (greatestNumber < fifthNumber) {
                greatestNumber = fifthNumber;
            }
            WriteLine("The greatest of this 5 variables is: " +
                greatestNumber);
        } else {
            WriteLine("Please enter correct numbers!");
        }

    });
}