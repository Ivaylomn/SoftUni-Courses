function GCD(numOne, numTwo) {
    let result;
    for (let i = 1; i <= numTwo; i++) {
        if (numOne % i === 0 && numTwo % i === 0) {
             result = i;
        }
    }
    console.log(result);
}
GCD(15, 5);
GCD(2154, 458);