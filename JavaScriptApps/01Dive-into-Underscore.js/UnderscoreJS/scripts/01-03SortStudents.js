// Task 1: Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. 
//         Print the students in descending order by full name. Use Underscore.js
// Task 2: Write function that finds the first name and last name of all students with age between 18 and 24. Use Underscore.js
// Task 3: Write a function that by a given array of students finds the student with highest marks

(function () {
    var Student = Object.create({
        init: function (firstName, lastName, age, marks) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.marks = marks;
            return this;
        },

        fullname: function () {
            return this.firstName + " " + this.lastName;
        }
    });

    var students = [
        Object.create(Student).init("Nikolay", "Kostov", 23, {
            "C#": 100,
            HTML: 96,
            CSS: 97,
            JavaScript: 98
        }),
        Object.create(Student).init("Doncho", "Minkov", 27, {
            "C#": 89,
            HTML: 97,
            CSS: 98,
            JavaScript: 99
        }),
        Object.create(Student).init("Ivaylo", "Kenov", 24, {
            "C#": 99,
            HTML: 95,
            CSS: 96,
            JavaScript: 98
        }),
        Object.create(Student).init("Todor", "Stoyanov", 17, {
            "C#": 97,
            HTML: 93,
            CSS: 94,
            JavaScript: 92
        }),
        Object.create(Student).init("Pavel", "Kolev", 22, {
            "C#": 96,
            HTML: 99,
            CSS: 97,
            JavaScript: 98
        })
    ];

    console.log(new Array(111).join("*"));
    console.log('Students whose first name is before its last name alphabetically, sorted in descending order by full name are:');

    _.chain(students)
        .filter(function (student) {
            return student.firstName < student.lastName;
        })
        .sortBy("fullname")
        .reverse()
        .each(function (student) {
            console.log(student.fullname());
        });

    console.log(new Array(111).join("*"));
    console.log('Students between 18 and 24 age are:');

    _.chain(students)
        .filter(function (student) {
            return 18 <= student.age && student.age <= 24;
        })
        .each(function (student) {
            console.log(student.fullname() + ' - ' + student.age + ' age');
        });

    console.log(new Array(111).join("*"));
    console.log('Student with highest marks is:');

    var bestStudent = _.chain(students)
               .map(function (student) {
                   var sum = 0,
                       length = 0;

                   _.each(student.marks, function (mark) {
                       sum += mark;
                       length++;
                   });

                   return {
                       studentName: student.firstName + ' ' + student.lastName,
                       averageMark: sum / length
                   };
               })
               .sortBy("averageMark")
               .last()
               .value();

    console.log(bestStudent.studentName + ' --> ' + bestStudent.averageMark);
    console.log(new Array(111).join("*"));
}());