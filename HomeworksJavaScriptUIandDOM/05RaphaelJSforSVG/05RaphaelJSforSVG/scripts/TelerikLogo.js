var paper, set;
paper = Raphael(10, 10, 900, 600);

paper.setStart();

paper.path('M125 75 L150 50 L215 115 L180 150 L145 115 L215 50 L240 75').attr({ stroke: '#5CE600', 'stroke-width': 15 });
paper.text(260, 115, 'Telerik').attr({ stroke: '#000000', 'stroke-width': 4,  'text-anchor': 'start','font-size': '130px', });
paper.text(650, 105, '®').attr({ stroke: '#000000', 'stroke-width': 0, 'text-anchor': 'start', 'font-size': '40px', });
paper.text(287, 200, 'Develop experiences').attr({ stroke: '#000000', 'stroke-width': 0, 'text-anchor': 'start', 'font-size': '56px', });

set = paper.setFinish();
set.attr({
    'font-family': 'Arial'
});
