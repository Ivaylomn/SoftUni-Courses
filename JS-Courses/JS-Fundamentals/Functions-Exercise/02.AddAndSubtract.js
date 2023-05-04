function addAndSubtract(numOne, numTwo, numThree) {
    let add = (numOne, numTwo) => numOne + numTwo;
    let result = add(numOne, numTwo) - numThree;
    console.log(result);
}

addAndSubtract(23, 6, 10);
addAndSubtract(1, 17, 30);
addAndSubtract(42, 58, 100);