var browserName = navigator.appName;
var addScroll = false;
var pX = 0;
var pY = 0;

if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
    addScroll = true;
}

document.onmousemove = mouseMove;
if (browserName === "Netscape") {
    document.captureEvents(Event.MOUSEMOVE);
}

function mouseMove(evn) {
    'use strict';
    if (browserName === "Netscape") {
        pX = evn.pageX - 5;
        pY = evn.pageY;
        if (document.layers.ToolTip.visibility === 'show') {
            popTip();
        }
    } else {
        pX = event.x - 5;
        pY = event.y;
        if (document.all.ToolTip.style.visibility === 'visible') {
            popTip();
        }
    }
}

function popTip() {
    'use strict';
    var theLayer;

    if (browserName === "Netscape") {
        theLayer = eval('document.layers[\'ToolTip\']');
        if ((pX + 120) > window.innerWidth) {
            pX = window.innerWidth - 150;
        }

        theLayer.left = pX + 10;
        theLayer.top = pY + 15;
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'ToolTip\']');
        if (theLayer) {
            pX = event.x - 5;
            pY = event.y;
            if (addScroll) {
                pX = pX + document.body.scrollLeft;
                pY = pY + document.body.scrollTop;
            }

            if ((pX + 120) > document.body.clientWidth) {
                pX = pX - 150;
            }

            theLayer.style.pixelLeft = pX + 10;
            theLayer.style.pixelTop = pY + 15;
            theLayer.style.visibility = 'visible';
        }
    }
}

// union of the functions hideTip, hideMenu1 and hideMenu2, in order to reuse the code and not repeat it
function hide(input) {
    'use strict';
    if (browserName === "Netscape") {
        document.layers[input].visibility = 'hide';
    } else {
        document.all[input].style.visibility = 'hidden';
    }
}

// union of the functions showMenu1 and showMenu2, in order to reuse the code and not repeat it
function show(inputNetscape, inputOthers) {
    'use strict';
    var theLayer;

    if (browserName === "Netscape") {
        theLayer = eval(inputNetscape);
        theLayer.visibility = 'show';
    } else {
        theLayer = eval(inputOthers);
        theLayer.style.visibility = 'visible';
    }
}

function hideTip() {
    'use strict';
    hide('ToolTip');
}

function hideMenu1() {
    'use strict';
    hide('menu1');
}

function showMenu1() {
    'use strict';
    show('document.layers[\'menu1\']', 'document.all[\'menu1\']');
}

function hideMenu2() {
    'use strict';
    hide('menu2');
}

function showMenu2() {
    'use strict';
    show('document.layers[\'menu2\']', 'document.all[\'menu2\']');
}