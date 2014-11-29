(function() {
    var sheep,
        scoresAndName = [],
        users = [],
        scores,
        clearLocalstorageButton = document.getElementById('clear-localstorage'),
        showScores = document.getElementById('show-highscores'),
        fieldForScores = document.getElementById('scores'),
        guessedTheNumberField = document.getElementById('result'),
        historyField = document.getElementById('rigth-side'),
        tryButton = document.getElementById('try'),
        errorField = document.getElementById('error'),
        gameHistory = '',
        numberLen = 4,
        minNumber = 1023,
        maxNumber = 9876,
        generatedNumber = generateNumber(),
        newGameButton = document.getElementById('new-game');

    startNewGame();

    updateUsers();

    newGameButton.addEventListener('click', startNewGame);
    tryButton.addEventListener('click', checkForSheepOrRam);
    clearLocalstorageButton.addEventListener('click', function() {
        localStorage.clear();
        users = [];
        fieldForScores.innerHTML = 'Scores:';
    });
    showScores.addEventListener('click', updateButtonForShowingResults);

    function startNewGame() {
        guessedTheNumberField.innerHTML = '';
        historyField.innerHTML = '';
        gameHistory = '';
        fieldForScores.innerHTML = 'Scores:';
        generatedNumber = generateNumber();
        console.log(generatedNumber);
        document.getElementById('input-number').value = '';
        scores = 1010;
    }

    function generateNumber() {
        var number = 9999;

        while (hasRepeatedDigits(number.toString())) {
            number = Math.floor(Math.random() * (maxNumber - minNumber)) + minNumber;
        }

        return number.toString();
    }

    function hasRepeatedDigits(numberStr) {
        var i,
            j;

        for (i = 0; i < numberLen - 1; i += 1) {
            for (j = i + 1; j < numberLen; j += 1) {
                if (numberStr[i] === numberStr[j]) {
                    return true;
                }
            }
        }

        return false;
    }

    function checkForSheepOrRam() {
        var inputString = document.getElementById('input-number').value,
            i,
            sheep = 0,
            rams = 0;

        if (isValidNumber(inputString)) {
            scores -= 10;
            errorField.innerHTML = "";

            for (i = 0; i < numberLen; i++) {
                if (inputString[i] === generatedNumber[i]) {
                    rams++;
                }
            }

            for (i = 0; i < numberLen; i++) {
                if (generatedNumber.indexOf(inputString[i]) > -1) {
                    sheep++;
                }
            }

            updateResultFields(rams, sheep - rams);
        } else {
            errorField.innerHTML = 'Not a valid number!';
        }
    }

    function isValidNumber(inputString) {
        var inputNumber = parseInt(inputString);
        if (inputString.length === numberLen && !isNaN(inputNumber) && minNumber <= inputNumber && inputNumber <= maxNumber && !hasRepeatedDigits(inputString)) {
            return true;
        } else {
            return false;
        }
    }

    function updateUsers() {
        if (localStorage.getItem('users') !== null) {
            users = JSON.parse(localStorage.getItem('users'));
        }
    }

    function updateResultFields(rams, sheep) {
        gameHistory = 'You have ' + rams + ' rams and ' + sheep + ' sheeps' + '<br>' + gameHistory;
        historyField.innerHTML = gameHistory;

        if (rams === 4) {
            guessedTheNumberField.innerHTML = 'You guessed the number ' + generatedNumber + ' !';
            if (showScores.innerHTML === 'Show highscores!') {
                updateButtonForShowingResults();
            }
            if (scores < 0) {
                scores = 0;
            }

            addToTopScores(scores);
        }
    }

    function checkIfUserNameIsValid(username) {
        for (var i = 0; i < users.length; i++) {
            if (users[i] === username) {
                return false;
            }
        }

        return true;
    }

    function addToTopScores(scores) {
        var personName = prompt("Please enter your nickname");
        if (personName === '' || personName === null) {
            personName = 'unnamed';
        }

        var name = personName;

        var nameAndScores = {
            'name': name,
            'scores': scores
        };

        users.push(nameAndScores);

        localStorage.setItem('users', JSON.stringify(users));

        updateScoresInnerHtml();
    }

    function sortUsers(sortBy) {
        var exchangeValues;

        for (var i = 0; i < users.length - 1; i++) {
            for (var j = i + 1; j < users.length; j++) {
                if (users[j][sortBy] > users[i][sortBy]) {
                    exchangeValues = users[i];
                    users[i] = users[j];
                    users[j] = exchangeValues;
                }
            }
        }
    }

    function updateButtonForShowingResults() {
        if (showScores.innerHTML === 'Show highscores!') {
            updateScoresInnerHtml();
            showScores.innerHTML = 'Hide highscores!';
        } else {
            fieldForScores.innerHTML = 'Scores:';
            showScores.innerHTML = 'Show highscores!';
        }
    }

    function updateScoresInnerHtml() {
        if (users.length === 0) {
            updateUsers();
        }

        sortUsers('scores');

        fieldForScores.innerHTML = 'Scores:';
        for (var i = 0; i < users.length; i++) {
            fieldForScores.innerHTML +=
                '<br>' +
                (i + 1) + ')   ' +
                users[i].name + ' -> ' +
                users[i].scores + ' scores';
        }
    }

})();