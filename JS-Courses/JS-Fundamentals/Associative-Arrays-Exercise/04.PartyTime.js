function partyTime(arr) {
    let partyObj = {
        'VIP': [],
        'regular': []
    };
    let name = arr.shift();
    while (name !== 'PARTY') {
        if (isNaN(name[0])) {
            partyObj.regular.push(name);
        } else {
            partyObj.VIP.push(name);
        }
        name = arr.shift();
    }
    for (const el of arr) {
        if (partyObj.VIP.includes(el)) {
            let index = partyObj.VIP.indexOf(el);
            partyObj.VIP.splice(index, 1);
        } else if (partyObj.regular.includes(el)) {
            let index = partyObj.regular.indexOf(el);
            partyObj.regular.splice(index, 1);
        }
    }
    console.log(partyObj.VIP.length + partyObj.regular.length);
    console.log(partyObj.VIP.join('\n'));
    console.log(partyObj.regular.join('\n'));
}

partyTime(['7IK9Yo0h',
    '9NoBUajQ',
    'Ce8vwPmE',
    'SVQXQCbc',
    'tSzE5t0p',
    'PARTY',
    '9NoBUajQ',
    'Ce8vwPmE',
    'SVQXQCbc'
]);