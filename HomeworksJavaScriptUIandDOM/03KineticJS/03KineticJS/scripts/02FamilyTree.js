// Using Kinetic create a family tree

(function () {
    'use strict';
    /*jslint browser: true */
    /*jslint node: true */
    /*jslint plusplus: true */
    /*jslint vars: true */
    /*global Kinetic*/
    var i,
        l,
        childIndex,
        indexOfMotherInChildren,
        indexOfFatherInChildren,
        familyMembers,
        startXCoord,
        startYCoord,
        parentName,
        index;

    familyMembers = [
        {
            mother: 'Maria Petrova',
            father: 'Georgi Petrov',
            children: []
        },
        {
            mother: 'Petra Stamatova',
            father: 'Todor Stamatov',
            children: ['Andrej Stamatov', 'Maria Petrova']
        },
        {
            mother: 'Ginka Stamatova',
            father: 'Andrej Stamatov',
            children: ['Ivelin Stamatov', 'Lena Stamatova']
        },
        {
            mother: 'Lena Stamatova',
            father: 'Kiril Dobrev',
            children: ['Emil Dobrev', 'Stefan Dobrev']
        },
        {
            mother: 'Nadejda Ivancheva',
            father: 'Emil Dobrev',
            children: ['Hristo Dobrev', 'Bogomil Dobrev']
        },
        {
            mother: 'Natalia Ivancheva',
            father: 'Stefan Dobrev',
            children: ['Evelina Dobreva']
        },
        {
            mother: 'Evelina Dobreva',
            father: 'Kuzman Dimov',
            children: ['Valentin Dimov']
        },
        {
            mother: 'Simona Hristova',
            father: 'Valentin Dimov',
            children: ['Emil Dimov', 'Kiril Dimov']
        }
    ];

    for (i = 0; i < familyMembers.length; i++) {
        familyMembers[i].level = 0;
        familyMembers[i].indexWithChildren = [];
    }

    function increaseLevels(family) {
        var child;
        family.level++;
        if (family.indexWithChildren.length === 0) {
            return;
        }

        for (child in family.indexWithChildren) {
            if (family.indexWithChildren.hasOwnProperty(child)) {
                increaseLevels(family[family.indexWithChildrens[child]]);
            }
        }
    }

    var familyTree = [];
    var stage = new Kinetic.Stage({
        container: 'container',
        width: 2000,
        height: 2000,
    });

    var layer = new Kinetic.Layer();

    function drawArrow(fromx, fromy, tox, toy) {
        var headlen = 10;
        var angle = Math.atan2(toy - fromy, tox - fromx);
        var line = new Kinetic.Line({
            points: [fromx, fromy, tox, toy, tox - headlen * Math.cos(angle - Math.PI / 15), toy - headlen * Math.sin(angle - Math.PI / 15),
                    tox, toy, tox - headlen * Math.cos(angle + Math.PI / 15), toy - headlen * Math.sin(angle + Math.PI / 15)],
            stroke: "green"
        });

        return line;
    }

    function addLines(indexOfFamily) {
        var c,
            el,
            nameOfChild,
            endXCoord,
            endYCoord;
        for (c = 0; c < familyMembers[indexOfFamily].children.length; c++) {
            nameOfChild = familyMembers[indexOfFamily].children[c];
            for (el = 0; el < familyTree.length; el++) {
                if (familyTree[el].textArr) {
                    if (familyTree[el].textArr[0].text === nameOfChild) {
                        endXCoord = familyTree[el].getX() + 70;
                        endYCoord = familyTree[el].getY() - 15;
                        layer.add(drawArrow(startXCoord-20, startYCoord, endXCoord-20, endYCoord-2));
                    }
                }
            }
        }
    }

    for (i = 0; i < familyMembers.length; i++) {
        for (l = 0; l < familyMembers.length; l++) {
            indexOfMotherInChildren = familyMembers[l].children.indexOf(familyMembers[i].mother);
            indexOfFatherInChildren = familyMembers[l].children.indexOf(familyMembers[i].father);
            if (indexOfMotherInChildren !== -1 || indexOfFatherInChildren !== -1) {
                familyMembers[l].indexWithChildren.push(i);
                familyMembers[i].level = familyMembers[l].level + 1;
                if (familyMembers[i].indexWithChildren.length !== 0) {
                    for (childIndex in familyMembers[i].indexWithChildren) {
                        if (familyMembers[i].indexWithChildren.hasOwnProperty(childIndex)) {
                            increaseLevels(familyMembers[familyMembers[i].indexWithChildren[childIndex]]);
                        }
                    }
                }
            }
        }
    }

    var text;

    var countEqualLevels = [];
    var prop;
    var child;
    for (i = 0; i < familyMembers.length; i++) {
        if (countEqualLevels[familyMembers[i].level] === undefined) {
            countEqualLevels[familyMembers[i].level] = 0;
        }

        for (prop in familyMembers[i]) {
            if (familyMembers[i].hasOwnProperty(prop)) {
                if (prop === "mother") {
                    familyTree.push(new Kinetic.Rect({
                        x: countEqualLevels[familyMembers[i].level] * 160,
                        y: familyMembers[i].level * 120,
                        width: 150,
                        height: 40,
                        fill: 'yellow',
                        stroke: 'green'
                    }));
                    text = familyMembers[i][prop];
                    familyTree.push(new Kinetic.Text({
                        x: countEqualLevels[familyMembers[i].level] * 160 + 25,
                        y: familyMembers[i].level * 120 + 15,
                        text: text,
                        fill: 'black',
                    }));
                    countEqualLevels[familyMembers[i].level]++;
                }
                if (prop === "father") {
                    familyTree.push(new Kinetic.Rect({
                        x: countEqualLevels[familyMembers[i].level] * 160,
                        y: familyMembers[i].level * 120,
                        width: 150,
                        height: 40,
                        fill: 'green',
                        stroke: 'blue'
                    }));
                    text = familyMembers[i][prop];
                    familyTree.push(new Kinetic.Text({
                        x: countEqualLevels[familyMembers[i].level] * 160 + 25,
                        y: familyMembers[i].level * 120 + 15,
                        text: text,
                        fill: 'black',
                    }));
                    countEqualLevels[familyMembers[i].level]++;
                }
                if ((prop === "children") && (familyMembers[i].indexWithChildren.length === 0)) {
                    if (!countEqualLevels[familyMembers[i].level + 1]) {
                        countEqualLevels[familyMembers[i].level + 1] = 0;
                    }

                    for (child in familyMembers[i].children) {
                        if (familyMembers[i].children.hasOwnProperty(child)) {
                            familyTree.push(new Kinetic.Rect({
                                x: countEqualLevels[familyMembers[i].level + 1] * 160,
                                y: (familyMembers[i].level + 1) * 120,
                                width: 150,
                                height: 40,
                                fill: 'green',
                                stroke: 'blue'
                            }));
                            text = familyMembers[i].children[child];
                            familyTree.push(new Kinetic.Text({
                                x: countEqualLevels[familyMembers[i].level + 1] * 160 + 25,
                                y: (familyMembers[i].level + 1) * 120 + 15,
                                text: text,
                                fill: 'black',
                                fontFamily: 'Consolas'
                            }));
                            countEqualLevels[familyMembers[i].level + 1]++;
                        }
                    }
                    addLines(i);
                }
            }
        }
    }

    function findElement(name) {
        var m;
        for (m = 0; m < familyMembers.length; m++) {
            if (familyMembers[m].mother === name || familyMembers[m].father === name) {
                return m;
            }
        }
    }

    for (i = 0; i < familyTree.length; i++) {
        if (familyTree[i].textArr) {
            startXCoord = familyTree[i].getX() + 70;
            startYCoord = familyTree[i].getY() + 25;
            parentName = familyTree[i].textArr[0].text;
            index = findElement(parentName);
            if (index) {
                addLines(index);
            }
        }
        layer.add(familyTree[i]);
    }

    stage.add(layer);
}());