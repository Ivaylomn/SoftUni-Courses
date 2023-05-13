function storage(input) {
    let myMap = new Map();
    for (const line of input) {
        let [product, quantity] = line.split(' ');
        quantity = Number(quantity);
        if (!myMap.has(product)) {
            myMap.set(product, quantity);
            continue;
        }
        myMap.set(product, myMap.get(product) + quantity);
    }
    for (const key of myMap.keys()) {
        console.log(`${key} -> ${myMap.get(key)}`);
    }
    Array
        .from(myMap.keys())
        .forEach(key => console.log(`${key} -> ${myMap.get(key)}`))
}

storage(['tomatoes 10',
    'coffee 5',
    'olives 100',
    'coffee 40']
);