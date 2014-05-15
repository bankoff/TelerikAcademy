taskName = 'Functions-3';

function Main(bufferElement) {
    var text = 'We are living in an yellow submarine. In the sky there are no clouds. So we are drinking all the day. We will move out of it in 5 days.';
    var wordToSearch = ' in ';
    var isCaseSensitive = false;

    WriteLine(text);
    countOccurenceWord(text, wordToSearch);
    countOccurenceWord(text, wordToSearch, true);    
}

function countOccurenceWord(text, wordToSearch, isCaseSensitive) {
    var countSearchedWord;
    var strArr;
    isCaseSensitive = isCaseSensitive || false;   

    if (isCaseSensitive === false) {
        strArr = text.toLowerCase().split(wordToSearch);

        countSearchedWord = strArr.length - 1;
        WriteLine('The count of word "' + wordToSearch + '" (case-insensitive search)  is: ' + countSearchedWord);
    } else {
        strArr = text.split(wordToSearch);

        countSearchedWord = strArr.length - 1;
        WriteLine('The count of word "' + wordToSearch + '" (case-sensitive search)  is: ' + countSearchedWord);
    }
}