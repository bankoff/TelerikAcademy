/// <reference path="jquery-2.1.1.min.js" />

$('<button>').text('Generate Table').on('click', testFunctionality).appendTo('body');

function testFunctionality() {
    var students = [{
        firstName: 'Peter',
        lastName: 'Ivanov',
        grade: 3
    }, {
        firstName: 'Milena',
        lastName: 'Grigorova',
        grade: 6
    }, {
        firstName: 'Gergana',
        lastName: 'Borisova',
        grade: 12
    }, {
        firstName: 'Boyko',
        lastName: 'Petrov',
        grade: 7
    }];

    var $table = $('<table>')
        .css('border-collapse', 'collapse')
        .appendTo('body');

    var $thead = $('<thead>').appendTo($table);
    var $tr = $('<tr>').appendTo($thead);
    $tr.append($('<th>').text('First name'));
    $tr.append($('<th>').text('Last name'));
    $tr.append($('<th>').text('Grade'));
    var $tbody = $('<tbody>').appendTo($table);

    for (var i in students) {
        var $student = $('<tr>');
        $student.append($('<td>').text(students[i].firstName));
        $student.append($('<td>').text(students[i].lastName));
        $student.append($('<td>').text(students[i].grade));
        $student.appendTo($tbody);
    }

    var $cell = $('th,td');
    $cell.css('border', '1px solid black')
        .css('padding', '5px');
    $('<br/>').appendTo($tbody);
}