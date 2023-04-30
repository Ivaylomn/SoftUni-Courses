function sumNumbers(input) {
    let firstNumber = Number(input[0]);

    let index = 1;
    let sum = 0;
    while (sum < firstNumber) {
        sum +=  Number(input[index]);
        index++;
    }

    console.log(sum);
}

sumNumbers(["100",
    "10",
    "20",
    "30",
    "40"
]);
sumNumbers(["20",
    "1",
    "2",
    "3",
    "4",
    "5",
    "6"
]);

