taskName = 'Loops-4';

function Main(bufferElement) {
    var objects = [Document, Window, Navigator];

    for (var i = 0; i < objects.length; i += 1) {
        WriteLine(new Array(71).join('*'));
        printPropeties(objects[i]);
        WriteLine();
        WriteLine(Format('Largest property in {0} is: {1}',
                objects[i].name, searchMax(objects[i])));
        WriteLine(Format('Smallest property in {0} is: {1}',
                objects[i].name, searchMin(objects[i])));
        WriteLine();
    }
}

function printPropeties(obj) {
    var property;

    WriteLine(Format('Properties in {0} are: ', obj.name));
    for (property in obj) {
        WriteLine(property);
    }
}

function searchMin(obj) {
    var property,
        smallestProperty = '';

    for (property in obj) {
        if (!smallestProperty ||
               smallestProperty.toLowerCase() > property.toLowerCase()) {
            smallestProperty = property;
        }
    }

    return smallestProperty;
}

function searchMax(obj) {
    var property,
        largestProperty = '';

    for (property in obj) {
        if (!largestProperty ||
                largestProperty.toLowerCase() < property.toLowerCase()) {
            largestProperty = property;
        }
    }

    return largestProperty;
}