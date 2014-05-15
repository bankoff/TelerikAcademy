taskName = 'UsingObjects-3';

function Main(bufferElement) {
    var arr1 = new Array(5, -2, 1, 14, 7); //array is object
    var person1 = {
        name: {
            firstName: 'Ivanka',
            lastName: 'Petrova'
        },
        age: 20
    };

    var arr2 = deepCopy(arr1);
    WriteLine('Original array:');
    printObj(arr1); //print original
    WriteLine(new Array(41).join('-'));
    WriteLine('Cloned array:');
    printObj(arr2); //print clone
    WriteLine(new Array(71).join('*'));

    arr2[2] = 7; //change element to see whether original will stay the same
    WriteLine('Original array after change of cloned:');
    printObj(arr1); //print original
    WriteLine(new Array(41).join('-'));
    WriteLine('Cloned array after change:');
    printObj(arr2); //print clone
    WriteLine(new Array(71).join('*'));

    var person2 = deepCopy(person1);
    WriteLine('Original Person:');
    printObj(person1); //print original
    WriteLine(new Array(41).join('-'));
    WriteLine('Cloned Person:');
    printObj(person2); //print clone
    WriteLine(new Array(71).join('*'));

    person2.name.lastName = 'Dimitrova';  //change the lastName of clone to see whether the clone is deep
    WriteLine('Original Person:');
    printObj(person1); //print original
    WriteLine(new Array(41).join('-'));
    WriteLine('Cloned Person after change:');
    printObj(person2); //print clone
    WriteLine(new Array(71).join('*'));
}

function deepCopy(obj) {
    var newObj = new Object(); //new empty object
    var key;

    for (key in obj) {
        newObj[key] = obj[key];

        if ((typeof obj[key]) == 'object') {
            newObj[key] = deepCopy(obj[key]); //recursion if we have to copy object in object call the same function again
        }
    }

    return newObj;
}

function printObj(obj) {
    var key;

    for (key in obj) {
        WriteLine('Property ' + key + ': ' + obj[key]);
        if (typeof (obj[key]) == 'object') {
            printObj(obj[key]);
        }
    }

    WriteLine();
}