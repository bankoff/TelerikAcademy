/// <reference path="jquery-2.1.1.min.js" />
// Implement a GridView control
// Rows can be added dynamically
// A header row can be added dynamically
// Each GridView can have at most one header row
// Each row can have  a nested GridView
// Each GridView can have at most one nested GridView

$('body').append(generateGridView());

function generateGridView() {
    var $gridview = $('<div/>'),
		hasHeader = false,

		$table = $('<table/>'),
		$row = $('<tr/>'),
		$cell = $('<td/>'),
		$header = $('<th/>'),

		$firstCellContent = $('<input />').attr('placeholder', 'Enter cell content').attr('type', 'text').css('display', 'block'),
		$secondCellContent = $firstCellContent.clone(true),
		$thirdCellContent = $firstCellContent.clone(true),
		$addRowBtn = $('<a/>').attr('href', '#').html('Add row');

    $addRowBtn.addClass('button');
    $addRowBtn.css('padding', '10px')
        .css('margin', '20px');


    var $addHeaderBtn = $addRowBtn.clone(true).html('Add header'),
		$removeHeaderBtn = $addRowBtn.clone(true).html('Remove header'),
		$addGridBtn = $addRowBtn.clone(true).html('Add gridview');

    $gridview.addClass('gridview')
	.append($firstCellContent)
	.append($secondCellContent)
	.append($thirdCellContent)
	.append($addRowBtn)
	.append($addHeaderBtn)
	.append($removeHeaderBtn)
	.append($addGridBtn)
	.append($table);

    $gridview.css('border', '1px solid black')
        .css('display', 'inline-block')
        .css('padding', '10px')
        .css('background-color', 'gold')
        .css('margin', '10px');

    $table.css('border-spacing', '0')
        .css('border-collapse', 'collapse');

    $cell.css('width', ' 350px')
        .css('border', '1px solid black');

    $header.css('width', ' 350px')
        .css('border', '1px solid black')
        .css('background-color', 'lightgrey');

    $gridview.on('click', '> .button:first-of-type', function () {
        debugger;
        var $this = $(this).parent(),
			$newRow = $row.clone(true),
			$cells = $this.find('> input');

        for (var i = 0, len = $cells.length; i < len; i++) {
            var $newCell = $cell.clone(true),
				content = $cells[i].value;

            if (content === '') {
                content = '&nbsp;';
            }

            $newCell.html(content);
            $newRow.append($newCell);
        }

        $this.find('> table:first-of-type').append($newRow);
    });

    $gridview.on('click', '> .button:nth-of-type(2)', function () {
        if (hasHeader) {
            return;
        }

        var $this = $(this).parent(),
			$firstRow = $row.clone(true),
			$cells = $this.find('> input');


        for (var i = 0, len = $cells.length; i < len; i++) {
            var $newHeader = $header.clone(true),
				content = $cells[i].value;

            if (content === '') {
                content = '&nbsp;'
            }

            $newHeader.append(content);
            $firstRow.append($newHeader);
        }

        $this.find('> table:first-of-type').prepend($firstRow);
        hasHeader = true;
    });

    $gridview.on('click', '> .button:nth-of-type(3)', function () {
        var $this = $(this).parent();

        if (hasHeader) {
            $this.find('> table:first-of-type').find('tr:first-child').remove();
            hasHeader = false;
        }
    });

    $gridview.on('click', '> .button:last-of-type', function () {
        var $this = $(this).parent(),
			$newRow = $row.clone(true),
			$newCell = $cell.clone(true),
			$newGrid = generateGridView();

        $newCell.html($newGrid[0]).attr('colspan', 3);
        $newRow.append($newCell);
        $this.find('> table:first-of-type').append($newRow);
    });

    return $gridview;
};