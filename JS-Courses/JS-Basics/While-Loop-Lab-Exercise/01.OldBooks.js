function oldBooks(input) {
    let aniBook = input[0];
    let index = 1;
    let books = input[index];
    let count = 0;
    while (books !== "No More Books") {
        if (aniBook === books) {
            console.log(`You checked ${count} books and found it.`)
            return;
        }
        count++;
        index++;
        books = input[index];
    }

    console.log("The book you search is not here!");
    console.log(`You checked ${count} books.`)
}

oldBooks(["Troy",
    "Stronger",
    "Life Style",
    "Troy"
]);
oldBooks(["The Spot",
"Hunger Games",
"Harry Potter",
"Torronto",
"Spotify",
"No More Books"
]);