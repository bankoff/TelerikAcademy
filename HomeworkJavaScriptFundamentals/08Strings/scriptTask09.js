taskName = 'Strings-9';

function Main(bufferElement) {
    var input = 'Please contact by email at ivo_anev@abv.bg or at ana.konda@yahoo.co.uk. This is not email: first@start. This also: @google.com. Neither this: a@b.c.';

    WriteLine("The input is: ");
    WriteLine(input);
    WriteLine();
    WriteLine("The valid emails are: ");
    WriteLine(extractEmails(input));
}

function extractEmails(input) {
    var regex = /\b\w+[\w\-]*(\.\w+[\w\-]*)*@[a-z0-9]+[a-z0-9-]*(\.[a-z0-9]+[a-z0-9-]*)*(\.[a-z]{2,6})\b/g;
    var matches = [];
    var match;

    while (match = regex.exec(input)) {
        matches.push(match[0]);
    }

    return matches;
}