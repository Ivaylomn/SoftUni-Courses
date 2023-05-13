function phoneBook(input) {
    let storagePhone = {};
    for (const el of input) {
        let [name, phone] = el.split(' ');
        storagePhone[name] = phone;
    }
    //Print with FORIN loop->
    for (const key in storagePhone) {
        console.log(`${key} -> ${storagePhone[key]}`);
    }
    //Print with FOROF loop ->
    for (const [key, value] of Object.entries(storagePhone)) {
        console.log(`${key} -> ${value}`);
    }
    //Print with forEach->
    Object.keys(storagePhone).forEach(key => console.log(`${key} -> ${storagePhone[key]}`));
}

phoneBook(['Tim 0834212554',
    'Peter 0877547887',
    'Bill 0896543112',
    'Tim 0876566344'
]);