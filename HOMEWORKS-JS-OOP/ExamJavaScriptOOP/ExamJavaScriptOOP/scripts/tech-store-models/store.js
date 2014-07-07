define(['tech-store-models/item'], function (Item) {
    'use strict';
    var Store;
    Store = (function () {
        function Store() {
            this._items = [];
        }

        Store.prototype.addItem = function (item) {
            if (!(item instanceof Item)) {
                throw {
                    message: 'This is not a item'
                };
            }
            this._items.push(item);
            return this;
        };

        Store.prototype.getAll = function () {
            return sortItems(this._items, 'name');
        };

        Store.prototype.getSmartPhones = function () {
            var smartPhones = [];
            for (var item in this._items) {
                if (this._items[item].type === 'smart-phone') {
                    smartPhones.push(this._items[item]);
                }
            }
            return sortItems(smartPhones, 'name');
        };

        Store.prototype.getMobiles = function () {
            var mobiles = [];
            for (var item in this._items) {
                if (this._items[item].type === 'smart-phone' || this._items[item].type === 'tablet') {
                    mobiles.push(this._items[item]);
                }
            }
            return sortItems(mobiles, 'name');
        };

        Store.prototype.getComputers = function () {
            var computers = [];
            for (var item in this._items) {
                if (this._items[item].type === 'pc' || this._items[item].type === 'notebook') {
                    computers.push(this._items[item]);
                }
            }
            return sortItems(computers, 'name');
        };


        Store.prototype.filterItemsByPrice = function (obj) {
            obj = obj || {};
            obj.min = obj.min || 0;
            obj.max = obj.max || Number.MAX_VALUE;

            var itemsToSortByPrice = [];
            for (var item in this._items) {
                if (obj.min < this._items[item].price && this._items[item].price < obj.max) {
                    itemsToSortByPrice.push(this._items[item]);
                }
            }

            return sortItemsByPrice(itemsToSortByPrice, 'price');
        };

        Store.prototype.filterItemsByType = function (type) {
            var result = [];
            for (var item in this._items) {
                if (this._items[item].type === type) {
                    result.push(this._items[item]);
                }
            }
            return sortItems(result, 'name');
        };

        Store.prototype.filterItemsByName = function (str) {
            var result = [];
            for (var item in this._items) {
                if (this._items[item].name.toLowerCase().indexOf(str.toLowerCase())>=0) {
                    result.push(this._items[item]);
                }
            }
            return sortItems(result, 'name');
        };

        Store.prototype.countItemsByType = function () {
            var result = {};
            for (var item in this._items) {
                if (result[this._items[item].type]) {
                    result[this._items[item].type] += 1;
                } else {
                    result[this._items[item].type] = 1;
                }
            }
            return result;
        };




        function sortItemsByPrice(items, sortBy) {
            items.sort(function (first, second) {
                return first[sortBy] - (second[sortBy]);
            });
            return items.slice(0);
        }

        function sortItems(items, sortBy) {
            items.sort(function (first, second) {
                return first[sortBy].localeCompare(second[sortBy]);
            });
            return items.slice(0);
        }

        return Store;
    }());
    return Store;
});