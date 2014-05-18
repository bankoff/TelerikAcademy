taskName = 'Strings-10';

function Main(bufferElement) {
    var text = ".exe is common filename extension denoting an executable file. Ces frontaliers veulent changer de système de couverture santé et prendre un contrat LAMAL. ABBA was Swedish pop group formed in Stockholm in 1972.";
    WriteLine(text);
    WriteLine();
    Write('Palindromes: ');
    WriteLine(findPalindromes(text));
}

function findPalindromes(text) {
    var palindromesArr = new Array();
    var words = text.split(/[\s,.?!-()]/g);

    for (var k = 0; k < words.length; k++) {
        var isPalindrome = true;

        for (var i = 0; i < words[k].length / 2; i++) {
            if (words[k][i] !== words[k][words[k].length - 1 - i]) {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome == true && words[k] !== '') {
            palindromesArr.push(words[k]);
        }
    }

    return palindromesArr;
}

