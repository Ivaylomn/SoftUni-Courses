function minerTask(input) {
    let obj = {};
    for (let i = 0; i < input.length; i += 2) {
        let name = input[i];
        let quantity = Number(input[i + 1]);
        if (!obj.hasOwnProperty(name)) {
            obj[name] = 0
        }
        obj[name] += quantity
    }
    for (const key in obj) {
        console.log(`${key} -> ${obj[key]}`);
    }
}

minerTask([
    'Gold',
    '155',
    'Silver',
    '10',
    'Copper',
    '17'
]);
minerTask([
    'gold',
    '155',
    'silver',
    '10',
    'copper',
    '17',
    'gold',
    '15'
]);