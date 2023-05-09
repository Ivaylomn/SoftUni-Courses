function train(commands) {
    let trainArr = commands
        .shift()
        .split(' ')
        .map(Number);

    let maxCapacityForWagon = Number(commands.shift());
    for (let i = 0; i < commands.length; i++) {
        let [commArgs, element] = commands[i].split(' ');
        element = Number(element);
        if (commArgs === 'Add') {
            trainArr.push(element);
        } else {
            for (let j = 0; j < trainArr.length; j++) {
                if (!(trainArr[j] + Number(commArgs) > maxCapacityForWagon)) {
                    let sum = trainArr[j] + Number(commArgs);
                    trainArr[j] = sum;
                    break;
                }
            }
        }
    }

    console.log(trainArr.join(' '));
}

train(['32 54 21 12 4 0 23',
    '75',
    'Add 10',
    'Add 0',
    '30',
    '10',
    '75'
]);
train(['0 0 0 10 2 4',
    '10',
    'Add 10',
    '10',
    '10',
    '10',
    '8',
    '6'
]);