// Create a tag cloud:
// Visualize a string of tags (strings) in a given container
// By given minFontSize and maxFontSize, generate the tags with different font-size, depending on the number of occurrences
window.onload = function () {
    var tags = [
        "cms", "javascript", "js", "ASP.NET", ".net", ".net", "css", "wordpress",
        "xaml", "js", "http", "http", "http", "web", "asp.net", "wp", "javascript",
        "js", "js", "cms", "html", "javascript", "http", "http", "CMS"
    ];

    var cloud = document.getElementById('cloud');

    generateTagCloud(tags, 17, 42);

    function generateTagCloud(tags, minFontSize, maxFontSize) {

        var counterArr = countTags(tags);

        for (var tag in counterArr) {
            var result = document.createElement('span');
            result.style.fontSize = counterArr[tag] <= 1 ? minFontSize :
            (counterArr[tag] >= maxFontSize ? maxFontSize :
                minFontSize + counterArr[tag] * 5) + 'px';

            result.appendChild(document.createTextNode(tag + ' '));
            cloud.appendChild(result);
        }

        return false;
    }

    function countTags(tags) {

        //associative array
        var tagsCount = {},
            tag;

        for (var i in tags) {
            tag = tags[i].toLowerCase();
            if (tagsCount[tag]) {
                tagsCount[tag]++;
            } else {
                tagsCount[tag] = 1;
            }
        }

        return tagsCount;
    }
};