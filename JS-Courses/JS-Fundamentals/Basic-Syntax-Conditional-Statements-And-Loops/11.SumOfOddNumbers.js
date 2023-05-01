function sumOfOddNumber(num) {
    let sum = 0;
    for (let i = 1; i <= num * 2; i++) {
        if (i % 2 === 1){
            console.log(i);
            sum += i;
        }
    }

    console.log(`Sum: ${sum}`);
}

sumOfOddNumber(5);
sumOfOddNumber(3);