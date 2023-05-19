function solve(numOne, numTwo) {
    let arr = [1];
    for (let i = 1; i < numOne; i++) {
        let sum = 0;
        for (const el of arr.slice(-numTwo)) {
            sum += el;
        }
        arr.push(sum);
    }
    return arr;
}
console.log(solve(6, 3));
console.log(solve(8, 2));