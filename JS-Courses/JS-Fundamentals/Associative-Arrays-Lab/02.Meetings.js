function meetings(input) {
    let obj = {};
    for (const line of input) {
        let [day, name] = line.split(' ');
        if (!obj.hasOwnProperty(day)) {
            console.log(`Scheduled for ${day}`);
            obj[day] = name;
            continue;
        }
        console.log(`Conflict on ${day}!`);
    }
    for (const [key, value] of Object.entries(obj)) {
        console.log(`${key} -> ${value}`);
    }
    for (const key in obj) {
        console.log(`${key} -> ${obj[key]}`);
    }
    Object.keys(obj).forEach(key => console.log(`${key} -> ${obj[key]}`));
}

meetings(['Monday Peter',
    'Wednesday Bill',
    'Monday Tim',
    'Friday Tim'
]);