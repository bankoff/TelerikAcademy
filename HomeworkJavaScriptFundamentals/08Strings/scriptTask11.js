taskName = 'Strings-11';

function Main(bufferElement) {
    var str = stringFormat("Hello {0}!", "Peter");
    WriteLine(str);

    var format = "{0}, {1}, {0} text {2}";
    str = stringFormat(format, 1, "Pesho", "Gosho");
    WriteLine(str);   
}

function stringFormat(str) {
    var selfArguments = arguments;

    return str.replace(/\{(\d+)\}/g, function(match, arg) {
        return selfArguments[+arg + 1];
    });
}