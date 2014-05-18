taskName = 'Strings-6';

function Main(bufferElement) {
    var text = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

    WriteLine(extractContent(text));  
}

function extractContent(text) {
    var result = '';
    var countOfOpenedTags = 0;

    for (var i = 0; i < text.length; i++) {
        if (text[i] === '<') {
            countOfOpenedTags++;
            continue; //don`t print <
        }

        if (text[i] === '>') {
            countOfOpenedTags--;
            continue; //don`t print >
        }

        if (countOfOpenedTags == 0) {
            result = result + text[i];
        }
    }

    return result;
}