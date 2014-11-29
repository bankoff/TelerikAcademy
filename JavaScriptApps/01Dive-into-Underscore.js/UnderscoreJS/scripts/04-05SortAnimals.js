// Task 4: Write a function that by a given array of animals, groups them by species and sorts them by number of legs-->
// Task 5: By a given array of animals, find the total number of legs
//         Each animal can have 2, 4, 6, 8 or 100 legs

(function () {
    var Animal = Object.create({
        init: function (species, genus, numberOfLegs) {
            this.species = species;
            this.genus = genus;
            this.numberOfLegs = numberOfLegs;
            return this;
        }
    });

    var animals = [
        Object.create(Animal).init("Amphibian", "Frog", 4),
        Object.create(Animal).init("Insect", "Wasp", 6),
        Object.create(Animal).init("Mammal", "Cat", 4),
        Object.create(Animal).init("Mammal", "Lion", 4),
        Object.create(Animal).init("Insect", "Spider", 8),
        Object.create(Animal).init("Bird", "Turkey", 2),
        Object.create(Animal).init("Insect", "Mosquito", 6),
        Object.create(Animal).init("Bird", "Duck", 2),
        Object.create(Animal).init("Insect", "Millipede", 100)
    ];


    _.chain(animals)
        .sortBy("numberOfLegs")
        .groupBy(function (animal) { return animal.species; })
        .each(function (animalSpecies) {
            console.log(animalSpecies[0].species);
            console.log(new Array(10).join('-'));

            _.each(animalSpecies, function (animal) {
                console.log(animal.genus + ' --> ' + animal.numberOfLegs + ' legs');
            });

            console.log(new Array(25).join('*'));

        });

    var numberOflegs = _.chain(animals)
                        .pluck('numberOfLegs')
                        .reduce(function (number, memo) { return number += memo; }, 0)
                        .value();

    console.log('Total number of legs is: ' + numberOflegs);
}());