function largestNumber(firstNum, secondNum, thirdNum) {
    let result;
    if (firstNum > secondNum && firstNum > thirdNum) {
        result = firstNum;
    } else if (secondNum > firstNum && secondNum > thirdNum) {
        result = secondNum;
    } else if (thirdNum > firstNum && thirdNum > secondNum) {
        result = thirdNum;
    }

    console.log(`The largest number is ${result}.`);
    //And single line solution->
    console.log(`The largest number is ${Math.max(firstNum, secondNum, thirdNum)}.`);
}

largestNumber(5, -3, 16);
largestNumber(-3, -5, -22.5);