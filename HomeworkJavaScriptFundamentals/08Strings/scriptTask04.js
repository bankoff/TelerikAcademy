﻿taskName = 'Strings-4';

function Main(bufferElement) {
    var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

    text = applyTags(text, '<upcase>', '</upcase>', applyUpCaseTags);
    text = applyTags(text, '<lowcase>', '</lowcase>', applyLowCaseTags);
    text = applyTags(text, '<mixcase>', '</mixcase>', applyMixCaseTags);

    WriteLine(text);
}

function removeAdditionalWhiteSpaces(text) {
    return text.replace(/\s{2,}/ig, ' ');
}

function removeAllTags(text) {
    return text.replace(/<.+?case>/ig, '');
}

function applyTags(text, openTagName, closeTagName, action) {
    var openTagIndexes = [],
        lastOccurance = text.indexOf(openTagName),
        nextOpenTagIndex,
        nextCloseTagIndex,
        originalBlock,
        updateBlock;

    if (lastOccurance > -1) {
        openTagIndexes.push(lastOccurance);
    }

    while (openTagIndexes.length > 0) {

        lastOccurance = openTagIndexes[openTagIndexes.length - 1];
        nextOpenTagIndex = text.indexOf(openTagName, lastOccurance +
                                        openTagName.length);
        nextCloseTagIndex = text.indexOf(closeTagName, lastOccurance +
                                        openTagName.length);

        if (nextCloseTagIndex < nextOpenTagIndex || nextOpenTagIndex === -1) {
            originalBlock = text.substring(lastOccurance, nextCloseTagIndex + closeTagName.length);
            updateBlock = removeAllTags(originalBlock);
            updateBlock = removeAdditionalWhiteSpaces(updateBlock);
            updateBlock = action(updateBlock);
            text = text.replace(originalBlock, updateBlock);
            openTagIndexes.pop();

            if (nextOpenTagIndex !== -1 && openTagIndexes.length === 0) {
                openTagIndexes.push(text.indexOf(openTagName, lastOccurance + openTagName.length));
            }

        } else {
            openTagIndexes.push(nextOpenTagIndex);
        }
    }

    text = removeAdditionalWhiteSpaces(text).trim();
    return text;
}

function applyUpCaseTags(text) {
    return text.toUpperCase();
}

function applyLowCaseTags(text) {
    return text.toLowerCase();
}

function applyMixCaseTags(text) {
    var result = '',
        i,
        tmpRand;

    for (i = 0; i < text.length; i += 1) {
        tmpRand = parseInt(Math.random() * 2);

        if (tmpRand === 0) {
            result += text[i].toUpperCase();
        } else {
            result += text[i].toLowerCase();
        }
    }

    return result;
}