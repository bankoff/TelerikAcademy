taskName = "ConditionalStatements-5";

function Main(bufferElement) {
    var readDigit = ReadLine("Please enter one digit: ");

    SetSolveButton(function () {
        switch (readDigit.value) {
            case '0': WriteLine("The digit is zero"); break;
            case '1': WriteLine("The digit is one"); break;
            case '2': WriteLine("The digit is two"); break;
            case '3': WriteLine("The digit is three"); break;
            case '4': WriteLine("The digit is four"); break;
            case '5': WriteLine("The digit is five"); break;
            case '6': WriteLine("The digit is six"); break;
            case '7': WriteLine("The digit is seven"); break;
            case '8': WriteLine("The digit is eight"); break;
            case '9': WriteLine("The digit is nine"); break;
            default: WriteLine("This is not a digit"); break;
        }
    });
}