function sumNumbers(firstElement, secondElement) {
    let sum = 0;
    firstNum = Number(firstElement);
    secondNum = Number(secondElement);
    for (let i = firstNum; i <= secondNum; i++) {
        sum += i;
    }
    return sum;
}
console.log(sumNumbers('1', '5'));
console.log(sumNumbers('-8', '20'));