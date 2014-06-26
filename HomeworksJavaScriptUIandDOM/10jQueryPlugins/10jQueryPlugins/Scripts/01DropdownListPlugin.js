/// <reference path="jquery-2.1.1.min.js" />
$.fn.dropdown = function () {
    var $this = $(this),
        $options = $this.children(),
        $container = $('<div/>'),
        $dropdownMenu = $('<ul/>'),
        $item = $('<li/>');
    
    $container.addClass('dropdown-list-container');
    $dropdownMenu.addClass('dropdown-list-options');
    $item.addClass('dropdown-list-option');
    
    $item.on('click', function () {
        var $this = $(this),
            $dropdown = $('#dropdown'),
            $optionSelected = $($dropdown[0][$this.attr('data-value')]);
        
        $this.siblings().removeClass('selected');
        $this.addClass('selected');
        
        $dropdown.children().attr('selected', false);
        $optionSelected.attr('selected', true);
    });
    
    for (var i = 0, len = $options.length; i < len; i++) {
        var $newItem = $item.clone(true),
            content = $($options[i]).html();
        
        $newItem.text(content);
        $newItem.attr('data-value', i);
        $dropdownMenu.append($newItem);
    }
    
    $container.append($dropdownMenu);
    $this.after($container);
};

$('#dropdown').dropdown();