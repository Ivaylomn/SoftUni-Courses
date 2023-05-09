function houseParty(input) {
    let guestArr = [];
    for (const el of input) {
        let commands = el.split(' ');
        let name = commands[0];
        if (!commands.includes('not')) {
            if (guestArr.includes(name)) {
                console.log(`${name} is already in the list!`);
                continue;
            }
            guestArr.push(name);
        } else {
            if (guestArr.includes(name)) {
                let index = guestArr.indexOf(name);
                guestArr.splice(index, 1);
            } else {
                console.log(`${name} is not in the list!`);
            }
        }
    }
    console.log(guestArr.join('\n'));
}

houseParty(['Allie is going!',
    'George is going!',
    'John is not going!',
    'George is not going!'
]);
houseParty(['Tom is going!',
    'Annie is going!',
    'Tom is going!',
    'Garry is going!',
    'Jerry is going!'
]);