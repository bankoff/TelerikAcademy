taskName = 'Strings-12';

function Main(bufferElement) {
    var template = document.getElementById("list-item").innerHTML;
    var people = [
        { name: "Georgi Ivanov", age: 15 },
        { name: "Lilyana Doneva", age: 64 },
        { name: "Konstantin Kostov", age: 43 }
    ];

    var ul = generateUnorderedList(people, template.trim());
    WriteLine(ul);
}

function createListItem(obj, template) {
    var result = "<li>";

    var pattern = /-{(\w+)}-/g;

    result += template.replace(pattern, function (match, capture) { return obj[capture]; });

    result += "</li>";
    return result;
}

function generateUnorderedList(objects, template) {
    var list = [];
    list.push("<ul>");

    var len = objects.length;

    for (var index = 0; index < len; index++) {
        var listItem = createListItem(objects[index], template);
        list.push(listItem);
    }

    list.push("</ul>");

    return list.join("");
}