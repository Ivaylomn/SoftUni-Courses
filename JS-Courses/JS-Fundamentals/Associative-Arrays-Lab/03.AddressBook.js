function addressBook(input) {
    let storage = {};
    for (const line of input) {
        let [name, address] = line.split(':');
        storage[name] = address;
    }
    Object
        .keys(storage)
        .sort((a, b) => a.localeCompare(b))
        .forEach(key => console.log(`${key} -> ${storage[key]}`));
}

addressBook(['Tim:Doe Crossing',
    'Bill:Nelson Place',
    'Peter:Carlyle Ave',
    'Bill:Ornery Rd'
]);