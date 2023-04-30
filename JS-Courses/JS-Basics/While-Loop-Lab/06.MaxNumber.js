function maxNumber(input) {
    let index = 0;
    let maxNumber = Number.MIN_SAFE_INTEGER;

    while (input[index] != "Stop") {
        if (Number(input[index]) >= maxNumber) {
            maxNumber = input[index];
        }
        index++;
    }

    console.log(maxNumber);
}

maxNumber(["100",
"99",
"80",
"70",
"Stop"]);
