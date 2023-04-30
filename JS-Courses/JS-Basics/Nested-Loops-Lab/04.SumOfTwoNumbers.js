function sumOfTwoNumbers(input) {
    let startNumber = Number(input[0]);
    let endNumber = Number(input[1]);
    let magicNumber = Number(input[2]);

    let count = 0;
    for (let i = startNumber; i <= endNumber; i++) {
        for (let j = startNumber; j <= endNumber; j++) {
            let result = i + j;
            count++;
            if (result === magicNumber) {
                console.log(`Combination N:${count} (${i} + ${j} = ${magicNumber})`)
                return;
            }
        }
    }

    console.log(`${count} combinations - neither equals ${magicNumber}`);
}

sumOfTwoNumbers(["1", "10", "5"]);
sumOfTwoNumbers(["88", "888", "1000"]);
sumOfTwoNumbers(["23", "24", "20"]);
sumOfTwoNumbers(["88", "888", "2000"]);