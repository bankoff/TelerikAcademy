taskName = 'Strings-5';

function Main(bufferElement) {
    var input = "Nice blue sky and warm sun shining";
    var textToReplace = "&nbsp;";

    WriteLine(input);
    WriteLine(replaceWhiteSpace(input, textToReplace));    
}

function replaceWhiteSpace(input, textToReplace) {
    var splittedText = input.split(' ');
    var result = splittedText.join(textToReplace);

    return result;
}