function piccolo(arr) {
    let parking = {};
    for (const el of arr) {
        let [dircetion, carNumber] = el.split(', ');
        if (dircetion === 'IN') {
            parking[carNumber] = 'IN';
        } else {
            delete parking[carNumber];
        }
    }
    Object.keys(parking).sort((a, b) => a.localeCompare(b)).forEach(x => console.log(x));
}
piccolo(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'IN, CA9999TT',
    'IN, CA2866HI',
    'OUT, CA1234TA',
    'IN, CA2844AA',
    'OUT, CA2866HI',
    'IN, CA9876HH',
    'IN, CA2822UU'
]);
piccolo(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'OUT, CA1234TA'
]);