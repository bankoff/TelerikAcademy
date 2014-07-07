var specialConsole = (function () {
    function writeLine(message, holderElements) {
        var msg = message;

        msg = placeHolder(arguments);
        console.log(msg.toString());
    }

    function writeWarning(message, holderElements) {
        var msg = message;

        msg = placeHolder(arguments);
        console.warn(msg.toString());
    }

    function writeError(message, holderElements) {
        var msg = message;


        msg = placeHolder(arguments);
        console.error(msg.toString());
    }

    function placeHolder(input) {
        var format = input[0];

        for (var i in input) {
            while (format.indexOf('{' + i + '}') != -1) {
                format = format.replace('{' + i + '}', input[i * 1 + 1]);
            }
        }

        return format;
    }

    return {
        writeLine: writeLine,
        writeWarning: writeWarning,
        writeError: writeError
    };
}());