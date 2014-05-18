taskName = 'Strings-8';

function Main(bufferElement) {
    var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

    WriteLine(replaceTags(text));
}

function replaceTags(text) {
    var indexClosingA = text.indexOf('</a>');

    text = text.replace(/<a href="/g, '[URL=');

    while (indexClosingA > -1) {
        text = text.replace('</a>', '[/URL]');
        indexClosingA = text.indexOf('</a>', indexClosingA + 1);
    }

    text = text.replace(/">/g, ']');
    return text;
}