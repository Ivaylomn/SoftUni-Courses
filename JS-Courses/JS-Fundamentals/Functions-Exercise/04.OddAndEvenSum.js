function oddAndEvenSum(num) {
    let numAsString = num.toString();
    let evenSum = 0;
    let oddSum = 0;
    for (const el of numAsString) {
        let currentEl = Number(el);
        if (currentEl % 2 === 0) {
            evenSum += currentEl;
        } else {
            oddSum += currentEl;
        }
    }

    return `Odd sum = ${oddSum}, Even sum = ${evenSum}`;
}

console.log(oddAndEvenSum(1000435));
console.log(oddAndEvenSum(3495892137259234));