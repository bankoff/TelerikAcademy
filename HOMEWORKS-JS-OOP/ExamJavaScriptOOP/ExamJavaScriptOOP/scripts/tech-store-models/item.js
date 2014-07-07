define(function () {
    'use strict';
    var Item;
    Item = (function () {
        function Item(type, name, price) {

            if (type) {
                this.type = type;
            } else {
                throw {
                    message: 'The price is not valid'
                };
            }

            if (name && 6 <= name.length && name.length <= 40) {
                this.name = name;
            } else {
                throw {
                    message: 'The name do not between 6 and 40 characters'
                };
            }

            if (price && price > 0) {
                this.price = price;
            } else {
                throw {
                    message: 'The price is not valid'
                };
            }

        }

        return Item;
    })();
    return Item;
});