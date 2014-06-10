// Write a script that shims querySelector and querySelectorAll in older browsers

(function () {
    function querySelectorAll(selector) {
        if (/^[\w-]+$/.test(selector)) {
            return toArray(document.getElementsByTagName(selector));

        } else if (/^#[\w-]+$/.test(selector)) {
            return [document.getElementById(selector.slice(1))];

        } else if (/^\.[\w-]+$/.test(selector)) {
            var allEls = toArray(document.getElementsByTagName('*')),
                                className = selector.slice(1),
                                pattern = new RegExp('\\b' + className + '\\b');

            return allEls.filter(function (item) {
                return pattern.test(item.className);
            });
        }
    }

    if (typeof document.querySelectorAll !== 'function') {
        document.querySelectorAll = querySelectorAll;
    }

    document.querySelectorAllShim = querySelectorAll;

    function querySelector(selector) {
        return querySelectorAll(selector)[0];
    }

    if (typeof document.querySelectorAll !== 'function') {
        document.querySelectorAll = querySelectorAll;
    }

    document.querySelectorShim = querySelector;

    function toArray(list) {
        return Array.prototype.slice.call(list || []);
    }

    // test of program
    console.log('These are all divs selected with querySelectorAll');
    console.dir(querySelectorAll('div'));
    console.log('This is the count of divs selected with querySelectorAll');
    console.log(querySelectorAll.length);

    console.log('This is the element selected with querySelector');
    console.log(querySelector('#second'));
})();