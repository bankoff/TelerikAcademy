taskName = 'UsingObjects-6';

function Main(bufferElement) {
    var people = [];
    var groups;

    people.push(new Person('Ivo', 'Mihov', 12));
    people.push(new Person('Kiro', 'Yanev', 12));
    people.push(new Person('Ivo', 'Savov', 17));
    people.push(new Person('Dimo', 'Mihov', 12));

    groups = group(people, 'firstName');
    printGroup(groups);
    groups = group(people, 'lastName');
    printGroup(groups);
    groups = group(people, 'age');
    printGroup(groups);
}

function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.toString = function () {
        return 'FirstName: ' + this.firstName +
                ' LastName: ' + this.lastName +
                ' Age: ' + this.age;
    };
}

function group(people, prop) {
    var groups = {};

    switch (prop) {
        case 'firstName':
        case 'lastName':
        case 'age': {
            people.map(function (p) {
                if (!groups[p[prop]])
                    groups[p[prop]] = new Array();
                groups[p[prop]].push(p);
            });
            break;
        }
        default:
            WriteLine('No such property in Person.');
    }

    return groups;
}

function printGroup(groups) {
    for (var peoples in groups) {
        Write('Group key: ');
        WriteLine(peoples);
        WriteLine('People: ');

        for (var people in groups[peoples]) {
            WriteLine(groups[peoples][people]);
        }

        WriteLine();
    }
}