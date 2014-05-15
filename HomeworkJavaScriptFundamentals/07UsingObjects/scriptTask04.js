taskName = 'UsingObjects-4';

function Main(bufferElement) {
    var arr = new Array(1, 2, 1, 3, 2, 4); //array is object
    var person = {
        name: {
            firstName: 'Ivanka',
            lastName: 'Petrova'
        },
        age: 20
    };
    var prop;
    var hasProp;

    prop = 'length';
    hasProp = hasProperty(arr, prop); //check if array has length
    WriteLine('Array has property ' + prop + ' :' + hasProp);

    hasProp = hasProperty(person, prop);//check if person has length
    WriteLine('Person has property ' + prop + ' :' + hasProp);

    prop = 'name';
    hasProp = hasProperty(arr, prop); //check if array has property name
    WriteLine('Array has property ' + prop + ' :' + hasProp);

    hasProp = hasProperty(person, prop); //check if person has property name
    WriteLine('Person has property ' + prop + ' :' + hasProp);
}

function hasProperty(obj, prop) {
    if (obj.hasOwnProperty(prop)) {
        return true;
    }

    return false;
}