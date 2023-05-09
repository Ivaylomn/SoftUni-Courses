function arrayManipulations(arr) {
    let arrNumbers = arr
        .shift()
        .split(' ')
        .map(Number);

        for (let i = 0; i < arr.length; i++) {
            let [command, firstNumber, secondNumber] = arr[i].split(' ');

            firstNumber = Number(firstNumber);
            secondNumber = Number(secondNumber);
            switch (command) {
                case 'Add':
                    arrNumbers.push(firstNumber);
                    break;
                case 'Remove':
                    arrNumbers = arrNumbers.filter(x => x !== firstNumber);
                break;
                case 'RemoveAt':
                    arrNumbers.splice(firstNumber, 1);
                    break;
                case 'Insert':
                    arrNumbers.splice(secondNumber, 0 , firstNumber);
                break;
            }
        }

        console.log(arrNumbers.join(' '));
}

arrayManipulations(['4 19 2 53 6 43',
    'Add 3',
    'Remove 2',
    'RemoveAt 1',
    'Insert 8 3']
);