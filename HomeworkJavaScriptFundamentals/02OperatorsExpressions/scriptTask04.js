﻿taskName = "OperatorsAndExpressions-4";

function Main(bufferElement) {
    var readNumber = ReadLine("Please enter one integer number: ");
    var digitIs7 = false;

    SetSolveButton(function () {
        var intNumber = readNumber.value * 1;
        if (intNumber % 1 !== 0) {
            WriteLine("Please enter correct integer number");
        } else {
            for (var i = 0; i < 2; i++) {
                intNumber = (intNumber - intNumber % 10) / 10;
            }

            WriteLine(Format("The third digit (right-to-left) is " +
                Math.abs(intNumber % 10)));

            if (Math.abs(intNumber % 10) === 7) digitIs7 = true;
            WriteLine(Format("Is third digit (right-to-left) 7 -> " +
                digitIs7));
        }
    });
}