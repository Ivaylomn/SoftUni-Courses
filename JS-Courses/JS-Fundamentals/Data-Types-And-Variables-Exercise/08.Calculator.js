function calculator(firstNum, operator, secondNum) {
    let result = 0;
    if (operator === '+') {
        result = firstNum + secondNum;
    } else if (operator === '-') {
        result = firstNum - secondNum;
    } else if (operator === '*') {
        result = firstNum * secondNum;
    } else if (operator === '/') {
        result = firstNum / secondNum;
    }

    console.log(result.toFixed(2));
}

calculator(5, '+', 10);
calculator(25.5, '-', 3);