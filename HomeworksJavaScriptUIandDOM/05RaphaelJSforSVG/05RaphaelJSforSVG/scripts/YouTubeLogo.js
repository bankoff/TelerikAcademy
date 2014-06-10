var paper, set;
paper = Raphael(10, 10, 900, 600);

paper.setStart();

paper.rect(310, 165, 150, 70, 20).attr({ fill: 'red', stroke: 'red' });
paper.text(200, 200, 'You').attr({ stroke: '#000000', fill: '#000000', 'stroke-width': 2, 'text-anchor': 'start', 'font-size': '56px', });

paper.text(320, 200, 'Tube').attr({ stroke: '#FFFFFF', fill: '#FFFFFF', 'stroke-width': 2, 'text-anchor': 'start', 'font-size': '56px', });

set = paper.setFinish();
set.attr({
    'font-family': 'Arial'
});