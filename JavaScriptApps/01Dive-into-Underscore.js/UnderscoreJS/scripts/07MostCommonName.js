// By an array of people find the most common first and last name. Use underscore.

(function () {
    var Person = Object.create({
        init: function (firstName, lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
            return this;
        }
    });

    var people = [
        Object.create(Person).init("Nikolay", "Kostov"),
        Object.create(Person).init("Doncho", "Minkov"),
        Object.create(Person).init("Ivaylo", "Kenov"),
        Object.create(Person).init("Todor", "Stoyanov"),
        Object.create(Person).init("Nikolay", "Mihaylov"),
        Object.create(Person).init("Pavel", "Kolev"),
        Object.create(Person).init("Dimitar", "Kostov"),
        Object.create(Person).init("Nikolay", "Nikolov"),
        Object.create(Person).init("Ivaylo", "Kostov"),
        Object.create(Person).init("George", "Kostov")
    ];

    var mostCommonFirstName = _.chain(people)
        .countBy(function (person) { return person.firstName; })
        .invert()
        .values()
        .last()
        .value();

    console.log('The most common first name is ' + mostCommonFirstName);

    var mostCommonLastName = _.chain(people)
        .countBy(function (person) { return person.lastName; })
        .invert()
        .values()
        .last()
        .value();

    console.log('The most common last name is ' + mostCommonLastName);
})();