taskName = 'UsingObjects-5';

function Main(bufferElement) {
    var persons = [
        { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
        { firstname: 'Bay', lastname: 'Ivan', age: 81 },
        { firstname: 'Penka', lastname: 'Pavlova', age: 13 },
        { firstname: 'Dimana', lastname: 'Todorova', age: 43 }
    ];

    (findYoungest(persons));
}

function findYoungest(persons) {
    var indexYoungest = 0;
    var ageYongest = persons[0].age;

    for (var i = 1; i < persons.length; i++) {
        if (persons[i].age < ageYongest) {
            ageYongest = persons[i].age;
            indexYoungest = i;
        }
    }

    WriteLine('The youngest person is: ' + persons[indexYoungest].firstname + ' ' +
        persons[indexYoungest].lastname + ' Age:' + persons[indexYoungest].age);
}