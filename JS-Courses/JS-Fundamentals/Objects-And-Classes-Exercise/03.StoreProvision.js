function storeProvision(firstArray, secondArray) {
    let shops = {};
    for (let i = 0; i < firstArray.length; i += 2) {
        let element = firstArray[i];
        shops[element] = Number(firstArray[i + 1]);
    }
    for (let i = 0; i < secondArray.length; i += 2) {
        let element = secondArray[i];
        let quantity = Number(secondArray[i + 1]);
        if (!shops.hasOwnProperty(element)) {
            shops[element] = quantity
            continue;
        }
        shops[element] += quantity;
    }
    for (const [key, value] of Object.entries(shops)) {
        console.log(`${key} -> ${value}`);
    }
    // Print with foreach
    // Object.keys(shops).forEach(element => {
    //     console.log(`${element} -> ${shops[element]}`);
    // });
}

storeProvision(
    [
        'Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'
    ],
    [
        'Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'
    ]);