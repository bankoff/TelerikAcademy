(function () {
    require.config({
        paths: {
            "jquery": "libs/jquery-2.1.1",
            "handlebars": "libs/handlebars",
            "controls": "controls"
        }
    });

    require(['people', 'controls', 'jquery'], function (people, controls, $) {
        var comboBox = controls.ComboBox(people);
        var template = $("#person-template").html();
        var comboBoxHtml = comboBox.render(template);
        $('#container').html(comboBoxHtml);
    });
}());