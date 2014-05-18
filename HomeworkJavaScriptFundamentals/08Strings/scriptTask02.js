taskName = 'Strings-2';

function Main(bufferElement) {
    var correctExpression = '((a+b)/5-d)';
    var incorrectExpression = ')(a+b))';

    WriteLine('The brackets in the expression are put correctly: ' +
            correctExpression);
    WriteLine(checkBrackets(correctExpression));
    WriteLine();
    WriteLine('The brackets in the expression are put correctly: ' +
            incorrectExpression);
    WriteLine(checkBrackets(incorrectExpression));    
}

function checkBrackets(input) {
    var countBrackets = 0;

    for (var i = 0; i < input.length; i++) {
        if (input[i] == '(') {  
            countBrackets++;
        }

        if (input[i] == ')') {
            countBrackets--;  
        }

        //if we have closing bracket before opening one, it`s a mistake and countBrackets will be<0
        if (countBrackets < 0) {
            return false;
        }
    }

    //if in the end opening and closing brackets are the same number, the brackets are correctly put
    if (countBrackets == 0) {
        return true;
    }

    return false;
}