define(['jquery', 'handlebars'], function () {
    var ComboBox = function (people) {
        this._people = people;
    };

    ComboBox.prototype.render = function (templateHtml) {

        var template = Handlebars.compile(templateHtml);
        var $buffer = $('<div/>').addClass('comboBox');

        this._people.forEach(function (item) {
            $(template(item)).addClass('box-item').appendTo($buffer);
        });

        $buffer.on('click', '.box-item', function () {
            $(this).addClass('selected').show().siblings().removeClass('selected').slideToggle('fast');
        });

        return $buffer[0];
    };

    return {
        ComboBox: function (people) {
            return new ComboBox(people);
        }
    };
});