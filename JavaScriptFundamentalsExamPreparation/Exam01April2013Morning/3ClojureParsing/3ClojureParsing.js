//BGCoder 100/100

function Solve(input) {
    var finalResult;
    var functions = [];

    for (var i = 0; i < input.length; i++) {
        var currentRow = input[i].trim();

        var operator = '';
        var nestedOperator = '';
        var currentDigit = '';
        var currentFunctionName = '';
        var currentNewFunction = '';

        var parameters = [];
        var nestedParameters = [];

        var inCommand = false;
        var inNestedCommand = false;

        for (var j = 0; j < currentRow.length; j++) {
            var currentSymbol = currentRow[j];

            if (currentSymbol == ' ' || currentSymbol == ')') {
                if (currentFunctionName !== '') {
                    //if (functions[currentFunctionName]||functions[currentFunctionName]===0) {
                    if (functions[currentFunctionName] != undefined) {
                        var functionResult = functions[currentFunctionName];
                        if (inNestedCommand) {
                            nestedParameters.push(functionResult);
                        } else {
                            parameters.push(functionResult);
                        }
                    } else {
                        currentNewFunction = currentFunctionName;
                    }

                    currentFunctionName = '';
                }

                if (currentDigit !== '') {
                    if (inNestedCommand) {
                        nestedParameters.push(parseInt(currentDigit));
                    } else {
                        parameters.push(parseInt(currentDigit));
                    }

                    currentDigit = '';
                }

                if (currentSymbol == ')' && currentNewFunction !== '') {
                    var result;
                    if (inNestedCommand) {
                        result = calculate(nestedOperator, nestedParameters);
                    } else {
                        result = calculate(operator, parameters);
                    }

                    //if (result == 'Error') {
                    //    return 'Division by zero! At Line:' + (i + 1);
                    //}

                    if (currentNewFunction !== 'def') {
                        functions[currentNewFunction] = result;
                    }

                    currentNewFunction = '';
                }

                if (inNestedCommand && currentSymbol == ')') {
                    var nestedResult = calculate(nestedOperator, nestedParameters);
                    parameters.push(nestedResult);
                    nestedParameters = [];
                    nestedOperator = '';
                    inNestedCommand = false;
                }

                continue;
            }

            if (currentSymbol == '(') {
                if (inCommand) {
                    inNestedCommand = true;
                } else {
                    inCommand = true;
                }

                continue;
            }

            if (isMathOperator(currentSymbol)) {
                if (currentSymbol == '-' && j + 1 < currentRow.length && isNumber(currentRow[j + 1])) {
                    currentDigit += currentSymbol;
                } else {
                    if (inNestedCommand) {
                        nestedOperator = currentSymbol;
                    } else {
                        operator = currentSymbol;
                    }
                }

                continue;
            }

            if (isNumber(currentSymbol)) {
                if (currentFunctionName != '') {
                    currentFunctionName += currentSymbol;
                } else {
                    currentDigit += currentSymbol;
                }

                continue;
            }

            currentFunctionName += currentSymbol;
        }

        //********************************************************//

        finalResult = calculate(operator, parameters);

        if (finalResult == 'Error') {
            return 'Division by zero! At Line:' + (i + 1);
        }

        //console.log(finalResult);
    }

    return finalResult;

    function isNumber(symbol) {
        if (symbol == ' ') {
            return false;
        }

        if (symbol == Number(symbol)) {
            return true;
        }

        return false;
    }

    function isMathOperator(symbol) {
        if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/') {
            return true;
        }

        return false;
    }

    function calculate(operator, parameters) {
        if (parameters.length == 1) {
            return parameters[0];
        }

        var result = parameters[0];
        for (var i = 1; i < parameters.length; i += 1) {
            switch (operator) {
                case '+':
                    result += parameters[i];
                    break;
                case '-':
                    result -= parameters[i];
                    break;
                case '*':
                    result *= parameters[i];
                    break;
                case '/':
                    if (parameters[i] == 0) {
                        return 'Error';
                    }

                    //TODO: check this parseInt
                    result /= parameters[i];
                    result = parseInt(result);
                    break;
            }
        }

        return result;
    }
}


//var test = [
//    '(+ 5 6 ( * 1 1 1) -7)',
//    '(- 3 4 -5)',
//    '(/ 8 99 0)',
//    '(* 5 6 2)'
//];

//var test1 = [
//    '(def func 10)',
//    '(def newFunc (+  func 2))',
//    '(def sumFunc (+ func func newFunc 0 0 0))',
//    '(* sumFunc 2)'
//];

//var test2 = [
//    '(def func (+ 5 2))',
//    '(def func2 (/  func 5 2 1 0))',
//    '(def func3 (/ func 2))',
//    '(+ func3 func)'
//];

//var test4 = [
//    '(def fun 0)',
//    '(def emo (/ 5 fun))',
//    '(def ivo emo)'
//];

//console.log(Solve(test4));