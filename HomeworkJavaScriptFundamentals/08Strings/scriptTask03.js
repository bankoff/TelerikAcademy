taskName = 'Strings-3';

function Main(bufferElement) {
    var input = "We are living in an yellow submarine. We don't have " +
            "anything else. Inside the submarine is very tight. So we " +
            "are drinking all the day. We will move out of it in 5 days.";
    var searchStr = new RegExp("in", "gi"); //i in gi means insensitive search, g means Perform a global match (find all matches rather than stopping after the first match)

    WriteLine(countOccurences(input, searchStr));
}

function countOccurences(input, searchedStr) {
    return input.match(searchedStr).length;
}