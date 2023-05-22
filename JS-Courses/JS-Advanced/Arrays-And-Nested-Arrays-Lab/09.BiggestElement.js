function biggestElement(matrix) {
    let result = Number.MIN_SAFE_INTEGER;
    for (const arr of matrix) {
        let maxNumber = Math.max(...arr);
        if (result < maxNumber) {
            result = maxNumber;
        }
    }
    return result;
}
console.log(biggestElement([[20, 50, 10],
[8, 33, 145]]
));