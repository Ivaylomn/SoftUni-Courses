function simpleCalculator(numOne, numTwo, operator) {
    switch (operator) {
        case 'multiply':
            let multiply = (a, b) => a * b;
            console.log(multiply(numOne, numTwo));
            break;
        case 'divide':
            let divide = (a, b) => a / b;
            console.log(divide(numOne, numTwo));
            break;
        case 'add':
            let add = (a, b) => a + b;
            console.log(add(numOne, numTwo));
            break;
        case 'subtract':
            let subtract = (a, b) => a - b;
            console.log(subtract(numOne, numTwo));
            break;
    }
}

simpleCalculator(5, 5, 'multiply');
simpleCalculator(40, 8, 'divide');
simpleCalculator(12, 19, 'add');
simpleCalculator(50, 13, 'subtract');