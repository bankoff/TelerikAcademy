// By a given collection of books, find the most popular author (the author with the highest number of books)

(function () {
    var books = [
        {
            title: "Pod igoto",
            author: "Ivan Vazov",
        }, {
            title: "Na Balgaria",
            author: "Ivan Vazov",
        }, {
            title: "Dizraeli",
            author: "Ivan Vazov",
        }, {
            title: "Polet",
            author: "Ivan Vazov",
        }, {
            title: "Prolet",
            author: "Elin Pelin",
        }, {
            title: "Izbrani razkazi",
            author: "Angel Karaliychev",
        }
    ];

    var mostPopularAuthor = _.chain(books)
        .countBy(function(book) { return book.author; })
        .invert()
        .pairs()
        .last()
        .value();

    console.log('The most popular author is ' + mostPopularAuthor[1] + ' with ' + mostPopularAuthor[0] + ' books');
})();