taskName = "ConditionalStatements-8";

function Main(bufferElement) {
    var readNumber = ReadLine("Please enter number in range [0..999]: ");

    SetSolveButton(function () {
        var number = readNumber.value * 1;
        var firstDigit, secondDigit, thirdDigit;
        var firstDigitStr, secondDigitStr, thirdDigitStr;

        if (number === 0) {
            WriteLine("The number is zero");
        } else if (number % 1 === 0 && number > 0 && number < 1000) {
            firstDigit = Math.floor(number/100);

            secondDigit = Math.floor((number - firstDigit * 100) / 10);

            thirdDigit = number - firstDigit * 100 - secondDigit * 10;

            if (secondDigit == 1) {
                thirdDigitStr = "";
            } else {
                switch (thirdDigit) {
                    case 0: thirdDigitStr = ""; break;
                    case 1: thirdDigitStr = "one"; break;
                    case 2: thirdDigitStr = "two"; break;
                    case 3: thirdDigitStr = "three"; break;
                    case 4: thirdDigitStr = "four"; break;
                    case 5: thirdDigitStr = "five"; break;
                    case 6: thirdDigitStr = "six"; break;
                    case 7: thirdDigitStr = "seven"; break;
                    case 8: thirdDigitStr = "eight"; break;
                    case 9: thirdDigitStr = "nine"; break;
                    default: break;
                }
            }

            switch (secondDigit) {
                case 0: secondDigitStr = ""; break;
                case 1: switch (thirdDigit) {
                    case 0: secondDigitStr = "ten"; break;
                    case 1: secondDigitStr = "eleven"; break;
                    case 2: secondDigitStr = "twelve"; break;
                    case 3: secondDigitStr = "thirteen"; break;
                    case 4: secondDigitStr = "fourteen"; break;
                    case 5: secondDigitStr = "fifteen"; break;
                    case 6: secondDigitStr = "sixteen"; break;
                    case 7: secondDigitStr = "seventeen"; break;
                    case 8: secondDigitStr = "eighteen"; break;
                    case 9: secondDigitStr = "nineteen"; break;
                    default: break;
                } break;
                case 2: secondDigitStr = "twenty"; break;
                case 3: secondDigitStr = "thirty"; break;
                case 4: secondDigitStr = "forty"; break;
                case 5: secondDigitStr = "fifty"; break;
                case 6: secondDigitStr = "sixty"; break;
                case 7: secondDigitStr = "seventy"; break;
                case 8: secondDigitStr = "eighty"; break;
                case 9: secondDigitStr = "ninety"; break;
                default: break;
            }

            switch (firstDigit) {
                case 0: firstDigitStr = ""; break;
                case 1: firstDigitStr = "one hundred"; break;
                case 2: firstDigitStr = "two hundred"; break;
                case 3: firstDigitStr = "three hundred"; break;
                case 4: firstDigitStr = "four hundred"; break;
                case 5: firstDigitStr = "five hundred"; break;
                case 6: firstDigitStr = "six hundred"; break;
                case 7: firstDigitStr = "seven hundred"; break;
                case 8: firstDigitStr = "eight hundred"; break;
                case 9: firstDigitStr = "nine hundred"; break;
                default: break;
            }

            if ((Math.floor(number / 100) * 100 != number) && (number >= 100)) {
                WriteLine(Format("The number is: {0} and {1} {2}",
                    firstDigitStr, secondDigitStr, thirdDigitStr));
            } else {
                WriteLine(Format("The number is: {0} {1} {2}",
                    firstDigitStr, secondDigitStr, thirdDigitStr));
            }
        } else {
            WriteLine("Please enter correct number!");
        }
    });
}