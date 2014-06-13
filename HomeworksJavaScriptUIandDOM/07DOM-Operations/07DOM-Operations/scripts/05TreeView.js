// Create a TreeView component
// Initially only the top items must be visible
// On item click
// If its children are hidden (collapsed), they must be made visible (expanded)
// If its children are visible (expanded), they must be made hidden (collapsed)
// Research about events
window.onload = (function () {
    var a = document.createElement('style');
    a.innerHTML = 'li{list-style-type:none}';
    document.head.appendChild(a);

    var treeView = document.createElement('ul');
    treeView.innerHTML = 'Unordered list';
    document.body.appendChild(treeView);

    addLi(0, treeView, 'List Item ');

    function addLi(depth, parent, text) {
        for (var i = 0; i < 3; i++) {
            var li = document.createElement('li');
            var liTxt = text + (i + 1);
            li.innerHTML = liTxt;
            var ul = document.createElement('ul');
            if (depth < 3) {
                addLi(depth + 1, ul, liTxt + '.');
            }
            li.appendChild(ul);
            parent.appendChild(li);
        }
    }

    var allLi = document.getElementsByTagName('li');

    for (var i = 0; i < allLi.length; i++) {
        var li = allLi[i].firstElementChild;

        while (li) {
            li.style.display = 'none';
            li = li.nextElementSibling;
        }

        allLi[i].addEventListener('click', function (event) {

            event.stopPropagation();

            var currentLi = this.firstElementChild;

            while (currentLi) {
                if (currentLi.style.display == 'none') {
                    currentLi.style.display = '';
                }
                else {
                    currentLi.style.display = 'none';
                }

                currentLi = currentLi.nextElementSibling;
            }
        });
    }
})();

