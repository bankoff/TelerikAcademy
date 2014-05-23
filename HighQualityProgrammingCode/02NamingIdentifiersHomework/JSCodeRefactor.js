function onButtonClickEvent(event, args) {
    var myWindow = window;
    var browser = myWindow.navigator.appCodeName;
    var isMozilla = browser === 'Mozilla';

    if (isMozilla) {
        alert('Yes');
    } else {
        alert('No');
    }
}